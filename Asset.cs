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
    public partial class Asset : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public Asset()
        {
            InitializeComponent();
            LoadAsset();
        }

        public void LoadAsset()
        {
            int i = 0;
            dgvAsset.Rows.Clear();
            com = new SqlCommand("SELECT * FROM tbAsset WHERE CONCAT(assetID, name, assignedStudent, studentNum, createdAt) LIKE '%" + txtSearch.Text + "%'", con);
            con.Open();
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvAsset.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString()); //Convert.ToDateTime(dr[1].ToString()).ToString("dd /MM/yyyy")
            }
            dr.Close();
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addNew_Click(object sender, EventArgs e)
        {
            AssetModule assetModule = new AssetModule();
            assetModule.ShowDialog();
            LoadAsset();
        }

        private void dgvAsset_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvAsset.Columns[e.ColumnIndex].Name;
            if (colName == "edit")
            {
                AssetModule assetModule = new  AssetModule();
               /*
                assetModule.txtAssetId.Text = dgvAsset.Rows[e.RowIndex].Cells[1].Value.ToString();
                assetModule.txtName.Text = dgvAsset.Rows[e.RowIndex].Cells[2].Value.ToString();
                assetModule.txtAMN.Text = dgvAsset.Rows[e.RowIndex].Cells[3].Value.ToString();
                assetModule.txtStudentN.Text = dgvAsset.Rows[e.RowIndex].Cells[4].Value.ToString();
                
                assetModule.btnSave.Enabled = false;
                assetModule.btnUpdate.Enabled = true;
               */
                assetModule.ShowDialog();
                LoadAsset();
                
            }
            else if (colName == "delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    com = new SqlCommand("DELETE FROM tbAsset WHERE assetId LIKE '" + dgvAsset.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record has been successfully deleted!");
                }
            }
            else if (colName == "qr")
            //GENERATE QR CODE
            {
                QRCode qRCode = new QRCode();
                qRCode.ShowDialog();
            }

            LoadAsset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAsset();
        }
    }
}
