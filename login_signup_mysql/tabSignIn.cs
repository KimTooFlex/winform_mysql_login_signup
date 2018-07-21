using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup_mysql
{
    public partial class tabSignIn : UserControl
    {
        public tabSignIn()
        {
            //prevent control from running in design mode

            if(Program.IsInDesignMode())
            {
                return;
            }

            InitializeComponent();
        }

        private void btnShowSignUp_Click(object sender, EventArgs e)
        {
            Form1.mainInstance.showSignUp();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(Validator.isValidUsernameName(txtUsername.Text) && Validator.isValidPassword(txtPassword.Text))
            {
                //check database and validate
                Program.databaseInstance.GetAll("SELECT * FROM `tblusers` WHERE name LIKE '"+txtUsername.Text.Trim()+"' AND passMD5 LIKE MD5('"+txtPassword.Text.Trim()+"') LIMIT 1");

                if (Program.databaseInstance.RecordCount>0)
                {
                    //found
                    Form1.mainInstance.showProfile();
                }
                else
                {
                    lblError.Text = "Invalid Login Credentials";
                }

            

            }
        }

        private void txtUsername_TextChange(object sender, EventArgs e)
        {
            //update icon
            txtUsername.IconRight = Form1.mainInstance.getValidatoImage(Validator.isValidUsernameName(txtUsername.Text));
            lblError.Text = "";
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            //update icon
            txtPassword.IconRight = Form1.mainInstance.getValidatoImage(Validator.isValidPassword(txtPassword.Text));
            lblError.Text = "";
        }
    }
}
