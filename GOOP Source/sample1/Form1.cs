<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sample1
{
    public partial class Form1 : Form
    {
        int intClicks, enterkey, tot = 0;
        //string clicks, entkey = "0";
        string value1, value2;
        public Form1()
        {
            InitializeComponent();
            //txtTask.KeyDown += txtTask_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frma = new Form2();
            frma.Show();
            //this.Hide();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            intClicks++;
            //int clicks = int.Parse(clicks);
            if (String.IsNullOrWhiteSpace(txtTask.Text))
            {
                return;
            }

            string tasks = "- " + txtTask.Text;
            //string tasks = intClicks.ToString() + ". " + txtTask.Text;
            UpdateFile.Update(tasks);
            txtTask.Text = "";
            taskList.Text = File.ReadAllText(UpdateFile.Globals.path);
            txtTlist.Text = File.ReadAllText(UpdateFile.Globals.path);



            //for (int index = 1; index < intClicks + 1; index++)
            //{

            //    string taskList = index + ". " +
            //}
            //TextReader rtxt = new StreamReader("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //rtxt.ReadToEnd();
            //rtxt.Close();
            //TextWriter txt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //txt.Write(txtTask.Text);
            //txt.Close();


            //this.Close();

            // WORKS FOR ONE LINERS
            //string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";
            //File.WriteAllText(path, txtTask.Text);
            //MessageBox.Show("wrote it to file");
            //var str = File.ReadAllText(path);
            //txtTlist.Text = str;


            //else
            //{
            //    TextReader rtxt = new StreamReader("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //    rtxt.ReadToEnd();
            //    rtxt.Close();

            //    TextWriter txt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //    txt.Write(txtTask.Text);
            //    txt.Close();
            //    try
            //    {
            //        // Open the text file using a stream reader.
            //        using (var sr = new StreamReader("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt"))
            //        {
            //            // Read the stream as a string, and write the string to the console.
            //            Console.WriteLine(sr.ReadToEnd());

            //        }
            //        TextWriter wtxt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //        wtxt.Write(txtTask.Text);
            //        wtxt.Close();
            //    }
            //    catch (IOException ex)
            //    {
            //        Console.WriteLine("The file could not be read:");
            //        Console.WriteLine(ex.Message);
            //    }

            //    //TextWriter rtxt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //    //rtxt.Write(txtTlist.Text);
            //    //rtxt.Close();
            //}


            //var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taskList.txt");
            //var sb = new StringBuilder();

            //for(int index = 1; index < intClicks+1; index++)
            //{
            //    sb.AppendLine(index.ToString() + ". ");
            //}
            //File.WriteAllText(fileName, sb.ToString());


            //THIS IS THE CODE IF YOU TYPE OUT A PARAGRAPH TO WRITE TO TEXTFILE
            //TextWriter taskList = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\TaskList.txt");
            //taskList.Write(textBox1.Text);
            //taskList.Close();


            // ROSS CODE 
            //if (String.IsNullOrWhiteSpace(TaskList.Text))
            //{
            //    return;
            //}
            //string tasks = TaskList.Text;
            //Console.WriteLine(tasks);
            //TaskList.Text = "";
            //this.Close();
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTlist_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (String.IsNullOrWhiteSpace(txtTask.Text))
                {
                    return;
                }
                
                string tasks = "- " + txtTask.Text;
                UpdateFile.Update(tasks);
                txtTask.Text = "";
                txtTlist.Text = "";
                taskList.Text = File.ReadAllText(UpdateFile.Globals.path);
                txtTlist.Text = File.ReadAllText(UpdateFile.Globals.path);
            }
        }

        private void taskList_Click(object sender, EventArgs e)
        {

        }

        // FOR TESTING PURPOSES DELETING THE FILE AFTER THE FORM HAS BEEN CLOSED 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(UpdateFile.Globals.path);
        }
    }

   
}
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sample1
{
    public partial class Form1 : Form
    {
        int intClicks, enterkey, tot = 0;
        //string clicks, entkey = "0";
        string value1, value2;
        public Form1()
        {
            InitializeComponent();
            //txtTask.KeyDown += txtTask_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frma = new Form2();
            frma.Show();
            //this.Hide();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            intClicks++;
            //int clicks = int.Parse(clicks);
            if (String.IsNullOrWhiteSpace(txtTask.Text))
            {
                return;
            }

            string tasks = "- " + txtTask.Text;
            //string tasks = intClicks.ToString() + ". " + txtTask.Text;
            UpdateFile.Update(tasks);
            txtTask.Text = "";
            taskList.Text = File.ReadAllText(UpdateFile.Globals.path);
            txtTlist.Text = File.ReadAllText(UpdateFile.Globals.path);



            //for (int index = 1; index < intClicks + 1; index++)
            //{

            //    string taskList = index + ". " +
            //}
            //TextReader rtxt = new StreamReader("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //rtxt.ReadToEnd();
            //rtxt.Close();
            //TextWriter txt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //txt.Write(txtTask.Text);
            //txt.Close();


            //this.Close();

            // WORKS FOR ONE LINERS
            //string path = @"C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt";
            //File.WriteAllText(path, txtTask.Text);
            //MessageBox.Show("wrote it to file");
            //var str = File.ReadAllText(path);
            //txtTlist.Text = str;


            //else
            //{
            //    TextReader rtxt = new StreamReader("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //    rtxt.ReadToEnd();
            //    rtxt.Close();

            //    TextWriter txt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //    txt.Write(txtTask.Text);
            //    txt.Close();
            //    try
            //    {
            //        // Open the text file using a stream reader.
            //        using (var sr = new StreamReader("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt"))
            //        {
            //            // Read the stream as a string, and write the string to the console.
            //            Console.WriteLine(sr.ReadToEnd());

            //        }
            //        TextWriter wtxt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //        wtxt.Write(txtTask.Text);
            //        wtxt.Close();
            //    }
            //    catch (IOException ex)
            //    {
            //        Console.WriteLine("The file could not be read:");
            //        Console.WriteLine(ex.Message);
            //    }

            //    //TextWriter rtxt = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\sample1\\text\\taskList.txt");
            //    //rtxt.Write(txtTlist.Text);
            //    //rtxt.Close();
            //}


            //var fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "taskList.txt");
            //var sb = new StringBuilder();

            //for(int index = 1; index < intClicks+1; index++)
            //{
            //    sb.AppendLine(index.ToString() + ". ");
            //}
            //File.WriteAllText(fileName, sb.ToString());


            //THIS IS THE CODE IF YOU TYPE OUT A PARAGRAPH TO WRITE TO TEXTFILE
            //TextWriter taskList = new StreamWriter("C:\\Users\\Angel\\Documents\\Spring 2021\\CSC 3380 - OOD\\Code\\TaskList.txt");
            //taskList.Write(textBox1.Text);
            //taskList.Close();


            // ROSS CODE 
            //if (String.IsNullOrWhiteSpace(TaskList.Text))
            //{
            //    return;
            //}
            //string tasks = TaskList.Text;
            //Console.WriteLine(tasks);
            //TaskList.Text = "";
            //this.Close();
        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTlist_TextChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txtTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (String.IsNullOrWhiteSpace(txtTask.Text))
                {
                    return;
                }
                
                string tasks = "- " + txtTask.Text;
                UpdateFile.Update(tasks);
                txtTask.Text = "";
                txtTlist.Text = "";
                taskList.Text = File.ReadAllText(UpdateFile.Globals.path);
                txtTlist.Text = File.ReadAllText(UpdateFile.Globals.path);
            }
        }

        private void taskList_Click(object sender, EventArgs e)
        {

        }

        // FOR TESTING PURPOSES DELETING THE FILE AFTER THE FORM HAS BEEN CLOSED 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(UpdateFile.Globals.path);
        }
    }

   
}
>>>>>>> e582082d5beaddfe72f3be9c5e97671bc5909fea
