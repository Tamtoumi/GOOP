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
    public partial class ApplicationManager : Form
    {
        public ApplicationManager()
        {
            InitializeComponent();
            GUI.setFormVisuals(this, title);
            GUI.btnSetUp(BadAppNumIn);
            GUI.btnSetUp(DelBadAppNum);
            GUI.btnSetUp(btnTaskViewer);
            GUI.txtSetUp(UserInput);
            GUI.txtSetUp(UserDel);
            GUI.rtxtSetUp(ShowBadAppList);
            GUI.rtxtSetUp(InstalledAppList);
            GUI.labelSetUp(lblBadAppList);
            GUI.labelSetUp(lblDelete);
            GUI.labelSetUp(lblInputBadApp);
            GUI.labelSetUp(lblInstalledApps);
            btnTaskViewer.ForeColor = System.Drawing.Color.MediumSeaGreen;
            btnTaskViewer.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            else if (Int32.Parse(UserInput.Text) >= AppMan.InstalledAppString().Length)
            {
                //here insert new form of out of bounds error
                Console.WriteLine("The number you inputted is not in the list");
                return;
            }
            else
            {
                exeList = AppMan.InstalledAppString();
                string apps = exeList[Int32.Parse(UserInput.Text)];

                //Console.WriteLine(apps);
                AppMan.UpdateFile(apps, "\\BadApps.txt");
                UserInput.Text = "";
                AppMan.UpdateTextBox(ShowBadAppList, AppMan.BadAppString());
            }
        }

        private void DelBadAppNum_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UserDel.Text))
            {
                return;
            }
            AppMan.DeleteBadApp(UserDel.Text);
            UserDel.Text = "";
            /*
            string[] list = AppMan.BadAppString();
            ShowBadAppList.Text = "";
            for (int j = 0; j < list.Length; j++)
            {
                //Console.WriteLine(list[i]);
                ShowBadAppList.Text += list[j] + "\n";
            }*/
            AppMan.UpdateTextBox(ShowBadAppList, AppMan.BadAppString());
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

        private void btnTaskViewer_Click(object sender, EventArgs e)
        {

        }
    }
}
