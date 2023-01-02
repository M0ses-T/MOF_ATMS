namespace MOF_ATMS
{
    partial class QRCode
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
            this.iconButtonPrint = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxQR = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButtonPrint
            // 
            this.iconButtonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonPrint.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonPrint.ForeColor = System.Drawing.Color.White;
            this.iconButtonPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.iconButtonPrint.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconButtonPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPrint.IconSize = 35;
            this.iconButtonPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonPrint.Location = new System.Drawing.Point(536, 323);
            this.iconButtonPrint.Name = "iconButtonPrint";
            this.iconButtonPrint.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonPrint.Size = new System.Drawing.Size(124, 52);
            this.iconButtonPrint.TabIndex = 0;
            this.iconButtonPrint.Text = "PRINT";
            this.iconButtonPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPrint.UseVisualStyleBackColor = true;
            this.iconButtonPrint.Click += new System.EventHandler(this.iconButtonPrint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 100);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(120, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QR CODE";
            // 
            // pictureBoxQR
            // 
            this.pictureBoxQR.Location = new System.Drawing.Point(149, 143);
            this.pictureBoxQR.Name = "pictureBoxQR";
            this.pictureBoxQR.Size = new System.Drawing.Size(222, 158);
            this.pictureBoxQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxQR.TabIndex = 2;
            this.pictureBoxQR.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(157, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "QR Code";
            // 
            // QRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(720, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxQR);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButtonPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QRCode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonPrint;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBoxQR;
        private Label label2;
    }
}