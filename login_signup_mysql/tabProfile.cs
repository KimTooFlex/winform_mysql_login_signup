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
    public partial class tabProfile : UserControl
    {
        public tabProfile()
        {
            //prevent control from running in design mode

            if (Program.IsInDesignMode())
            {
                return;
            }
            InitializeComponent();
        }

        public void refreshData()
        {
            lblname.Text = Program.databaseInstance.GetResults(0, "name").ToUpper();
            lblEmail.Text = Program.databaseInstance.GetResults(0, "email").ToUpper();
          //  lblBio.Text = Program.databaseInstance.GetResults(0, "bio").ToUpper();
        }

        private void btnShowSignIn_Click(object sender, EventArgs e)
        {
            Form1.mainInstance.showSignIn();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
