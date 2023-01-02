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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("hh:mm:ss");
            label5.Text = DateTime.Now.ToLongDateString();

        }
    }
}
