namespace MOF_ATMS
{
    partial class SignIn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbtnRegister = new FontAwesome.Sharp.IconButton();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(469, 259);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 95);
            this.panel4.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(499, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "MOFOLO ATMS";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbtnRegister
            // 
            this.rbtnRegister.FlatAppearance.BorderSize = 0;
            this.rbtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbtnRegister.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.rbtnRegister.IconColor = System.Drawing.Color.Fuchsia;
            this.rbtnRegister.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rbtnRegister.IconSize = 32;
            this.rbtnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnRegister.Location = new System.Drawing.Point(1079, 509);
            this.rbtnRegister.Name = "rbtnRegister";
            this.rbtnRegister.Size = new System.Drawing.Size(128, 34);
            this.rbtnRegister.TabIndex = 6;
            this.rbtnRegister.Text = "Register User";
            this.rbtnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtnRegister.UseVisualStyleBackColor = true;
            this.rbtnRegister.Click += new System.EventHandler(this.rbtnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.RightLong;
            this.btnLogin.IconColor = System.Drawing.Color.Fuchsia;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 30;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(38, 509);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(118, 28);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(535, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "LOCK SCREEN";
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1214, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxClose.TabIndex = 8;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1253, 581);
            this.Controls.Add(this.pictureBoxClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rbtnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton rbtnRegister;
        private FontAwesome.Sharp.IconButton btnLogin;
        private Label label4;
        private PictureBox pictureBoxClose;
    }
}