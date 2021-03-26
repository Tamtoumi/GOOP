
namespace mosquito
{
    partial class initialAnnoyanceWindow
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
            this.display = new System.Windows.Forms.RichTextBox();
            this.newtimer = new System.Windows.Forms.Timer(this.components);
            this.state_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(159, 74);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(333, 364);
            this.display.TabIndex = 0;
            this.display.Text = "";
            // 
            // newtimer
            // 
            this.newtimer.Tick += new System.EventHandler(this.newtimer_Tick);
            // 
            // state_Text
            // 
            this.state_Text.Location = new System.Drawing.Point(28, 114);
            this.state_Text.Name = "state_Text";
            this.state_Text.Size = new System.Drawing.Size(100, 22);
            this.state_Text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // initialAnnoyanceWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.state_Text);
            this.Controls.Add(this.display);
            this.Name = "initialAnnoyanceWindow";
            this.Text = "Application Detected";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.initialAnnoyanceWindow_FormClosing);
            this.Load += new System.EventHandler(this.initialAnnoyanceWindow_Load);
            this.SizeChanged += new System.EventHandler(this.initialAnnoyanceWindow_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox display;
        private System.Windows.Forms.Timer newtimer;
        private System.Windows.Forms.TextBox state_Text;
        private System.Windows.Forms.Label label1;
    }
}