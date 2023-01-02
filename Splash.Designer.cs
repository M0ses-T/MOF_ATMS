namespace MOF_ATMS
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cprogressBar1 = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cprogressBar1
            // 
            this.cprogressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cprogressBar1.AnimationSpeed = 500;
            this.cprogressBar1.BackColor = System.Drawing.Color.Transparent;
            this.cprogressBar1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cprogressBar1.ForeColor = System.Drawing.Color.Magenta;
            this.cprogressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cprogressBar1.InnerMargin = 2;
            this.cprogressBar1.InnerWidth = -1;
            this.cprogressBar1.Location = new System.Drawing.Point(80, 175);
            this.cprogressBar1.MarqueeAnimationSpeed = 2000;
            this.cprogressBar1.Name = "cprogressBar1";
            this.cprogressBar1.OuterColor = System.Drawing.Color.DeepSkyBlue;
            this.cprogressBar1.OuterMargin = -25;
            this.cprogressBar1.OuterWidth = 26;
            this.cprogressBar1.ProgressColor = System.Drawing.Color.Magenta;
            this.cprogressBar1.ProgressWidth = 13;
            this.cprogressBar1.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cprogressBar1.Size = new System.Drawing.Size(120, 120);
            this.cprogressBar1.StartAngle = 270;
            this.cprogressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cprogressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cprogressBar1.SubscriptText = ".23";
            this.cprogressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cprogressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cprogressBar1.SuperscriptText = "°C";
            this.cprogressBar1.TabIndex = 8;
            this.cprogressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cprogressBar1.Value = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(96, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Loading ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(87, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Copyright © Mofolo ATMS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(294, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cprogressBar1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar cprogressBar1;
        private Label label1;
        private Label label2;
    }
}