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
    public partial class ApplicationManager : Form
    {
        public ApplicationManager()
        {
            InitializeComponent();
        }

        private void BadAppNumIn_Click(object sender, EventArgs e)
        {
            int num = -1;
            if (String.IsNullOrWhiteSpace(UserInput.Text))
            {
                return;
            }
            else if (!int.TryParse(UserInput.Text, out num))
            {
                return;
            }
            string apps = exeList[Int32.Parse(UserInput.Text)];
            
            //Console.WriteLine(apps);
            AppMan.UpdateFile(apps);
            UserInput.Text = "";
        }

        private void DelBadAppNum_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserDel.Text))
            {
                return;
            }
            AppMan.DeleteBadApp(UserDel.Text);
            UserDel.Text = "";
        }

        private void UserInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void InstalledAppList_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowBadAppList_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserDel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
