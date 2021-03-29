using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mosquito
{
    ///Author: Henry Reynaud
    /// <summary>
    /// This form serves as the initial window a user will get if they are using bad applications
    /// while they have our program enabled. It also serves as the parent to create the annoying
    /// popup windows, captcha windows, and button trial windows to disturb and annoy the user. 
    /// The window also displays which applications are causing it to pop up, allowing the user a
    /// a chance to close out of them before the annoyance begins.
    /// </summary>
    public partial class initialAnnoyanceWindow : Form 
    { 
        //timers to track when to cause popups and to check if the popups should be closed
        private Timer timer = new Timer();
        private Timer timer2 = new Timer();

        //list which displays in the form's textbox, showing which applications are causing the window to show
        public static List<string> displayList;
        
        //the various instances of the popup windows that can be created from this form to annoy the user
        public popupWindow[] popups = new popupWindow[100];
        public captchaWindow captcha;
        public captchaWindow captcha_level2_1;
        public captchaWindow captcha_level2_2;
        public buttonTrial bt_level2_1;
        public buttonTrial bt_level2_2;

        //variables for tracking if and when to shut down the annoyance window
        public bool disable = false;
        private int total_popups;
        private int completed_windows = 0;
        public bool open = true;

        //levels to monitor the intensity of the annoyance popup windows 
        private bool level1 = true;
        private bool level2 = false;

        /// <summary>
        /// Constructor for the class - sets visual style and sets some parameters
        /// </summary>
        public initialAnnoyanceWindow()
        {
            InitializeComponent();
            GUI.setFormVisuals(this, label1);
            GUI.richtxtSetUp(display);
            GUI.txtSetUp(state_Text);
            GUI.txtSetUp(currBadApps);
            total_popups = 0;
            completed_windows = 0;
        }

        /// <summary>
        /// Updates the list of bad applications which are currently running to display them
        /// on the form's textbox. Also clears the popup windows on the screen.
        /// </summary>
        /// <param name="newlist">
        /// The updated list of currently running bad applications, given by AppDetector
        /// </param>
        public static void update_Annoyance_List(List<string> newlist)
        {
            displayList = newlist;
        }

        /// <summary>
        /// Function which is called by the child captcha and button trial forms created by this
        /// this form. A way of ensuring those forms get completed. This function then determines
        /// if this level of annoyance is complete and resumes the timers for the form. 
        /// </summary>
        /// <param name="level">
        /// Annoyance level that the forms were created in -- used to determine which level will be next
        /// </param>
        public void returnFromLevel(int level)
        {
            //this.Show();
            if (level == 1)
            {
                if (total_popups > 0)
                {
                    for (int i = 0; i < total_popups; i++)
                    {
                        popups[i].Close();
                    }
                    total_popups = 0;
                }

                if (open)
                {
                    level2 = true;
                    state_Text.Text = "You really need to close those apps.";
                    timer.Start();
                }
            }

            else if (level == 2)
            {
                completed_windows++;
                Console.WriteLine("completed windows = " + completed_windows);
                if (completed_windows == 4)
                {
                    completed_windows = 0;
                    if (total_popups > 0)
                    {
                        for (int i = 0; i < total_popups; i++)
                        {
                            popups[i].Close();
                        }
                        total_popups = 0;
                    }

                    if (open)
                    {
                        state_Text.Text = "Seriously, get back to work.";
                        timer.Start();
                    }
                }

            }
        }


        /// <summary>
        /// Loads the initialAnnoyanceWindow instance -- displasys the textbox with the current
        /// list of bad applications running, and creats the timers and begins them.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initialAnnoyanceWindow_Load(object sender, EventArgs e)
        {
            display.ReadOnly = true;
            foreach (var text in displayList)
            {
                var writeText = "- " + text + "\r\n";
                display.AppendText(writeText);
            }

            state_Text.Text = "You are distracted. Get back to work.";
            currBadApps.Text = "Applications Open";
            //Timer newtimer = new Timer();
            timer.Interval = (10 * 1000);
            timer.Tick += new EventHandler(newtimer_Tick);
            timer.Start();

            timer2 = new Timer();
            timer2.Interval = (5 * 1000);
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();


        }

        //@brief - Timer tick event which triggers the creation of the popups and captcha and/or 
        //          button trial windows, depending on the current annoyance levels.
        //@param sender
        //@param e
        //@return void

        /// <summary>
        /// Timer tick event which triggers the creation of the popups and captcha and/or  
        /// button trial windows, depending on the current annoyance levels.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newtimer_Tick(object sender, EventArgs e)
        {
            if (level1)
            {
                level1 = false;
                state_Text.Text = "We warned you.";
                timer.Stop();


                for (int i = total_popups; i < total_popups + 10; i++)
                {
                    popupWindow fromCheck = new popupWindow();
                    popups[i] = fromCheck;
                    popups[i].Show();
                }
                total_popups += 10;
                captcha = new captchaWindow(this, 1);
                captcha.Show();
            }

            else if (level2)
            {
                //level2 = false;
                state_Text.Text = "Here it comes again.";
                timer.Stop();

                for (int i = total_popups; i < total_popups + 30; i++)
                {
                    popupWindow fromCheck = new popupWindow();
                    popups[i] = fromCheck;
                    popups[i].Show();
                }
                total_popups += 30;

                captcha_level2_1 = new captchaWindow(this, 2);
                captcha_level2_1.Show();

                captcha_level2_2 = new captchaWindow(this, 2);
                captcha_level2_2.Show();

                bt_level2_1 = new buttonTrial(this, 2);
                bt_level2_1.Show();

                bt_level2_2 = new buttonTrial(this, 2);
                bt_level2_2.Show();

            }
        }

        /// <summary>
        /// Timer to update the displayed list of bad applications.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            display.Text = "";
            foreach (var text in displayList)
            {
                var writeText = "- " + text + "\r\n";
                display.AppendText(writeText);
            }
        }

        /// <summary>
        /// The closing function for this form. First checks if the user is trying to close it
        /// without having closed their bad applications or enabling their free time, where it will 
        /// then stay open in the background. Otherwise, it will stop the timers, close out all 
        /// open popups, but the captcha and button trial windows will need to be completed still
        /// before they close out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initialAnnoyanceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((!detection_signals.freetime_check && detection_signals.detected_check) && !disable)
            {
                this.Hide();
                e.Cancel = true;
            }
            else
            {
                timer.Stop();
                timer2.Stop();
                open = false;
                if (total_popups > 0)
                {
                    for (int i = 0; i < total_popups; i++)
                    {
                        popups[i].Close();
                    }
                    total_popups = 0;
                }

                //foreach (Form frm in fc)
                //{
                //    Console.WriteLine("form = " + frm.Name);
                //    if (level1)
                //    {
                //        if (frm.Name == "captchaWindow")
                //        {
                //            captcha.completed = true;
                            
                //            frm.Close();
                //        }
                //    }
                //    else if (level2)
                //    {
                //        if (frm.Name == "captchaWindow")
                //        {

                //            captcha_level2_1.completed = true;
                //            captcha_level2_2.completed = true;
                //            frm.Close();
                //        }
                //    }

                //    else if (frm.Name == "buttonTrial")
                //    {
                //        frm.Close();
                //    }

                   

                //}

            }
        }

        /// <summary>
        /// A sized changed function for this form which prevents the user from 
        /// minimizing this window. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initialAnnoyanceWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
