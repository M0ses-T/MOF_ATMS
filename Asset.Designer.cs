namespace MOF_ATMS
{
    partial class Asset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asset));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.addNew = new System.Windows.Forms.PictureBox();
            this.dgvAsset = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assinedStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.qr = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Assets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.addNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 63);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(455, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search box:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(562, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(172, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // addNew
            // 
            this.addNew.Image = ((System.Drawing.Image)(resources.GetObject("addNew.Image")));
            this.addNew.Location = new System.Drawing.Point(934, 7);
            this.addNew.Name = "addNew";
            this.addNew.Size = new System.Drawing.Size(74, 50);
            this.addNew.TabIndex = 1;
            this.addNew.TabStop = false;
            this.addNew.Click += new System.EventHandler(this.addNew_Click);
            // 
            // dgvAsset
            // 
            this.dgvAsset.AllowUserToAddRows = false;
            this.dgvAsset.AllowUserToDeleteRows = false;
            this.dgvAsset.AllowUserToResizeColumns = false;
            this.dgvAsset.AllowUserToResizeRows = false;
            this.dgvAsset.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAsset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsset.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(96)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsset.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsset.ColumnHeadersHeight = 40;
            this.dgvAsset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAsset.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.assetID,
            this.name,
            this.assinedStudent,
            this.studentId,
            this.createdAt,
            this.edit,
            this.delete,
            this.qr});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAsset.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAsset.EnableHeadersVisualStyles = false;
            this.dgvAsset.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAsset.Location = new System.Drawing.Point(0, 0);
            this.dgvAsset.MultiSelect = false;
            this.dgvAsset.Name = "dgvAsset";
            this.dgvAsset.ReadOnly = true;
            this.dgvAsset.RowHeadersVisible = false;
            this.dgvAsset.RowHeadersWidth = 20;
            this.dgvAsset.RowTemplate.Height = 25;
            this.dgvAsset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsset.Size = new System.Drawing.Size(1020, 410);
            this.dgvAsset.TabIndex = 2;
            this.dgvAsset.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAsset_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.FillWeight = 20F;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // assetID
            // 
            this.assetID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assetID.FillWeight = 70F;
            this.assetID.HeaderText = "Asset ID";
            this.assetID.Name = "assetID";
            this.assetID.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.FillWeight = 70F;
            this.name.HeaderText = "Device Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // assinedStudent
            // 
            this.assinedStudent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assinedStudent.FillWeight = 70F;
            this.assinedStudent.HeaderText = "Assigned Student";
            this.assinedStudent.Name = "assinedStudent";
            this.assinedStudent.ReadOnly = true;
            // 
            // studentId
            // 
            this.studentId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.studentId.FillWeight = 70F;
            this.studentId.HeaderText = "Student Number";
            this.studentId.Name = "studentId";
            this.studentId.ReadOnly = true;
            // 
            // createdAt
            // 
            this.createdAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.createdAt.HeaderText = "Date Assigned";
            this.createdAt.Name = "createdAt";
            this.createdAt.ReadOnly = true;
            this.createdAt.Width = 98;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.edit.FillWeight = 20F;
            this.edit.HeaderText = "Edit";
            this.edit.Image = global::MOF_ATMS.Properties.Resources.icons8_pencil_20;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.delete.FillWeight = 20F;
            this.delete.HeaderText = "Delete";
            this.delete.Image = global::MOF_ATMS.Properties.Resources.icons8_trash_20;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            // 
            // qr
            // 
            this.qr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qr.FillWeight = 20F;
            this.qr.HeaderText = "Gen QR";
            this.qr.Image = global::MOF_ATMS.Properties.Resources.icons8_qr_code_16;
            this.qr.Name = "qr";
            this.qr.ReadOnly = true;
            // 
            // Asset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1020, 473);
            this.Controls.Add(this.dgvAsset);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asset";
            this.Text = "Asset";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox addNew;
        private DataGridView dgvAsset;
        private Label label2;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn assetID;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn assinedStudent;
        private DataGridViewTextBoxColumn studentId;
        private DataGridViewTextBoxColumn createdAt;
        private DataGridViewImageColumn edit;
        private DataGridViewImageColumn delete;
        private DataGridViewImageColumn qr;
    }
}