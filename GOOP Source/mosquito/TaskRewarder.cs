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
    public partial class TaskRewarder : Form
    {
        
        Productive parent;
        int rwrdmin = Productive.rTime;
        public int hours;
        public int seconds;
        public int minutes;
        public int Sec =Productive.leftoverSeconds;


        public TaskRewarder(Productive frm)
        {
            InitializeComponent();
            parent = frm;
            GUI.setFormVisuals(this, title);            
            GUI.btnSetUp(Start);
            GUI.btnSetUp(Stop);
        }


        private void TaskRewarder_Load(object sender, EventArgs e)
        {
            this.Stop.Enabled = false;
            //Creating 0-59 range for minutes and seconds
            for (int i = 0; i < 60; i++)
            {
                this.minuteBox.Items.Add(i.ToString());

                this.secondBox.Items.Add(i.ToString());
            }

            //Creating 0-24 range for hours, although this limit will likely not be hit
            for (int j = 0; j < 24; j++)
            {
                this.hourBox.Items.Add(j.ToString());
            }
            //Reformats the integer values if the reward time is an hour or more
            if (rwrdmin > 59)
            {
                hours = rwrdmin / 60;
                minutes = (rwrdmin % 60);
                
            }
            else
            {
                hours = 0;
                minutes = rwrdmin;                
            }

            this.hourBox.SelectedIndex = hours;
            this.minuteBox.SelectedIndex = minutes;
            this.secondBox.SelectedIndex = Sec;



            //Reads the hours, minutes, and seconds from each box entry

            int hr = int.Parse(this.hourBox.SelectedItem.ToString());

            int min = int.Parse(this.minuteBox.SelectedItem.ToString());

            int sec = int.Parse(this.secondBox.SelectedItem.ToString());

            seconds = ((hr * 60) * 60) + (min * 60) + sec;

            this.ClockFace.Text = hr.ToString() + ":" + min.ToString() + ":" + sec.ToString();

            //Hides all the boxes as they are only used to handle the numbers
            //and keep them within range, not show them.
            this.hourBox.Hide();
            this.minuteBox.Hide();
            this.secondBox.Hide();

            
        }
        //Starts the timer and disables the start button
        private void Start_Click(object sender, EventArgs e)
        {
            this.Start.Enabled = false;

            this.Stop.Enabled = true;

            this.timer1.Enabled = true;
        }
        //Stop button stops the timer and reenables the start button
        private void Stop_Click(object sender, EventArgs e)
        {
            this.Start.Enabled = true;
            this.Stop.Enabled = false;

            this.timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (seconds > 0)
            {
                detection_signals.set_freetime(true);
                seconds--;

                int min = seconds / 60;

                int hrs = min / 60;

                int sec = seconds - (min * 60);

                //This series of if statements is to deal with the string format for when the integer values goes below double digits
                this.ClockFace.Text = hrs.ToString() + ":" + min.ToString() + ":" + sec.ToString();

                if (hrs == 0)
                {
                    this.ClockFace.Text = min.ToString() + ":" + sec.ToString();
                }

                if (min >= 60)
                {
                    this.ClockFace.Text = hrs.ToString() + ":" + (min % 60).ToString() + ":" + sec.ToString();
                }

                if (hrs > 0 && (min%60) < 10)
                {
                    this.ClockFace.Text = hrs.ToString() + ":0" + (min % 60).ToString() + ":" + sec.ToString();
                }
                if ((min%60) < 10 && sec < 10)
                {
                    this.ClockFace.Text = hrs.ToString() + ":0" + (min % 60).ToString() + ":0" + sec.ToString();
                }

                if (hrs > 0 && min > 0 && sec < 10)
                {
                    this.ClockFace.Text = hrs.ToString() + ":" + (min % 60).ToString() + ":0" + sec.ToString();
                }

                if (hrs == 0 && min == 0)
                {
                    this.ClockFace.Text = ":" + sec.ToString();
                }
                

                if (hrs == 0 && min == 0 && sec < 10)
                {
                    this.ClockFace.Text = ":0" + sec.ToString();
                }

                //Updates the combobox to be read again with the new remaining time
                if (hrs > 0)
                {
                    this.hourBox.SelectedIndex = hrs;
                    this.minuteBox.SelectedIndex = (min % 60);
                    this.secondBox.SelectedIndex = sec;
                }
                else
                {
                    this.hourBox.SelectedIndex = hrs;

                    this.minuteBox.SelectedIndex = min;

                    this.secondBox.SelectedIndex = sec;
                }
            }
            //Let's the user know the reward time is up, reactivates the preventer.
            else
            {
                this.timer1.Stop();

                MessageBox.Show("You have run out of time. Get back to work!");
                this.Close();
            }
        }

        private void TaskRewarder_FormClosing(object sender, FormClosingEventArgs e)
        {
            detection_signals.set_freetime(false);
            //This updates the time kept in the productive class to keep the remaining time
            Productive.rTime = seconds / 60;
            Productive.leftoverSeconds = (seconds % 60);
            

            parent.Show();
        }

        
    }
}

