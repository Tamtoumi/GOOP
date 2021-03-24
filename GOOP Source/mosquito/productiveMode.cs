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
    public partial class productiveMode : Form
    {

        TaskViewer newForm = new TaskViewer();
        public Form3(Form2 frm3)
        {
            InitializeComponent();
            newForm = frm3;
        }
        public productiveMode()
        {
            InitializeComponent();
        }


    }
}
