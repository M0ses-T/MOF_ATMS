using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MOF_ATMS
{
    public partial class Splash : Form
    { 
        public Splash()
        {
            InitializeComponent();
            cprogressBar1.Value = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cprogressBar1.Value += 5;
            cprogressBar1.Text = cprogressBar1.Value.ToString() + "%";
            if (cprogressBar1.Value == 100)
            {
                timer1.Enabled= false;
                SignIn second = new SignIn();
                second.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
        }
    }
}
