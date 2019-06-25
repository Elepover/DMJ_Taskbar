using BilibiliDM_PluginFramework;

namespace DMJ_Taskbar
{
    public partial class Main : DMPlugin
    {
        public void OnReceivedRoomCount(object sender, ReceivedRoomCountArgs e)
        {
            if (Vars.ConnectionState) { return; }
            Vars.ConnectionState = true;
            Vars.RoomId = Vars.UnknownIdMsg;
        }
    }
}
