
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
            this.title = new System.Windows.Forms.Label();
            this.lblInputBadApp = new System.Windows.Forms.Label();
            this.lblBadAppList = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblInstalledApps = new System.Windows.Forms.Label();
            this.btnTaskViewer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BadAppNumIn
            // 
            this.BadAppNumIn.Location = new System.Drawing.Point(371, 85);
            this.BadAppNumIn.Margin = new System.Windows.Forms.Padding(4);
            this.BadAppNumIn.Name = "BadAppNumIn";
            this.BadAppNumIn.Size = new System.Drawing.Size(105, 54);
            this.BadAppNumIn.TabIndex = 0;
            this.BadAppNumIn.Text = "Enter";
            this.BadAppNumIn.UseVisualStyleBackColor = true;
            this.BadAppNumIn.Click += new System.EventHandler(this.BadAppNumIn_Click);
            // 
            // DelBadAppNum
            // 
            this.DelBadAppNum.Location = new System.Drawing.Point(371, 488);
            this.DelBadAppNum.Margin = new System.Windows.Forms.Padding(4);
            this.DelBadAppNum.Name = "DelBadAppNum";
            this.DelBadAppNum.Size = new System.Drawing.Size(105, 56);
            this.DelBadAppNum.TabIndex = 1;
            this.DelBadAppNum.Text = "Delete";
            this.DelBadAppNum.UseVisualStyleBackColor = true;
            this.DelBadAppNum.Click += new System.EventHandler(this.DelBadAppNum_Click);
            // 
            // InstalledAppList
            // 
            this.InstalledAppList.Location = new System.Drawing.Point(527, 101);
            this.InstalledAppList.Margin = new System.Windows.Forms.Padding(4);
            this.InstalledAppList.Name = "InstalledAppList";
            this.InstalledAppList.Size = new System.Drawing.Size(483, 524);
            this.InstalledAppList.TabIndex = 2;
            this.InstalledAppList.Text = "";
            this.InstalledAppList.TextChanged += new System.EventHandler(this.InstalledAppList_TextChanged);
            // 
            // ShowBadAppList
            // 
            this.ShowBadAppList.Location = new System.Drawing.Point(92, 237);
            this.ShowBadAppList.Margin = new System.Windows.Forms.Padding(4);
            this.ShowBadAppList.Name = "ShowBadAppList";
            this.ShowBadAppList.Size = new System.Drawing.Size(379, 168);
            this.ShowBadAppList.TabIndex = 3;
            this.ShowBadAppList.Text = "";
            this.ShowBadAppList.TextChanged += new System.EventHandler(this.ShowBadAppList_TextChanged);
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(92, 101);
            this.UserInput.Margin = new System.Windows.Forms.Padding(4);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(221, 22);
            this.UserInput.TabIndex = 4;
            this.UserInput.TextChanged += new System.EventHandler(this.UserInput_TextChanged);
            // 
            // UserDel
            // 
            this.UserDel.Location = new System.Drawing.Point(92, 505);
            this.UserDel.Margin = new System.Windows.Forms.Padding(4);
            this.UserDel.Name = "UserDel";
            this.UserDel.Size = new System.Drawing.Size(221, 22);
            this.UserDel.TabIndex = 5;
            this.UserDel.TextChanged += new System.EventHandler(this.UserDel_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(480, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(46, 17);
            this.title.TabIndex = 6;
            this.title.Text = "label1";
            // 
            // lblInputBadApp
            // 
            this.lblInputBadApp.AutoSize = true;
            this.lblInputBadApp.Location = new System.Drawing.Point(41, 58);
            this.lblInputBadApp.Name = "lblInputBadApp";
            this.lblInputBadApp.Size = new System.Drawing.Size(199, 17);
            this.lblInputBadApp.TabIndex = 7;
            this.lblInputBadApp.Text = "Input Bad Application Number:";
            // 
            // lblBadAppList
            // 
            this.lblBadAppList.AutoSize = true;
            this.lblBadAppList.Location = new System.Drawing.Point(44, 188);
            this.lblBadAppList.Name = "lblBadAppList";
            this.lblBadAppList.Size = new System.Drawing.Size(136, 17);
            this.lblBadAppList.TabIndex = 8;
            this.lblBadAppList.Text = "Bad Application List:";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(47, 450);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(223, 17);
            this.lblDelete.TabIndex = 9;
            this.lblDelete.Text = "Enter Number to Delete From List:";
            // 
            // lblInstalledApps
            // 
            this.lblInstalledApps.AutoSize = true;
            this.lblInstalledApps.Location = new System.Drawing.Point(524, 58);
            this.lblInstalledApps.Name = "lblInstalledApps";
            this.lblInstalledApps.Size = new System.Drawing.Size(186, 17);
            this.lblInstalledApps.TabIndex = 10;
            this.lblInstalledApps.Text = "List of Installed Applications:";
            // 
            // btnTaskViewer
            // 
            this.btnTaskViewer.Location = new System.Drawing.Point(36, 562);
            this.btnTaskViewer.Name = "btnTaskViewer";
            this.btnTaskViewer.Size = new System.Drawing.Size(144, 63);
            this.btnTaskViewer.TabIndex = 11;
            this.btnTaskViewer.Text = "Task Viewer";
            this.btnTaskViewer.UseVisualStyleBackColor = true;
            this.btnTaskViewer.Click += new System.EventHandler(this.btnTaskViewer_Click);
            // 
            // ApplicationManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1031, 652);
            this.Controls.Add(this.btnTaskViewer);
            this.Controls.Add(this.lblInstalledApps);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblBadAppList);
            this.Controls.Add(this.lblInputBadApp);
            this.Controls.Add(this.title);
            this.Controls.Add(this.UserDel);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.ShowBadAppList);
            this.Controls.Add(this.InstalledAppList);
            this.Controls.Add(this.DelBadAppNum);
            this.Controls.Add(this.BadAppNumIn);
            this.Margin = new System.Windows.Forms.Padding(4);
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
            /*
            exeList = AppMan.Drivers();
            int i = 0;


            // condensed into its own function
            //string[] executables1 = Test.TraverseTree(@"C:\Program Files");
            //foreach (string element in executables1)
            //{
            //    listofApp.Text += i + ":   " + element + "\n";
            //    i++;
            //}
            //string[] executables2 = Test.TraverseTree(@"C:\Program Files (x86)");
            //foreach (string element in executables2)
            //{
            //    listofApp.Text += i + ":   " + element + "\n";
            //    i++;
            //}
            //string[] combine = Test.StrCombine(executables1, executables2);


            //foreach (string element in combine)
            foreach (string element in exeList)
            {
                //Console.WriteLine(i + ":   " + element);
                InstalledAppList.Text += i + ":   " + element + "\n";
                i++;
            }
            /*
            string[] list = AppMan.BadAppString();
            ShowBadAppList.Text = "";
            for (int j = 0; j < list.Length; j++)
            {
                //Console.WriteLine(list[i]);
                ShowBadAppList.Text += list[j] + "\n";
            }*/
            AppMan.UpdateTextBox(InstalledAppList, AppMan.InstalledAppString());
            AppMan.UpdateTextBox(ShowBadAppList, AppMan.BadAppString());
        }

        private System.Windows.Forms.TextBox UserDel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblInputBadApp;
        private System.Windows.Forms.Label lblBadAppList;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblInstalledApps;
        private System.Windows.Forms.Button btnTaskViewer;
    }
}