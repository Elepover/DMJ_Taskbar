using System;
using System.Windows;
using System.Windows.Controls;

namespace DMJ_Taskbar
{
    public partial class Main
    {
        public void OnPluginPanelClick(object sender, EventArgs e)
        {
            var window = Application.Current.MainWindow;
            if (window.Visibility != Visibility.Visible) { window.Visibility = Visibility.Visible; }
            UpdateIconText();
            TabControl tab = (TabControl)window.FindName("TabControl");
            tab.SelectedIndex = 3;
        }
    }
}
