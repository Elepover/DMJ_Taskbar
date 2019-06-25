using BilibiliDM_PluginFramework;

namespace DMJ_Taskbar
{
    public partial class Main : DMPlugin
    {
        public void OnConnected(object sender, ConnectedEvtArgs e)
        {
            Vars.ConnectionState = true;
            Vars.RoomId = e.roomid.ToString();
        }
    }
}
