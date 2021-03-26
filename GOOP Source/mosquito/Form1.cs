using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace mosquito
{
    public partial class Form1 : Form
    {
        int chosen = 0;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            GUI.setFormVisuals(this, title);
            GUI.btnSetUp(btnAppMan);
            GUI.btnSetUp(btnTaskView);
            GUI.btnSetUp(btnFirstTimeSetUp);

            // sets the form to a fixed size 
            this.MinimumSize = new Size(425, 400);
            this.MaximumSize = new Size(425, 400);
            this.Text = "Start Up";
            // changes the default font size 
            btnAppMan.Font = new System.Drawing.Font("Nirmala UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTaskView.Font = new System.Drawing.Font("Nirmala UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFirstTimeSetUp.Font = new System.Drawing.Font("Nirmala UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        // @brief Open Application Manager Form
        //        Takes a couple of seconds/minute to retrieve Installed Application List and Bad Application List
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...Give it a second. ", "Loading");
            ApplicationManager myForm = new ApplicationManager();
            myForm.ShowDialog();
            this.Hide();
            //this.Close();

        }

        private void btnTaskView_Click(object sender, EventArgs e)
        {
            
            TaskViewer newForm = new TaskViewer();
            newForm.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (chosen == 1)
            //{
            //    MessageBox.Show("Loading...Give it a second. ", "Loading");
            //    ApplicationManager myForm = new ApplicationManager();
            //    myForm.ShowDialog();
            //}
            //else if (chosen == 2)
            //{
            //    TaskViewer newForm = new TaskViewer();
            //    newForm.Show();
            //}
        }

        // @brief First Time Set Up Button on Form
        //        Run AppMan.Drivers() which will gather all installed .exe files into a file
        //        Takes a couple of seconds/minute to update/retrieve Installed Application List and Bad Application List
        //        Open the Application Manager Form
        private void btnFirstTimeSetUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Loading...Give it a second. ", "Loading");
            AppMan.Drivers();
            ApplicationManager myForm = new ApplicationManager();
            myForm.ShowDialog();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public static class Globals
    {
        public static String path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    }


    
}
