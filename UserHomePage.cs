using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MobileShopProject.Controls;

namespace MobileShopProject
{
    public partial class UserHomePage : Form
    {
        private MenuLayoutControl menuLayoutControl;

        public UserHomePage()
        {
            InitializeComponent();
            InitializeMenu();
        }

        private void InitializeMenu()
        {
            menuLayoutControl = new MenuLayoutControl
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(menuLayoutControl);

            var userMenu = new Dictionary<string, List<(string, UserControl)>>
            {
                ["Sales"] = new List<(string, UserControl)>(),
                ["View Stock"] = new List<(string, UserControl)>(),
                ["Search customer"] = new List<(string, UserControl)>()
            };

            // Define main content controls that don't have submenus
            var userMainMap = new Dictionary<string, UserControl>
            {
                ["Sales"] = new SalesControl(),
                ["View Stock"] = new ViewStockControl(),
                ["Search customer"] = new SearchCustomerControl()
            };

            menuLayoutControl.LoadLayout(userMenu, userMainMap);
        }
    }
}
