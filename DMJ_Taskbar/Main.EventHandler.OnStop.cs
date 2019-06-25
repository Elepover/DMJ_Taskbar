using BilibiliDM_PluginFramework;
using System;
using System.Windows;

namespace DMJ_Taskbar
{
    public partial class Main : DMPlugin
    {
        public void OnStop(object sender, EventArgs e)
        {
            if (Application.Current.MainWindow.Visibility == Visibility.Hidden)
            {
                Application.Current.MainWindow.Visibility = Visibility.Visible;
            }
            UpdateIconText();
            Stop();
        }
    }
}
