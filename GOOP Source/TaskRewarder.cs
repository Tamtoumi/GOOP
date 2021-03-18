using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskRewarder//change later
{
    public partial class TaskRewarder : Form
    {
        private static int minutes = 15;
        private int seconds = minutes * 60;
        public TaskRewarder()
        {
            InitializeComponent();
        }
        private void TaskRewarder_Load(object sender, EventArgs e)
        {
            Start.Visible = true;
            Stop.Visible = true;
            label1.Visible = true;
            label2.Show();            
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                
                int hrs = minutes / 60;
                int sec = seconds - (minutes * 60);//leftover seconds, different from total seconds
                this.label2.Text = hrs.ToString() + ":" + minutes.ToString() + ":" + sec.ToString();
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("You have run out of time. Get back to work!");
            }
        }

        
    }

//public int rewardTime() = > ProgressTracker.getMinutes();Accesses the getMinutes method in the tracker. The method will need to return a set double.

}