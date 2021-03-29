
namespace mosquito
{
    partial class Productive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.lblTasks = new System.Windows.Forms.Label();
            this.rtxtTaskList = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblCompletedTask = new System.Windows.Forms.Label();
            this.txtCompletedTask = new System.Windows.Forms.TextBox();
            this.lblRewardTime = new System.Windows.Forms.Label();
            this.lblTimeRewarded = new System.Windows.Forms.Label();
            this.btnUseTime = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(185, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(35, 13);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(36, 117);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(39, 13);
            this.lblTasks.TabIndex = 1;
            this.lblTasks.Text = "Tasks:";
            // 
            // rtxtTaskList
            // 
            this.rtxtTaskList.Location = new System.Drawing.Point(38, 162);
            this.rtxtTaskList.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtTaskList.Name = "rtxtTaskList";
            this.rtxtTaskList.Size = new System.Drawing.Size(297, 214);
            this.rtxtTaskList.TabIndex = 2;
            this.rtxtTaskList.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(38, 388);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(296, 19);
            this.progressBar1.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(350, 436);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 44);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCompletedTask
            // 
            this.lblCompletedTask.AutoSize = true;
            this.lblCompletedTask.Location = new System.Drawing.Point(36, 41);
            this.lblCompletedTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompletedTask.Name = "lblCompletedTask";
            this.lblCompletedTask.Size = new System.Drawing.Size(115, 13);
            this.lblCompletedTask.TabIndex = 5;
            this.lblCompletedTask.Text = "Enter Completed Task:";
            // 
            // txtCompletedTask
            // 
            this.txtCompletedTask.Location = new System.Drawing.Point(67, 74);
            this.txtCompletedTask.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompletedTask.Name = "txtCompletedTask";
            this.txtCompletedTask.Size = new System.Drawing.Size(202, 20);
            this.txtCompletedTask.TabIndex = 6;
            // 
            // lblRewardTime
            // 
            this.lblRewardTime.AutoSize = true;
            this.lblRewardTime.Location = new System.Drawing.Point(11, 451);
            this.lblRewardTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRewardTime.Name = "lblRewardTime";
            this.lblRewardTime.Size = new System.Drawing.Size(76, 13);
            this.lblRewardTime.TabIndex = 7;
            this.lblRewardTime.Text = "Reward Time: ";
            // 
            // lblTimeRewarded
            // 
            this.lblTimeRewarded.AutoSize = true;
            this.lblTimeRewarded.Location = new System.Drawing.Point(116, 451);
            this.lblTimeRewarded.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeRewarded.Name = "lblTimeRewarded";
            this.lblTimeRewarded.Size = new System.Drawing.Size(35, 13);
            this.lblTimeRewarded.TabIndex = 8;
            this.lblTimeRewarded.Text = "label2";
            this.lblTimeRewarded.Click += new System.EventHandler(this.lblTimeRewarded_Click);
            // 
            // btnUseTime
            // 
            this.btnUseTime.Location = new System.Drawing.Point(218, 436);
            this.btnUseTime.Margin = new System.Windows.Forms.Padding(2);
            this.btnUseTime.Name = "btnUseTime";
            this.btnUseTime.Size = new System.Drawing.Size(117, 43);
            this.btnUseTime.TabIndex = 9;
            this.btnUseTime.Text = "Use Reward Time";
            this.btnUseTime.UseVisualStyleBackColor = true;
            this.btnUseTime.Click += new System.EventHandler(this.btnUseTime_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(290, 66);
            this.btnComplete.Margin = new System.Windows.Forms.Padding(2);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(101, 35);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "Completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(302, 117);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 34);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Tasks";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Productive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 504);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnUseTime);
            this.Controls.Add(this.lblTimeRewarded);
            this.Controls.Add(this.lblRewardTime);
            this.Controls.Add(this.txtCompletedTask);
            this.Controls.Add(this.lblCompletedTask);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.rtxtTaskList);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Productive";
            this.Text = "Productive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Productive_FormClosing);
            this.Load += new System.EventHandler(this.Productive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.RichTextBox rtxtTaskList;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblCompletedTask;
        private System.Windows.Forms.TextBox txtCompletedTask;
        private System.Windows.Forms.Label lblRewardTime;
        private System.Windows.Forms.Label lblTimeRewarded;
        private System.Windows.Forms.Button btnUseTime;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnEdit;
    }
}