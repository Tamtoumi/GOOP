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
    public partial class initialAnnoyanceWindow : Form 
    { 
        Timer timer = new Timer();

        public static List<string> displayList = new List<string>();
        popupWindow[] popups = new popupWindow[100];
        captchaWindow captcha;
        captchaWindow captcha_level2_1;
        captchaWindow captcha_level2_2;
        buttonTrial bt_level2_1;
        buttonTrial bt_level2_2;


        int total_popups;
        int completed_windows = 0;
        bool open = false;

        FormCollection fc = Application.OpenForms;



        bool level1 = true;
        bool level2 = false;
        bool level3 = false;

        public initialAnnoyanceWindow()
        {
            InitializeComponent();
            total_popups = 0;
            completed_windows = 0;
        }

        public static void update_Annoyance_List(List<string> newlist)
        {
            displayList = newlist;
        }

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

                level2 = true;
                state_Text.Text = "level2 is coming";
                timer.Start();
            }

            else if (level == 2)
            {
                completed_windows++;
                Console.WriteLine("completed windows = " + completed_windows);
                if (completed_windows == 4)
                {
                    if (total_popups > 0)
                    {
                        for (int i = 0; i < total_popups; i++)
                        {
                            popups[i].Close();
                        }
                        total_popups = 0;
                    }
                    level2 = false;
                    level3 = true;
                    state_Text.Text = "level3 is coming";
                    timer.Start();
                }

            }
        }


        private void initialAnnoyanceWindow_Load(object sender, EventArgs e)
        {
            display.ReadOnly = true;
            foreach (var text in displayList)
            {
                var writeText = "-" + text + "\r\n";
                display.Text = writeText;
            }

            //Timer newtimer = new Timer();
            timer.Interval = (10 * 1000);
            timer.Tick += new EventHandler(newtimer_Tick);
            timer.Start();

            Timer timer2 = new Timer();
            timer2.Interval = (5 * 1000);
            timer2.Tick += new EventHandler(timer2_Tick);
            timer.Start();


        }

        private void newtimer_Tick(object sender, EventArgs e)
        {
            if (level1)
            {
                level1 = false;
                state_Text.Text = "level 1 activated";
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
                level2 = false;
                state_Text.Text = "level 2 activated";
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (var text in displayList)
            {
                var writeText = "-" + text + "\r\n";
                display.Text = writeText;
            }
        }

        private void initialAnnoyanceWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!detection_signals.freetime_check && detection_signals.detected_check)
            {
                this.Hide();
                e.Cancel = true;
            }
            else
            {
                timer.Stop();
                if (total_popups > 0)
                {
                    for (int i = 0; i < total_popups; i++)
                    {
                        popups[i].Close();
                    }
                    total_popups = 0;
                }

                foreach (Form frm in fc)
                {
                    Console.WriteLine("form = " + frm.Name);
                    if (level1)
                    {
                        if (frm.Name == "captchaWindow")
                        {
                            captcha.completed = true;
                            
                            frm.Close();
                        }
                    }
                    else if (level2)
                    {
                        if (frm.Name == "captchaWindow")
                        {

                            captcha_level2_1.completed = true;
                            captcha_level2_2.completed = true;
                            frm.Close();
                        }
                    }

                    else if (frm.Name == "buttonTrial")
                    {
                        frm.Close();
                    }

                   

                }

            }
        }

        private void initialAnnoyanceWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
