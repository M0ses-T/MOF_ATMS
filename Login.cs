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
using System.Xml.Linq;

namespace MOF_ATMS
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\dbMATMS.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public Login()
        {
        
            InitializeComponent();
            MakeLogin();
        }

        public void MakeLogin ()
        {
            com = new SqlCommand("INSERT INTO tbUser(fullName,username)VALUES(@username,@password)", con);
            com.Parameters.AddWithValue("@username", "admin");
            com.Parameters.AddWithValue("@password", "admin1");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin1")
            {
                MessageBox.Show("Login Successful!", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new MainForm().Show();
                this.Hide();
            }

            else
            {
                try
                {
                    com = new SqlCommand("SELECT * FROM tbUser WHERE username=@username AND password=@password", con);
                    com.Parameters.AddWithValue("@username", txtUsername.Text);
                    com.Parameters.AddWithValue("@password", txtPassword.Text);
                    con.Open();
                    dr = com.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Welcome " + dr["fullname"].ToString() + " | ", "ACCESS GRANTED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm main = new MainForm();
                        this.Hide();
                        main.Show();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new SignIn().Show();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false) { txtPassword.UseSystemPasswordChar = true; }
            else 
                txtPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            
            this.Close ();
            
        }
    }
}
