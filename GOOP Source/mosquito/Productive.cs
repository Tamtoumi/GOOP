﻿using System;
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
    public partial class Productive : Form
    {
        TaskViewer newForm = new TaskViewer();
        //TaskRewarder newForm2 = new TaskRewarder();
        Form1 forma = new Form1();
        initialAnnoyanceWindow aw;

        bool open = false;
        Timer timer1;
        Timer timer2;


        public Productive()
        {
            InitializeComponent();
            GUI.setFormVisuals(this, title);
            GUI.labelSetUp(lblCompletedTask);
            GUI.labelSetUp(lblTasks);
            GUI.labelSetUp(lblRewardTime);
            GUI.labelSetUp(lblTimeRewarded);
            GUI.btnSetUp(btnComplete);
            GUI.btnSetUp(btnUseTime);
            GUI.btnSetUp(btnStop);
            GUI.btnSetUp(btnEdit);
            GUI.txtSetUp(txtCompletedTask);
            GUI.rtxtSetUp(rtxtTaskList);
            rtxtTaskList.ReadOnly = true;
            //rtxtTaskList.Cursor = System.Windows.Forms.Cursors.Default;
            txtCompletedTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            btnStop.ForeColor = System.Drawing.Color.Red;
            btnComplete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStop.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            showTextBoxRich();
        }

        public Productive(TaskViewer formTV)
        {
            InitializeComponent();
            newForm = formTV;
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (AppMan.eraseFromSavedUserAssignments(txtCompletedTask.Text))
            {
                rtxtTaskList.ResetText();
                showTextBoxRich();
            }
            TaskViewer.cleanBoard();
            AppMan.cleanSUA2();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            TaskViewer.cleanBoard();
            newForm.Show();
            this.Close();
            //forma.Show();
        }

        private void showTextBoxRich()
        {
              //this will show every task in the gui
              string[] SavedUserAssignments = AppMan.readSavedUserAssignments();
              string[] dist = SavedUserAssignments.Distinct().ToArray();
              foreach (string usertask in dist)
              {
                 txtCompletedTask.Text = usertask;
                 GUI.TaskDisplay(txtCompletedTask, rtxtTaskList);
              }
              txtCompletedTask.Text = "";
        }

        private void Productive_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = (5 * 1000);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            timer2 = new Timer();
            timer2.Interval = (1 * 1000);
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Start();


            this.lblTimeRewarded.Text = "00:00:00";

            //rtxtTaskList.Text = 
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            AppDetector.appDetectorUpdater();
            if (!(detection_signals.freetime_check) && detection_signals.detected_check)
            {
                if (!open)
                {
                    aw = new initialAnnoyanceWindow();
                    aw.Show();
                    open = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (detection_signals.freetime_check || !(detection_signals.detected_check))
            {
                if (open)
                {
                    aw.Close();
                    open = false;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Close();

        }

        private void Productive_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void btnUseTime_Click(object sender, EventArgs e)
        {
            //newForm2.Show();
            this.Close();
        }
    }
}
