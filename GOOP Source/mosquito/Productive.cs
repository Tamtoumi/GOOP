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
    public partial class Productive : Form
    {
        public static int rTime = 0;
        public static int leftoverSeconds = 0;
        public string rewardTime = rTime.ToString() + " minutes";
        TaskViewer newForm = new TaskViewer();
        //TaskRewarder newForm2 = new TaskRewarder();
        Form1 forma = new Form1();
        initialAnnoyanceWindow aw;

        bool open = false;
        Timer timer1;
        Timer timer2;

        FormCollection fc = new FormCollection();

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

        // @brief deletes from SUA, updates text box accordingly if needed, cleans SUA, gives credit to user.
        // @param activates on enter of create button
        // @return Void
        public void btnComplete_Click(object sender, EventArgs e)
        {
            if (ProgressTracker.eraseFromSavedUserAssignments(txtCompletedTask.Text))
            {
                rtxtTaskList.ResetText();
                showTextBoxRich();
                rTime += 5;
            }
            ProgressTracker.cleanSUA2();
            
            rewardTime = rTime.ToString() + " minutes";
            this.lblTimeRewarded.Text = rewardTime;
        }


        // @brief returns to taskViewer and closes this window
        // @param activates on enter of stop button
        // @return Void

        private void btnStop_Click(object sender, EventArgs e)
        {
            newForm.Show();
            if (open)
            {
                aw.disable = true;
                aw.Close();
            }
            this.Close();
            //forma.Show();
        }

        // @brief shows tasks from the SUA to textbox, often used to redisplay text on updates to list.
        // @return Void

        private void showTextBoxRich()
        {
            //this will show every task in the gui
            string[] SavedUserAssignments = ProgressTracker.readSavedUserAssignments();
            string[] dist = SavedUserAssignments.Distinct().ToArray();
            foreach (string usertask in dist)
            {
                txtCompletedTask.Text = usertask;
                GUI.TaskDisplay(txtCompletedTask, rtxtTaskList);
            }
            txtCompletedTask.Text = "";
        }

        // @brief 
        // @param activates on load of this class
        // @return Void
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

            ProgressTracker.makeSavedUserAssignments();
            this.lblTimeRewarded.Text = rTime.ToString() + " minutes";
            
            
            //rtxtTaskList.Text = 
        }

        // @brief 
        // @param 
        // @return Void
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

        // @brief 
        // @param 
        // @return Void
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

        // @brief exits this window and enters TaskViewer
        // @param activates on click of edit button
        // @return Void
        private void btnEdit_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Close();

        }

        // @brief 
        // @param activates on closing of form
        // @return Void
        private void Productive_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        // @brief 
        // @param activates on click of useTime button
        // @return Void
        private void btnUseTime_Click(object sender, EventArgs e)
        {
            //newForm2.Show();
            TaskRewarder newForms = new TaskRewarder(this);
            newForms.Show();
            this.Hide();
        }

        private void lblTimeRewarded_Click(object sender, EventArgs e)
        {

        }
    }
}