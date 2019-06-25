using System;
using System.Diagnostics;

namespace DMJ_Taskbar
{
    public partial class Main
    {
        public void OnDonateClick(object sender, EventArgs e)
        {
            Process.Start("https://daily.elepover.com/donate/");
        }
    }
}
