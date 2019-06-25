using BilibiliDM_PluginFramework;
using System.Threading;

namespace DMJ_Taskbar
{
    public partial class Main : DMPlugin
    {
        public void Worker()
        {
            while (!Vars.RequestWorkerStop)
            {
                Dispatcher.Invoke(() =>
                {
                    UpdateIconText();
                });
                Thread.Sleep(250);
            }
            Vars.RequestWorkerStop = false;
        }
    }
}
