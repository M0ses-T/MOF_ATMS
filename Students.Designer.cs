namespace MOF_ATMS
{
    partial class Students
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeColumns = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.ColumnHeadersHeight = 40;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.assignedStudent,
            this.studentNumber,
            this.createdAt});
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.EnableHeadersVisualStyles = false;
            this.dgvStudent.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStudent.Location = new System.Drawing.Point(0, 0);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 25;
            this.dgvStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvStudent.RowTemplate.Height = 25;
            this.dgvStudent.Size = new System.Drawing.Size(1004, 371);
            this.dgvStudent.TabIndex = 4;
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsset_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.FillWeight = 30F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // assignedStudent
            // 
            this.assignedStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assignedStudent.HeaderText = "Name";
            this.assignedStudent.Name = "assignedStudent";
            // 
            // studentNumber
            // 
            this.studentNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentNumber.HeaderText = "Student Number";
            this.studentNumber.Name = "studentNumber";
            // 
            // createdAt
            // 
            this.createdAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdAt.FillWeight = 60F;
            this.createdAt.HeaderText = "Date Assigned";
            this.createdAt.Name = "createdAt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Students";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 63);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(481, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search box:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(588, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 434);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Students";
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvStudent;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn assignedStudent;
        private DataGridViewTextBoxColumn studentNumber;
        private DataGridViewTextBoxColumn createdAt;
    }
}