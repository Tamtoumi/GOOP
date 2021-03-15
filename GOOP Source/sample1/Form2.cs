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

namespace sample1
{
    public partial class Form2 : Form
    {
        Form1 frma = new Form1();

        public Form2(Form1 frm2)
        {
            InitializeComponent();
            frma = frm2;
        }

        public Form2()
        {
            InitializeComponent();
            //string context = File.ReadAllText(@"TaskList.txt");
            //taskListBox.text = context;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // IF (startBtn_Click = click first time)
            //frma.Show();
            //this.Close();

            // ELSE  
            Form3 frmb = new Form3();
            frmb.Show();
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            taskslisted.Text = File.ReadAllText(UpdateFile.Globals.path);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void taskslisted_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //public static byte[] ReadFile()
        //{
        //    FileStream fstream = new FileStream(@"TaskList.txt", FileMode.Open, FileAccess.Read);
        //    byte[] buffer;
        //    try
        //    {
        //        int length = (int)fstream.Length;
        //        buffer = new byte[length];
        //        int count;
        //        int sum = 0;

        //        while ((count - fstream.Read(buffer, sum, length - sum)) > 0)
        //            sum += count;
        //    }
        //    finally
        //    {
        //        fstream.Close();
        //    }
        //    return buffer;
        //}
    }
}
