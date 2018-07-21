using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup_mysql
{
    static class Program
    {

      public static  Bunifu.Data.Helper.Mysql databaseInstance = new Bunifu.Data.Helper.Mysql("login_demo");


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }


        /// <summary>
        /// Determines whether [is in design mode].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [is in design mode]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInDesignMode()
        {
            if (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1)
            {
                return true;
            }
            return false;
        }
    }
}
