using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup_mysql
{
    public partial class Form1 : Form
    {

        //create a globally accessible main instance

        public static Form1 mainInstance = null;

        public Form1()
        {
            //register main instance

            mainInstance = this;

            InitializeComponent();

            ///lets make form draggable
            ///we attach controls to capture drag events

            bunifuFormDock1.SubscribeControlsToDragEvents(new Control[] {
                tabSignUp1,
                tabSignIn1,
                tabProfile1
            } ,false );
        }

        public Image getValidatoImage(bool Valid)
        {
            if(Valid)
            {
                return imageListValidatorIcons.Images[0];
            }
            return imageListValidatorIcons.Images[1];
        }

        internal void showProfile()
        {

            //show profile tab
            tabProfile1.Visible = false;
            tabProfile1.BringToFront();
            tabProfile1.refreshData();
            bunifuTransition1.ShowSync(tabProfile1);
        }

        internal void showSignIn()
        {
            //show signIn tab
            tabSignIn1.Visible = false;
            tabSignIn1.BringToFront();
            bunifuTransition1.ShowSync(tabSignIn1);
        }

        internal void showSignUp()
        {
            //show Signup tab
            tabSignUp1.Visible = false;
            tabSignUp1.BringToFront();
            bunifuTransition1.ShowSync(tabSignUp1);
        }
    }
}
