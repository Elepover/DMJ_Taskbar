using BilibiliDM_PluginFramework;

namespace DMJ_Taskbar
{
    public partial class Main : DMPlugin
    {
        public void OnDisconnected(object sender, DisconnectEvtArgs e)
        {
            Vars.ConnectionState = false;
        }
    }
}
