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
    public partial class popupWindow : Form
    {
        Form1 from1 = new Form1();
        System.Random random = new System.Random();
        
        public popupWindow()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            int x = random.Next(Screen.PrimaryScreen.Bounds.Width - this.Size.Width);
            int y = random.Next(Screen.PrimaryScreen.Bounds.Height - this.Size.Height);

            this.Location = new Point(x, y);
        }

        private void popupWindow_Load(object sender, EventArgs e)
        {

        }

        private void popupWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
