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

            using (var userLogin = new UserLogin())
            {
                if (userLogin.ShowDialog() == DialogResult.OK)
                {
                    if (userLogin.IsAdmin)
                        Application.Run(new AdminHomePage());
                    else
                        Application.Run(new UserHomePage());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
