
namespace mosquito
{
    partial class Form1
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
            this.btnAppMan = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.btnTaskView = new System.Windows.Forms.Button();
            this.btnFirstTimeSetUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAppMan
            // 
            this.btnAppMan.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppMan.Location = new System.Drawing.Point(110, 149);
            this.btnAppMan.Name = "btnAppMan";
            this.btnAppMan.Size = new System.Drawing.Size(200, 86);
            this.btnAppMan.TabIndex = 0;
            this.btnAppMan.Text = "Application Manager";
            this.btnAppMan.UseVisualStyleBackColor = true;
            this.btnAppMan.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(182, 7);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(35, 13);
            this.title.TabIndex = 1;
            this.title.Text = "label1";
            // 
            // btnTaskView
            // 
            this.btnTaskView.Location = new System.Drawing.Point(110, 258);
            this.btnTaskView.Margin = new System.Windows.Forms.Padding(2);
            this.btnTaskView.Name = "btnTaskView";
            this.btnTaskView.Size = new System.Drawing.Size(200, 86);
            this.btnTaskView.TabIndex = 2;
            this.btnTaskView.Text = "Task Viewer";
            this.btnTaskView.UseVisualStyleBackColor = true;
            this.btnTaskView.Click += new System.EventHandler(this.btnTaskView_Click);
            // 
            // btnFirstTimeSetUp
            // 
            this.btnFirstTimeSetUp.Location = new System.Drawing.Point(110, 46);
            this.btnFirstTimeSetUp.Name = "btnFirstTimeSetUp";
            this.btnFirstTimeSetUp.Size = new System.Drawing.Size(200, 86);
            this.btnFirstTimeSetUp.TabIndex = 3;
            this.btnFirstTimeSetUp.Text = "First Time Set Up";
            this.btnFirstTimeSetUp.UseVisualStyleBackColor = true;
            this.btnFirstTimeSetUp.Click += new System.EventHandler(this.btnFirstTimeSetUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 355);
            this.Controls.Add(this.btnFirstTimeSetUp);
            this.Controls.Add(this.btnAppMan);
            this.Controls.Add(this.btnTaskView);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAppMan;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnTaskView;
        private System.Windows.Forms.Button btnFirstTimeSetUp;
    }
}

