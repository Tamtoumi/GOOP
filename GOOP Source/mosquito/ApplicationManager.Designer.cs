
namespace mosquito
{
    partial class ApplicationManager
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
            this.BadAppNumIn = new System.Windows.Forms.Button();
            this.DelBadAppNum = new System.Windows.Forms.Button();
            this.InstalledAppList = new System.Windows.Forms.RichTextBox();
            this.ShowBadAppList = new System.Windows.Forms.RichTextBox();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.UserDel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BadAppNumIn
            // 
            this.BadAppNumIn.Location = new System.Drawing.Point(33, 43);
            this.BadAppNumIn.Name = "BadAppNumIn";
            this.BadAppNumIn.Size = new System.Drawing.Size(195, 100);
            this.BadAppNumIn.TabIndex = 0;
            this.BadAppNumIn.Text = "Input Bad Application Number";
            this.BadAppNumIn.UseVisualStyleBackColor = true;
            this.BadAppNumIn.Click += new System.EventHandler(this.BadAppNumIn_Click);
            // 
            // DelBadAppNum
            // 
            this.DelBadAppNum.Location = new System.Drawing.Point(33, 173);
            this.DelBadAppNum.Name = "DelBadAppNum";
            this.DelBadAppNum.Size = new System.Drawing.Size(195, 103);
            this.DelBadAppNum.TabIndex = 1;
            this.DelBadAppNum.Text = "Delete Bad Application Number From List\r\n";
            this.DelBadAppNum.UseVisualStyleBackColor = true;
            this.DelBadAppNum.Click += new System.EventHandler(this.DelBadAppNum_Click);
            // 
            // InstalledAppList
            // 
            this.InstalledAppList.Location = new System.Drawing.Point(466, 43);
            this.InstalledAppList.Name = "InstalledAppList";
            this.InstalledAppList.Size = new System.Drawing.Size(246, 477);
            this.InstalledAppList.TabIndex = 2;
            this.InstalledAppList.Text = "";
            this.InstalledAppList.TextChanged += new System.EventHandler(this.InstalledAppList_TextChanged);
            // 
            // ShowBadAppList
            // 
            this.ShowBadAppList.Location = new System.Drawing.Point(33, 301);
            this.ShowBadAppList.Name = "ShowBadAppList";
            this.ShowBadAppList.Size = new System.Drawing.Size(285, 137);
            this.ShowBadAppList.TabIndex = 3;
            this.ShowBadAppList.Text = "";
            this.ShowBadAppList.TextChanged += new System.EventHandler(this.ShowBadAppList_TextChanged);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(282, 84);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(157, 20);
            this.UserInput.TabIndex = 4;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // UserDel
            // 
            this.UserDel.Location = new System.Drawing.Point(268, 208);
            this.UserDel.Name = "UserDel";
            this.UserDel.Size = new System.Drawing.Size(167, 20);
            this.UserDel.TabIndex = 5;
            this.UserDel.TextChanged += new System.EventHandler(this.UserDel_TextChanged);
            // 
            // ApplicationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(773, 530);
            this.Controls.Add(this.UserDel);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.ShowBadAppList);
            this.Controls.Add(this.InstalledAppList);
            this.Controls.Add(this.DelBadAppNum);
            this.Controls.Add(this.BadAppNumIn);
            this.Name = "ApplicationManager";
            this.Text = "ApplicationManager";
            this.Load += new System.EventHandler(this.ApplicationManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BadAppNumIn;
        private System.Windows.Forms.Button DelBadAppNum;
        private System.Windows.Forms.RichTextBox InstalledAppList;
        private System.Windows.Forms.RichTextBox ShowBadAppList;
        private System.Windows.Forms.TextBox UserInput;

        string[] exeList;
        private void ApplicationManager_Load(object sender, System.EventArgs e)
        {
            exeList = AppMan.Drivers();
            int i = 0;
            /*
            string[] executables1 = Test.TraverseTree(@"C:\Program Files");
            foreach (string element in executables1)
            {
                listofApp.Text += i + ":   " + element + "\n";
                i++;
            }
            string[] executables2 = Test.TraverseTree(@"C:\Program Files (x86)");
            foreach (string element in executables2)
            {
                listofApp.Text += i + ":   " + element + "\n";
                i++;
            }
            string[] combine = Test.StrCombine(executables1, executables2);*/
            //foreach (string element in combine)
            foreach (string element in exeList)
            {
                //Console.WriteLine(i + ":   " + element);
                InstalledAppList.Text += i + ":   " + element + "\n";
                i++;
            }
            string[] list = AppMan.BadAppString();
            ShowBadAppList.Text = "";
            for (int j = 0; j < list.Length; j++)
            {
                //Console.WriteLine(list[i]);
                ShowBadAppList.Text += list[j] + "\n";
            }
            
        }

        private System.Windows.Forms.TextBox UserDel;
    }
}