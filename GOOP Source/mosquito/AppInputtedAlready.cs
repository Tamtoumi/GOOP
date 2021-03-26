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
    public partial class AppInputtedAlready : Form
    {
        public AppInputtedAlready()
        {
            InitializeComponent();
            GUI.setFormVisuals(this, title);
            GUI.btnSetUp(Close);
            GUI.txtSetUp(textBox1);
            textBox1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppInputtedAlready_Load(object sender, EventArgs e)
        {

        }
    }
}
