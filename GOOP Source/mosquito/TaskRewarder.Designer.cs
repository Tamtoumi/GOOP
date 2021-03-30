namespace mosquito
{
    partial class TaskRewarder
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
            this.components = new System.ComponentModel.Container();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClockFace = new System.Windows.Forms.Label();
            this.hourBox = new System.Windows.Forms.ComboBox();
            this.minuteBox = new System.Windows.Forms.ComboBox();
            this.secondBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 176);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(111, 45);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(225, 176);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(111, 45);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClockFace
            // 
            this.ClockFace.AutoSize = true;
            this.ClockFace.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClockFace.ForeColor = System.Drawing.Color.White;
            this.ClockFace.Location = new System.Drawing.Point(12, 87);
            this.ClockFace.Name = "ClockFace";
            this.ClockFace.Size = new System.Drawing.Size(284, 73);
            this.ClockFace.TabIndex = 2;
            this.ClockFace.Text = "00:00:00";
            // 
            // hourBox
            // 
            this.hourBox.FormattingEnabled = true;
            this.hourBox.Location = new System.Drawing.Point(12, 12);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(104, 21);
            this.hourBox.TabIndex = 3;
            // 
            // minuteBox
            // 
            this.minuteBox.FormattingEnabled = true;
            this.minuteBox.Location = new System.Drawing.Point(122, 12);
            this.minuteBox.Name = "minuteBox";
            this.minuteBox.Size = new System.Drawing.Size(104, 21);
            this.minuteBox.TabIndex = 4;
            // 
            // secondBox
            // 
            this.secondBox.FormattingEnabled = true;
            this.secondBox.Location = new System.Drawing.Point(232, 12);
            this.secondBox.Name = "secondBox";
            this.secondBox.Size = new System.Drawing.Size(104, 21);
            this.secondBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "You have this much earned procrastination time:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(326, 87);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(35, 13);
            this.title.TabIndex = 7;
            this.title.Text = "label2";
            // 
            // TaskRewarder
            // 
            this.ClientSize = new System.Drawing.Size(364, 252);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondBox);
            this.Controls.Add(this.minuteBox);
            this.Controls.Add(this.hourBox);
            this.Controls.Add(this.ClockFace);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "TaskRewarder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskRewarder_FormClosing);
            this.Load += new System.EventHandler(this.TaskRewarder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ClockFace;
        private System.Windows.Forms.ComboBox hourBox;
        private System.Windows.Forms.ComboBox minuteBox;
        private System.Windows.Forms.ComboBox secondBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title;
    }
}