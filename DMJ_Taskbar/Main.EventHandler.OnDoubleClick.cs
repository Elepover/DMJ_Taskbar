using System;
using System.Windows;

namespace DMJ_Taskbar
{
    public partial class Main
    {
        public void OnDoubleClick(object sender, EventArgs e)
        {
            if (Application.Current.MainWindow.Visibility == Visibility.Visible)
            {
                Application.Current.MainWindow.Visibility = Visibility.Hidden;
            }
            else
            {
                Application.Current.MainWindow.Visibility = Visibility.Visible;
            }
            UpdateIconText();
        }
    }
}
