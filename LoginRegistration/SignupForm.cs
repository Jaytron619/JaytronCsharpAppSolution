using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistration
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm mm = new LoginForm();
           mm.Show();
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            
            
                this.Hide();
                MainForm mn = new MainForm();
                mn.Show();
        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("Enter Username/ Email"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {

            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Enter Username/ Email";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = "Password";
            }
        }

        private void txtFullNameEnter(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals(@"Enter Full name"))
            {
                txtFullName.Text = "";
            }
        }

        private void txtFullNameLeave(object sender, EventArgs e)
        {
            if (txtFullName.Text.Equals(""))
            {
                txtFullName.Text = @"Enter Full name";
            }
        }

        private void txtConfirmEnter(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text.Equals("Password"))
            {
                txtConfirmPass.Text = "";
            }
        }

        private void txtConfirmLeave(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text.Equals(""))
            {
                txtConfirmPass.Text = "Password";
            }
        }
    }
}
