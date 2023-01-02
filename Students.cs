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
    public partial class Students : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Students()
        {
            InitializeComponent();
            LoadStudent();
        }

        public void LoadStudent()
        {
            int i = 0;
            dgvStudent.Rows.Clear();
            com = new SqlCommand("SELECT name, studentNum, createdAt FROM tbAsset ", con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvStudent.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void addNew_Click(object sender, EventArgs e)
        {
            AssetModule formModule = new AssetModule();
            //formModule.btnSave.Enabled = true;
            //formModule.btnUpdate.Enabled = false;
            formModule.ShowDialog();
            LoadStudent();
        }

        private void dgvAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadStudent();
        }
    }
}
