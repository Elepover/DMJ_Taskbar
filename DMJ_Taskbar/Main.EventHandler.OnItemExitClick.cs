using System;

namespace DMJ_Taskbar
{
    public partial class Main
    {
        public void OnItemExitClick(object sender, EventArgs e)
        {
            System.Windows.Application.Current.MainWindow.Close();
        }
    }
}
