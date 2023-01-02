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
    public partial class AssetModule : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        public AssetModule()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtName.Clear();
            txtAssetId.Clear();
            txtAssigned.Clear();
            txtStudentN.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Are you sure you want to save this asset?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    com = new SqlCommand("INSERT INTO tbAsset(assetID,name,assignedStudent,studentNum)VALUES(@assetID,@name,@assignedStudent,@studentNum)", con);
                    com.Parameters.AddWithValue("@assetID", txtAssetId.Text);
                    com.Parameters.AddWithValue("@name", txtName.Text);
                    com.Parameters.AddWithValue("@assignedStudent", txtAssigned.Text);
                    com.Parameters.AddWithValue("@studentNum", Convert.ToInt16(txtStudentN.Text));

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Asset has been successfully saved.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {

                if (MessageBox.Show("Are you sure you want to update this asset?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    com = new SqlCommand("UPDATE tbAsset(assetID,name,assigndStudent)VALUES(@assetID,@name,@assigndStudent)", con);
                    com.Parameters.AddWithValue("@assetID", txtAssetId.Text);
                    com.Parameters.AddWithValue("@name", txtName.Text);
                    com.Parameters.AddWithValue("@assignedStudent", txtAssigned.Text);
                    com.Parameters.AddWithValue("@studentNum", Convert.ToInt16(txtStudentN.Text));

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Asset has been successfully updated.");
                    Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
