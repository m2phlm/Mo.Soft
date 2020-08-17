using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mo.Soft.MyForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ActiveControl = txtPassword;
            this.txtUserName.Text = Mo.Soft.Properties.Settings.Default.UserName;  //Load user name from setting

            string DestFile;
            DestFile = Application.StartupPath + @"\Resources\Pic\UserPic\UserPic.png";   //Load user picture from Mypic/PicUser
            pbxProfilePic.Load(DestFile);


            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            //--------------empty text box checker---------------------
            if (this.txtUserName.Text == "")
            {
                MessageBox.Show("Please write User Name!");
                this.txtPassword.Focus();

            }

            if (this.txtPassword.Text == "")
            {
                MessageBox.Show("Please write User Password!");
            }
            //-------------------------------------------------
            if (this.txtPassword.Text == Mo.Soft.Properties.Settings.Default.UserPassword)  //check user pass from app setting
                                                                                                      // if (this.txtPassword.Text == Microsoft.Win32.Registry.GetValue("Password",)
            {
                //----------------Open Main Form-------------------
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else if (this.txtPassword.Text != "")     //check for correct password
            {
                MessageBox.Show("Wrong password!!");
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
