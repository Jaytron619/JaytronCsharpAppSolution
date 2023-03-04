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

namespace LoginRegistration
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public LoginForm()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=JAYTRON;Initial Catalog=JAYSOFT;Integrated Security=True";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            SignupForm mm = new SignupForm();
            mm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Login";
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                if (txtUsername2.Text.Equals(dr["username"].ToString()) && txtPassword2.Text.Equals(dr["password"].ToString()))
                {
                    MessageBox.Show("Login Successful", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                    MainForm mn = new MainForm();
                    mn.Show();
                }
                else
                {
                    MessageBox.Show("Either Username or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }

            con.Close();
        }

        private void txtUsername2_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword2_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsernameEnter(object sender, EventArgs e)
        {
            if (txtUsername2.Text.Equals(@"Username/ Email"))
            {
                txtUsername2.Text = "";
            }
        }

        private void txtUsernameLeave(object sender, EventArgs e)
        {
            if (txtUsername2.Text.Equals(""))
            {
                txtUsername2.Text = @"Username/ Email";
            }
        }

        private void txtPasswordEnter(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Equals("Password"))
            {
                txtPassword2.Text = "";
            }
        }

        private void txtPasswordLeave(object sender, EventArgs e)
        {
            if (txtPassword2.Text.Equals(""))
            {
                txtPassword2.Text = "Password";
            }
        }
    } 
}