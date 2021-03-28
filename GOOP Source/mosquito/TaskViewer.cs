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
    public partial class TaskViewer : Form
    {
        Form1 newForm;
        List<string> enteredTasks = new List<string>();

        public TaskViewer(Form1 frm2)
        {
            InitializeComponent();
            newForm = frm2;
        }
        public TaskViewer()
        {
            InitializeComponent();
            GUI.setFormVisuals(this, title);
            GUI.labelSetUp(lblEnterTask);
            GUI.labelSetUp(lblTask2Delete);
            GUI.btnSetUp(btnCreate);
            GUI.btnSetUp(btnStart);
            GUI.btnSetUp(btnDelete);
            GUI.txtSetUp(txtEnterTask);
            GUI.txtSetUp(txtDeleteTask);
            GUI.rtxtSetUp(rtxtList);
            AppMan.makeSavedUserAssignments();//creates SavedUserAssignments.txt
            rtxtList.ReadOnly = true;

            btnStart.ForeColor = System.Drawing.Color.MediumSeaGreen;
            btnStart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //this will show every task in the gui
            string[] SavedUserAssignments = AppMan.readSavedUserAssignments();
            foreach (string usertask in SavedUserAssignments)
            {
                txtEnterTask.Text = usertask;
                GUI.TaskList(txtEnterTask, rtxtList);
            }

        }
        private void txtEnterTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AppMan.updateSavedUserAssignments(txtEnterTask.Text);
            GUI.TaskList(txtEnterTask, rtxtList);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AppMan.updateSavedUserAssignments(txtDeleteTask.Text);
            GUI.TaskList(txtDeleteTask, rtxtList);
        }

        private void btnCreate_KeyDown(object sender, KeyEventArgs e)
        {

            // enters and displays the list of tasks entered by user when pressing enter/return
            if (e.KeyCode == Keys.Return)
            {
                //if (String.IsNullOrWhiteSpace(txtEnterTask.Text))
                //{
                //    return;
                //}
                //string tasks = "- " + txtEnterTask.Text + "\r\n";
                //enteredTasks.Add(tasks);
                //txtEnterTask.Text = "";
                //rtxtList.Text = "";
                //foreach (var text in enteredTasks)
                //{
                //    rtxtList.AppendText(text);
                //}

                GUI.TaskList(txtEnterTask, rtxtList);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Productive newForm = new Productive();
            newForm.Show();
            this.Close();   // this closes both form1 and taskviewer...
            //this.Hide();
        }

        private void TaskViewer_Load(object sender, EventArgs e)
        {

        }
        

    }
}
