
namespace mosquito
{
    partial class TaskViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.lblEnterTask = new System.Windows.Forms.Label();
            this.txtEnterTask = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.rtxtList = new System.Windows.Forms.RichTextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTask2Delete = new System.Windows.Forms.Label();
            this.txtDeleteTask = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(262, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(46, 17);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // lblEnterTask
            // 
            this.lblEnterTask.AutoSize = true;
            this.lblEnterTask.Location = new System.Drawing.Point(27, 56);
            this.lblEnterTask.Name = "lblEnterTask";
            this.lblEnterTask.Size = new System.Drawing.Size(81, 17);
            this.lblEnterTask.TabIndex = 1;
            this.lblEnterTask.Text = "Enter Task:";
            // 
            // txtEnterTask
            // 
            this.txtEnterTask.Location = new System.Drawing.Point(53, 98);
            this.txtEnterTask.Name = "txtEnterTask";
            this.txtEnterTask.Size = new System.Drawing.Size(237, 22);
            this.txtEnterTask.TabIndex = 2;
            this.txtEnterTask.TextChanged += new System.EventHandler(this.txtEnterTask_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(312, 86);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 47);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCreate_KeyDown);
            // 
            // rtxtList
            // 
            this.rtxtList.Location = new System.Drawing.Point(60, 285);
            this.rtxtList.Name = "rtxtList";
            this.rtxtList.ReadOnly = true;
            this.rtxtList.Size = new System.Drawing.Size(374, 214);
            this.rtxtList.TabIndex = 4;
            this.rtxtList.Text = "";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(457, 493);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 48);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(312, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 49);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTask2Delete
            // 
            this.lblTask2Delete.AutoSize = true;
            this.lblTask2Delete.Location = new System.Drawing.Point(27, 169);
            this.lblTask2Delete.Name = "lblTask2Delete";
            this.lblTask2Delete.Size = new System.Drawing.Size(142, 17);
            this.lblTask2Delete.TabIndex = 7;
            this.lblTask2Delete.Text = "Enter Task to Delete:";
            // 
            // txtDeleteTask
            // 
            this.txtDeleteTask.Location = new System.Drawing.Point(53, 215);
            this.txtDeleteTask.Name = "txtDeleteTask";
            this.txtDeleteTask.Size = new System.Drawing.Size(237, 22);
            this.txtDeleteTask.TabIndex = 8;
            // 
            // TaskViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 563);
            this.Controls.Add(this.txtDeleteTask);
            this.Controls.Add(this.lblTask2Delete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rtxtList);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtEnterTask);
            this.Controls.Add(this.lblEnterTask);
            this.Controls.Add(this.title);
            this.Name = "TaskViewer";
            this.Text = "Task Viewer";
            this.Load += new System.EventHandler(this.TaskViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lblEnterTask;
        private System.Windows.Forms.TextBox txtEnterTask;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.RichTextBox rtxtList;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTask2Delete;
        private System.Windows.Forms.TextBox txtDeleteTask;
    }
}