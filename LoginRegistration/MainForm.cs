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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (SidePanel.Width == 195) 
            {
                SidePanel.Visible = true;
                SidePanel.Width = 50;
                lblLogo.Hide();
                LogoPic.Visible = true;
            }
            else 
            {
                SidePanel.Visible = true;
                SidePanel.Width = 195;
                lblLogo.Show();
                LogoPic.Visible = false;

                
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
