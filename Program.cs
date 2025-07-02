using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new UserHomePage());

            UserLogin loginForm = new UserLogin();

            if(loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new UserHomePage());
            }    
        }
    }
}
