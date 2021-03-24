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
    public partial class Productive : Form
    {
        TaskViewer newForm = new TaskViewer();
        Form1 forma = new Form1();
        public Productive()
        {
            InitializeComponent();
            GUI.setFormVisuals(this, title);
            GUI.labelSetUp(lblCompletedTask);
            GUI.labelSetUp(lblTasks);
            GUI.labelSetUp(lblRewardTime);
            GUI.labelSetUp(lblTimeRewarded);
            GUI.btnSetUp(btnComplete);
            GUI.btnSetUp(btnUseTime);
            GUI.btnSetUp(btnStop);
            GUI.btnSetUp(btnEdit);
            GUI.txtSetUp(txtCompletedTask);
            GUI.rtxtSetUp(rtxtTaskList);
            rtxtTaskList.ReadOnly = true;
            //rtxtTaskList.Cursor = System.Windows.Forms.Cursors.Default;
            txtCompletedTask.Cursor = System.Windows.Forms.Cursors.IBeam;
            btnStop.ForeColor = System.Drawing.Color.Red;
            btnComplete.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStop.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public Productive(TaskViewer formTV)
        {
            InitializeComponent();
            newForm = formTV;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Close();
            //forma.Show();
        }

        private void Productive_Load(object sender, EventArgs e)
        {
            //rtxtTaskList.Text = 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            newForm.Show();
            this.Close();

        }
    }
}
