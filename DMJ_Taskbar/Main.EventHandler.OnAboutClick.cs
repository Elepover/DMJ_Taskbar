using System;
using System.Diagnostics;

namespace DMJ_Taskbar
{
    public partial class Main
    {
        public void OnAboutClick(object sender, EventArgs e)
        {
            Process.Start("https://www.danmuji.org/plugins/DMJ_Taskbar");
        }
    }
}
