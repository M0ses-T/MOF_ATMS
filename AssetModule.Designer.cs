namespace MOF_ATMS
{
    partial class AssetModule
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtAssetId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAssigned = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStudentN = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 96);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(64, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW ASSET";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(387, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancel.Location = new System.Drawing.Point(549, 324);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(468, 324);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAssetId
            // 
            this.txtAssetId.Location = new System.Drawing.Point(87, 157);
            this.txtAssetId.Name = "txtAssetId";
            this.txtAssetId.Size = new System.Drawing.Size(212, 23);
            this.txtAssetId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Asset ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // txtAssigned
            // 
            this.txtAssigned.Location = new System.Drawing.Point(87, 281);
            this.txtAssigned.Name = "txtAssigned";
            this.txtAssigned.Size = new System.Drawing.Size(212, 23);
            this.txtAssigned.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Assigned Student";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 217);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(212, 23);
            this.txtName.TabIndex = 8;
            // 
            // lblAID
            // 
            this.lblAID.AutoSize = true;
            this.lblAID.Location = new System.Drawing.Point(130, 328);
            this.lblAID.Name = "lblAID";
            this.lblAID.Size = new System.Drawing.Size(38, 15);
            this.lblAID.TabIndex = 10;
            this.lblAID.Text = "label5";
            this.lblAID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Number";
            // 
            // txtStudentN
            // 
            this.txtStudentN.Location = new System.Drawing.Point(344, 157);
            this.txtStudentN.Name = "txtStudentN";
            this.txtStudentN.Size = new System.Drawing.Size(212, 23);
            this.txtStudentN.TabIndex = 11;
            // 
            // AssetModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 368);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStudentN);
            this.Controls.Add(this.lblAID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAssigned);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAssetId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssetModule";
            this.Text = "AssetModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnSave;
        private Label label1;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtAssetId;
        private Label label2;
        private Label label3;
        private TextBox txtAssigned;
        private Label label4;
        private TextBox txtName;
        private Label lblAID;
        private Label label5;
        private TextBox txtStudentN;
    }
}