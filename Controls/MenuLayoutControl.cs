using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopProject.Controls
{
    public partial class MenuLayoutControl : UserControl
    {
        private Dictionary<string, List<(string title, UserControl control)>> menuMap;
        private Dictionary<string, UserControl> mainMenuContentMap;

        public MenuLayoutControl()
        {
            InitializeComponent();
        }

        public void LoadLayout(
            Dictionary<string, List<(string title, UserControl control)>> menuMap,
            Dictionary<string, UserControl> mainMap)
        {
            this.menuMap = menuMap;
            this.mainMenuContentMap = mainMap;
            RenderMenu();
        }

        private void RenderMenu()
        {
            foreach (var group in menuMap)
            {
                var key = group.Key;
                var subItems = group.Value;

                var mainButton = new Button
                {
                    Text = key,
                    Dock = DockStyle.Top,
                    Height = 40,
                    Tag = key,
                    BackColor = System.Drawing.Color.LightGray
                };
                mainButton.Click += MainButton_Click;
                mainMenuPanel.Controls.Add(mainButton);

                if (subItems.Count > 0)
                {
                    var subPanel = new FlowLayoutPanel
                    {
                        Name = $"sub_{key}",
                        FlowDirection = FlowDirection.TopDown,
                        AutoSize = true,
                        Visible = false
                    };

                    foreach (var (title, control) in subItems)
                    {
                        var subButton = new Button
                        {
                            Text = "   " + title,
                            Width = 180,
                            Height = 30,
                            Tag = (title, control)
                        };
                        subButton.Click += SubButton_Click;
                        subPanel.Controls.Add(subButton);
                    }

                    subMenuPanel.Controls.Add(subPanel);
                }
            }

            // Auto load nội dung đầu tiên
            if (menuMap.Count > 0)
            {
                var firstMainKey = new List<string>(menuMap.Keys)[0];

                // Tìm và kích hoạt nút menu chính đầu tiên
                foreach (Control control in mainMenuPanel.Controls)
                {
                    if (control is Button btn && (string)btn.Tag == firstMainKey)
                    {
                        // Set style for selected main menu button
                        ApplyButtonStyle(btn, ButtonStyles.Selected);

                        if (menuMap[firstMainKey].Count > 0)
                        {
                            var firstSubMenu = menuMap[firstMainKey][0];
                            LoadContent(firstSubMenu.control);

                            foreach (Control subControl in subMenuPanel.Controls)
                            {
                                if (subControl is FlowLayoutPanel subPanel && subPanel.Name == $"sub_{firstMainKey}")
                                {
                                    subPanel.Visible = true;

                                    // Tìm và đánh dấu nút submenu đầu tiên
                                    foreach (Control subBtn in subPanel.Controls)
                                    {
                                        if (subBtn is Button subButton)
                                        {
                                            ApplyButtonStyle(subButton, ButtonStyles.SelectedSubMenu);
                                            break;
                                        }
                                    }
                                }
                                else if (subControl is FlowLayoutPanel otherPanel)
                                {
                                    otherPanel.Visible = false;
                                }
                            }
                        }
                        // Nếu không có submenu, load nội dung chính
                        else if (mainMenuContentMap.ContainsKey(firstMainKey))
                        {
                            LoadContent(mainMenuContentMap[firstMainKey]);
                        }
                        break;
                    }
                }
            }
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            string key = (string)clickedButton.Tag;

            foreach (Control control in mainMenuPanel.Controls)
            {
                if (control is Button btn)
                {
                    ApplyButtonStyle(btn, ButtonStyles.Default);
                }
            }

            ApplyButtonStyle(clickedButton, ButtonStyles.Selected);

            if (menuMap.ContainsKey(key) && menuMap[key].Count > 0)
            {
                // Có submenu → hiện/ẩn
                bool shouldShow = false;
                foreach (Control control in subMenuPanel.Controls)
                {
                    if (control is FlowLayoutPanel panel)
                    {
                        if (panel.Name == $"sub_{key}")
                        {
                            shouldShow = !panel.Visible;
                            panel.Visible = shouldShow;

                            // Nếu đang hiện, chọn submenu đầu tiên
                            if (shouldShow && panel.Controls.Count > 0 && panel.Controls[0] is Button firstSubButton)
                            {
                                // Reset style for all submenu buttons
                                foreach (Control subPanel in subMenuPanel.Controls)
                                {
                                    if (subPanel is FlowLayoutPanel panelControl)
                                    {
                                        SelectAllButtonsInPanel(panelControl, ButtonStyles.Default);
                                    }
                                }

                                ApplyButtonStyle(firstSubButton, ButtonStyles.SelectedSubMenu);

                                // Load content for first submenu
                                if (firstSubButton.Tag is ValueTuple<string, UserControl> subItem)
                                {
                                    LoadContent(subItem.Item2);
                                }
                            }
                        }
                        else
                        {
                            panel.Visible = false;
                        }
                    }
                }
            }
            else
            {
                // Không có submenu → ẩn tất cả submenu và load nội dung chính
                foreach (Control control in subMenuPanel.Controls)
                {
                    if (control is FlowLayoutPanel panel)
                        panel.Visible = false;
                }

                if (mainMenuContentMap.ContainsKey(key))
                {
                    LoadContent(mainMenuContentMap[key]);
                }
                else
                {
                    contentPanel.Controls.Clear();
                    contentPanel.Controls.Add(new Label
                    {
                        Text = "Chưa có nội dung",
                        Dock = DockStyle.Fill,
                        TextAlign = System.Drawing.ContentAlignment.MiddleCenter
                    });
                }
            }
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            if (!(clickedButton.Tag is ValueTuple<string, UserControl> subItem))
                return;

            var control = subItem.Item2;

            // Reset style for all submenu buttons
            foreach (Control subPanel in subMenuPanel.Controls)
            {
                if (subPanel is FlowLayoutPanel panel)
                {
                    SelectAllButtonsInPanel(panel, ButtonStyles.Default);
                }
            }

            ApplyButtonStyle(clickedButton, ButtonStyles.SelectedSubMenu);

            LoadContent(control);
        }

        private void SetSubButtonSelected(string key)
        {
            var subPanel = FindSubMenuPanel(key);
            if (subPanel != null)
            {
                // SelectAllButtonsInPanel(subPanel, ButtonStyles.SelectedSubMenu);
            }
        }

        private FlowLayoutPanel FindSubMenuPanel(string key)
        {
            foreach (Control control in subMenuPanel.Controls)
            {
                if (control is FlowLayoutPanel panel && panel.Name == $"sub_{key}")
                {
                    return panel;
                }
            }
            return null;
        }

        private void SelectAllButtonsInPanel(FlowLayoutPanel panel, ButtonStyles style)
        {
            foreach (Control subBtn in panel.Controls)
            {
                if (subBtn is Button subButton)
                {
                    ApplyButtonStyle(subButton, style);
                }
            }
        }

        private void ApplyButtonStyle(Button button, ButtonStyles style)
        {
            switch (style)
            {
                case ButtonStyles.Selected:
                    ChangeStyleButtonSelected(button, System.Drawing.Color.SteelBlue, System.Drawing.Color.White);
                    break;
                case ButtonStyles.SelectedSubMenu:
                    ChangeStyleButtonSelected(button, System.Drawing.Color.CornflowerBlue, System.Drawing.Color.White);
                    break;
                case ButtonStyles.Default:
                    ChangeStyleButtonSelected(button, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.ControlText);
                    break;
            }
        }

        private enum ButtonStyles
        {
            Selected,
            SelectedSubMenu,
            Default
        }

        private void ChangeStyleButtonSelected(Button button, Color color, Color textColor)
        {
            button.BackColor = color;
            button.ForeColor = textColor;
        }

        private void LoadContent(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }
    }
}
