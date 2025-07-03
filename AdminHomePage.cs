using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MobileShopProject.Controls;

namespace MobileShopProject
{
    public partial class AdminHomePage : Form
    {
        private MenuLayoutControl menuLayoutControl;

        public AdminHomePage()
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

            var adminMenu = new Dictionary<string, List<(string, UserControl)>>
            {
                ["Add"] = new List<(string, UserControl)>
                {
                    ("Company", new AddCompanyControl()),
                    ("Model", new AddModelControl()),
                    ("Mobile", new AddMobileControl()),
                },
                ["Update Stock"] = new List<(string, UserControl)>(),
                ["Sales Report"] = new List<(string, UserControl)>
                {
                    ("Day", new SaleReportDayControl()),
                    ("Date to Date", new SaleReportRangeControl())
                },
                ["Employee"] = new List<(string, UserControl)>()
            };

            // Define main content controls that don't have submenus
            var adminMainMap = new Dictionary<string, UserControl>
            {
                ["Update Stock"] = new UpdateStockControl(),
                ["Employee"] = new AddEmployeeControl()
            };

            menuLayoutControl.LoadLayout(adminMenu, adminMainMap);
        }
    }
}
