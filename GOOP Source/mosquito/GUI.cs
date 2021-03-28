using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mosquito
{
    class GUI
    {
        public static System.Drawing.Color mainColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
        public static System.Drawing.Color fontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
        public static List<string> enteredTasks = new List<string>();
        public static bool SavedUserAssignmentsRead = false;
        public static void setFormVisuals(Form Newform, Label TitleLabel)
        
        {
            Newform.BackColor = mainColor;

            // defaults for the title label
            TitleLabel.BackColor = System.Drawing.Color.DimGray;
            TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            TitleLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TitleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            TitleLabel.Location = new System.Drawing.Point(0, 0);
            TitleLabel.Size = new System.Drawing.Size(Newform.Size.Width, 30);
            TitleLabel.TabIndex = 6;
            TitleLabel.AutoSize = false;
            TitleLabel.Text = "The Mosquito";
        }
        
        // this is the default visuals for all labels
        public static void labelSetUp(Label labelName)
        {
            labelName.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelName.ForeColor = fontColor;
            labelName.BackColor = mainColor;
        }

        // this is the default visuals for all buttons
        public static void btnSetUp(Button btnName)
        {
            btnName.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnName.ForeColor = fontColor;
            btnName.BackColor = mainColor;
            btnName.FlatAppearance.BorderSize = 2;
            btnName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;


        }

        // this is the default visuals for all textboxes
        public static void txtSetUp(TextBox txtName)
        {
            txtName.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        }

        public static void richtxtSetUp(RichTextBox txtName)
        {
            txtName.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        }

        // this is the default visuals for all rich textboxes
        public static void rtxtSetUp(RichTextBox txtName)
        {
            txtName.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
        }

        // this function takes in user input from a textbox and displays it to a rich text box 
        public static void TaskList(TextBox txtBox, RichTextBox rtxtBox)
        {
            if (String.IsNullOrWhiteSpace(txtBox.Text))
            {
                return;
            }

            // enters and displays the list of tasks entered by user 
            string tasks = "- " + txtBox.Text + "\r\n";
            enteredTasks.Add(tasks);
            txtBox.Text = "";
            rtxtBox.Text = "";
            foreach (var text in enteredTasks)
            {
                rtxtBox.AppendText(text);
            }

        }

        // this function displays to the box without using the enteredTasks list. used for initializatiin of box
        public static void TaskDisplay(TextBox txtBox, RichTextBox rtxtBox)
        {
            if (String.IsNullOrWhiteSpace(txtBox.Text))
            {
                return;
            }

            // enters and displays the list of tasks entered by user 
            rtxtBox.AppendText("- " + txtBox.Text + "\r\n");

        }

        //places SUA in enteredTasks in proper form. only used once.
        public static void ReadSUA()
        {
            string[] SUA = AppMan.readSavedUserAssignments();

             foreach (string SingleUA in SUA)
             {
                    string tasks = "- " + SingleUA + "\r\n";
                    enteredTasks.Add(tasks);
             }
             enteredTasks.RemoveAt(enteredTasks.Count - 1);
        }

    }

}
