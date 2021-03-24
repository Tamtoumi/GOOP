
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
            this.title.Location = new System.Drawing.Point(247, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(46, 17);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Location = new System.Drawing.Point(48, 144);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(50, 17);
            this.lblTasks.TabIndex = 1;
            this.lblTasks.Text = "Tasks:";
            // 
            // rtxtTaskList
            // 
            this.rtxtTaskList.Location = new System.Drawing.Point(51, 199);
            this.rtxtTaskList.Name = "rtxtTaskList";
            this.rtxtTaskList.Size = new System.Drawing.Size(395, 262);
            this.rtxtTaskList.TabIndex = 2;
            this.rtxtTaskList.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(51, 477);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(395, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(466, 537);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(126, 54);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblCompletedTask
            // 
            this.lblCompletedTask.AutoSize = true;
            this.lblCompletedTask.Location = new System.Drawing.Point(48, 50);
            this.lblCompletedTask.Name = "lblCompletedTask";
            this.lblCompletedTask.Size = new System.Drawing.Size(152, 17);
            this.lblCompletedTask.TabIndex = 5;
            this.lblCompletedTask.Text = "Enter Completed Task:";
            // 
            // txtCompletedTask
            // 
            this.txtCompletedTask.Location = new System.Drawing.Point(89, 91);
            this.txtCompletedTask.Name = "txtCompletedTask";
            this.txtCompletedTask.Size = new System.Drawing.Size(268, 22);
            this.txtCompletedTask.TabIndex = 6;
            // 
            // lblRewardTime
            // 
            this.lblRewardTime.AutoSize = true;
            this.lblRewardTime.Location = new System.Drawing.Point(36, 555);
            this.lblRewardTime.Name = "lblRewardTime";
            this.lblRewardTime.Size = new System.Drawing.Size(99, 17);
            this.lblRewardTime.TabIndex = 7;
            this.lblRewardTime.Text = "Reward Time: ";
            // 
            // lblTimeRewarded
            // 
            this.lblTimeRewarded.AutoSize = true;
            this.lblTimeRewarded.Location = new System.Drawing.Point(189, 555);
            this.lblTimeRewarded.Name = "lblTimeRewarded";
            this.lblTimeRewarded.Size = new System.Drawing.Size(46, 17);
            this.lblTimeRewarded.TabIndex = 8;
            this.lblTimeRewarded.Text = "label2";
            // 
            // btnUseTime
            // 
            this.btnUseTime.Location = new System.Drawing.Point(290, 537);
            this.btnUseTime.Name = "btnUseTime";
            this.btnUseTime.Size = new System.Drawing.Size(156, 53);
            this.btnUseTime.TabIndex = 9;
            this.btnUseTime.Text = "Use Reward Time";
            this.btnUseTime.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(386, 81);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(135, 43);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "Completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(403, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 42);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit Tasks";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Productive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 620);
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
            this.Name = "Productive";
            this.Text = "Productive";
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