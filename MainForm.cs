using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOF_ATMS
{
    public partial class MainForm : Form
    {
        //private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
            openChildForm(new Home());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new Home());

        }

        private void btnAssets_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Asset());
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            openChildForm (new Students());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new Dashboard());
        }

        private void btnContacts_Click(object sender, EventArgs e)
        {
            openChildForm(new Contact());
        }

        private void btnSettin_Click(object sender, EventArgs e)
        {
            //
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
            new SignIn().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}