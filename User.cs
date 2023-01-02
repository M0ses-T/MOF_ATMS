using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MOF_ATMS
{
    public partial class User : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        public User()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            txtFullnames.Clear();
            txtUsername.Clear();    
            txtpass.Clear();
            txtRety.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpass.Text != txtRety.Text)
                {
                    MessageBox.Show("Passwords did not Match!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else
                {
                    com = new SqlCommand("INSERT INTO tbUser(fullName,username,password)VALUES(@fullName,@username,@password)", con);
                    com.Parameters.AddWithValue("@fullName", txtFullnames.Text);
                    com.Parameters.AddWithValue("@username", txtUsername.Text);
                    com.Parameters.AddWithValue("@password", txtpass.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("User has been added successfully!");
                    Clear();
                    this.Close();
                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
