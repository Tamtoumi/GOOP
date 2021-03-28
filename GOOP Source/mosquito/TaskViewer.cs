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
            ProgressTracker.makeSavedUserAssignments();//creates SavedUserAssignments.txt
            rtxtList.ReadOnly = true;

            btnStart.ForeColor = System.Drawing.Color.MediumSeaGreen;
            btnStart.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            readSUAOnce(); //will read SUA file but will never activate for a second time.
            
        }

        private void txtEnterTask_TextChanged(object sender, EventArgs e)
        {

        }

        // @brief will read SUA for the first time and will not activate again until restating the program.
        // @return Void
        private void readSUAOnce()
        {
            if (GUI.SavedUserAssignmentsRead == false)
            {
                GUI.ReadSUA();
            }
            GUI.SavedUserAssignmentsRead = true;
        }

        // @brief will display SUA tasks to The text box
        // @return Void
         private void showRichTextBox()
         {
              //this will show every task in the gui
              string[] SavedUserAssignments = ProgressTracker.readSavedUserAssignments();
              string[] dist = SavedUserAssignments.Distinct().ToArray();
              foreach (string usertask in dist)
              {
                 txtEnterTask.Text = usertask;
                 GUI.TaskDisplay(txtEnterTask, rtxtList);
              }
              txtEnterTask.Text = "";
              txtDeleteTask.Text = "";
         }

        // @brief puts User input into SUA, enteredtasks in GUI and cleans file.
        // @param file only runs on click of create task button
        // @return Void
        private void btnCreate_Click(object sender, EventArgs e)
        {
            ProgressTracker.updateSavedUserAssignments(txtEnterTask.Text);
            GUI.TaskDisplay(txtEnterTask, rtxtList);
            ProgressTracker.cleanSUA2();
        }

        // @brief deletes from file and displays
        // @param activates on click of delete button
        // @return Void
        private void btnDelete_Click(object sender, EventArgs e)
        {

             if (ProgressTracker.eraseFromSavedUserAssignments(txtDeleteTask.Text))
            {
                rtxtList.ResetText();
                showRichTextBox();
            }
            ProgressTracker.cleanSUA2();
        }

        // @brief creates from file and displays
        // @param activates on enter of create button
        // @return Void
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

        // @brief clears text, enters productive mode.
        // @param activates on click of done button
        // @return Void

        private void btnDone_Click(object sender, EventArgs e)
        {
            rtxtList.ResetText();
            Productive newForm = new Productive();
            newForm.Show();
            this.Close();   // this closes both form1 and taskviewer...
            //this.Hide();
        }

        // @brief resets text redisplays text for updated file from another window
        // @param  starts on load of class
        // @return Void

        private void TaskViewer_Load(object sender, EventArgs e)
        {
            rtxtList.ResetText();
            showRichTextBox();
        }
        

        //Unused class for now
        public static void cleanBoard()
        {

        }

    }
}
