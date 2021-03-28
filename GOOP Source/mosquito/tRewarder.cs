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
    public partial class tRewarder : Form
    {
        int rwrdmin = Productive.rTime.ToString();
        public string rewardTime;

        public int Rwrdmin { get => rwrdmin; set => rwrdmin = value; }



        //static int minutes = 5;
        //static int seconds = minutes * 60;

        public tRewarder()
        {
            InitializeComponent();
        }


        private void tRewarder_Load(object sender, EventArgs e)
        {
            //Creating 0-59 range for minutes and seconds
            for (int i = 0; i < 60; i++)
            {
                this.minuteBox.Items.Add(i.ToString());

                this.secondBox.Items.Add(i.ToString());
            }
            this.minuteBox.SelectedIndex = 4;

            this.secondBox.SelectedIndex = 59;
            //Creating 0-24 range for hours, although this limit will likely not be hit
            for (int j = 0; j < 24; j++)
            {
                this.hourBox.Items.Add(j.ToString());
            }
            this.hourBox.SelectedIndex = 0;

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

            rewardTime = this.ClockFace.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Start.Enabled = false;

            this.Stop.Enabled = true;

            this.timer1.Enabled = true;
        }

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
                seconds--;

                int min = seconds / 60;

                int hrs = min / 60;

                int sec = seconds - (min * 60);


                this.ClockFace.Text = hrs.ToString() + ":" + min.ToString() + ":" + sec.ToString();

                if (hrs == 0)
                {
                    this.ClockFace.Text = min.ToString() + ":" + sec.ToString();
                }

                if (hrs > 0 && min < 10)
                {
                    this.ClockFace.Text = hrs.ToString() + ":0" + min.ToString() + ":" + sec.ToString();
                }

                if (hrs == 0 && min == 0)
                {
                    this.ClockFace.Text = ":" + sec.ToString();
                }

                if (hrs > 0 && min > 0 && sec < 10)
                {
                    this.ClockFace.Text = hrs.ToString() + ":" + min.ToString() + ":0" + sec.ToString();
                }

                if (hrs == 0 && min == 0 && sec < 10)
                {
                    this.ClockFace.Text = ":0" + sec.ToString();
                }

                //Updates the combobox to be read again with the new remaining time
                this.hourBox.SelectedIndex = hrs;

                this.minuteBox.SelectedIndex = min;

                this.secondBox.SelectedIndex = sec;
            }
            //Let's the user know the reward time is up, reactivates the preventer.
            else
            {
                this.timer1.Stop();
                MessageBox.Show("You have run out of time. Get back to work!");
            }
        }

        private void TaskRewarder_Load_1(object sender, EventArgs e)
        {

        }
    }
}

