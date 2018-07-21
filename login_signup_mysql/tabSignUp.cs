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
    public partial class tabSignUp : UserControl
    {
        public tabSignUp()
        {
            //prevent control from running in design mode

            if (Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1.mainInstance.showSignIn();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //validate
            //username
            if (!Validator.isValidName(txtFullname.Text))
            {
                //update icon
                return;
            }

            //username
            if (!Validator.isValidUsernameName(txtUserName.Text))
            {
                //update icon
                return;
            }

            //username
            if (!Validator.isValidEmail(txtEmail.Text))
            {
                //update icon
                return;
            }

            //username
            if (!Validator.isValidPassword(txtPass1.Text) && txtPass1.Text == txtPass2.Text)
            {
                //update icon
                return;
            }

            //SUCCESS VALIATION


            //INNSERT DB AND LOAD LOGIN


            //INSERT INTO `tblusers` (`id`, `name`, `email`, `passMD5`, `updatedAt`, `createdAt`, `createdBy`) VALUES(NULL, 'name', 'email', MD5('PASSWORD'), CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, CURRENT_USER());
            //connect to db
             //check if user exists

             Program.databaseInstance.GetAll("SELECT * FROM `tblusers` WHERE `email` LIKE '"+txtEmail.Text.Trim()+"'");
            
            if (Program.databaseInstance.RecordCount>0)
            {
                //user alredy exist
                lblError.Text = "The email is already taken";
                txtEmail.IconRight = Form1.mainInstance.getValidatoImage(false);
                return;
            }

            ///not exists then insert :)
            ///

            Program.databaseInstance.ExecuteNonQuery("INSERT INTO `tblusers` (`id`, `name`, `email`, `passMD5`, `updatedAt`, `createdAt`, `createdBy`) VALUES(NULL, '"+txtUserName.Text.Trim()+"', '"+txtEmail.Text.Trim()+"', MD5('"+txtPass1.Text.Trim()+"'), CURRENT_TIMESTAMP, CURRENT_TIMESTAMP, CURRENT_USER());");

            MessageBox.Show("User successfully added");
          
            Form1.mainInstance.showSignIn();
        }

        private void txtFullname_TextChange(object sender, EventArgs e)
        {
          
                //update icon
                txtFullname.IconRight = Form1.mainInstance.getValidatoImage(Validator.isValidName(txtFullname.Text));
            
        }

        private void txtUserName_TextChange(object sender, EventArgs e)
        {
            //update icon
            txtUserName.IconRight = Form1.mainInstance.getValidatoImage(Validator.isValidUsernameName(txtUserName.Text));

        }

        private void txtPass1_TextChange(object sender, EventArgs e)
        {
            //update icon
            txtPass1.IconRight = Form1.mainInstance.getValidatoImage(Validator.isValidPassword(txtPass1.Text));

        }

        private void txtEmail_TextChange(object sender, EventArgs e)
        {
            //update icon
            txtEmail.IconRight = Form1.mainInstance.getValidatoImage(Validator.isValidEmail(txtEmail.Text));
            lblError.Text = "";
        }

        private void txtPass2_TextChange(object sender, EventArgs e)
        {
            //update icon
            txtPass2.IconRight = Form1.mainInstance.getValidatoImage(txtPass1.Text==txtPass2.Text);

        }
    }
}
