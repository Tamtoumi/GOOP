using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            if (String.IsNullOrWhiteSpace(Badapps.Text))
            {
                return;
            }
            string apps = Badapps.Text + ".exe";
            //Console.WriteLine(apps);
            Test.UpdateFile(apps);
            Badapps.Text = "";
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
