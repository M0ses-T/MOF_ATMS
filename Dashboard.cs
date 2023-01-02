using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace MOF_ATMS
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Dashboard()
        {
            InitializeComponent();
            LoadAsset();    
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void LoadAsset()
        {
            int i = 0;
            dgvRecentAsset.Rows.Clear();
            com = new SqlCommand("SELECT * FROM tbAsset", con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvRecentAsset.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            con.Close();
        }
    }
}
