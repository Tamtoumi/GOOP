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
    public partial class Form3 : Form
    {
        Form2 frmb = new Form2();
        public Form3(Form2 frm3)
        {
            InitializeComponent();
            frmb = frm3;
        }

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            tasklbl.Text = File.ReadAllText(UpdateFile.Globals.path);
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            frmb.Show();
            this.Close();
        }

        private void tasklbl_Click(object sender, EventArgs e)
        {
            
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
    public partial class Form3 : Form
    {
        Form2 frmb = new Form2();
        public Form3(Form2 frm3)
        {
            InitializeComponent();
            frmb = frm3;
        }

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            tasklbl.Text = File.ReadAllText(UpdateFile.Globals.path);
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            frmb.Show();
            this.Close();
        }

        private void tasklbl_Click(object sender, EventArgs e)
        {
            
        }
    }
}
>>>>>>> e582082d5beaddfe72f3be9c5e97671bc5909fea
