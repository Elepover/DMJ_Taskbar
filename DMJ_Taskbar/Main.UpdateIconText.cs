using BilibiliDM_PluginFramework;
using DMJ_Taskbar.Properties;

namespace DMJ_Taskbar
{
    public partial class Main : DMPlugin
    {
        public void UpdateIconText()
        {
            try
            {
                if (Vars.ConnectionState)
                {
                    Strip.MenuItems[0].Checked = true;
                    Strip.MenuItems[0].Text = Vars.ConnectedMsg.Replace("%s", Vars.RoomId.ToString());
                    Icon.Text = Vars.NotifyIconText.Replace("%s", Vars.ConnectedMsg.Replace("%s", Vars.RoomId.ToString()));
                    Icon.Icon = Resources.online;
                }
                else
                {
                    Strip.MenuItems[0].Checked = false;
                    Strip.MenuItems[0].Text = Vars.DisconnectedMsg;
                    Icon.Text = Vars.NotifyIconText.Replace("%s", Vars.DisconnectedMsg);
                    Icon.Icon = Resources.offline;
                }
            }
            catch { }
        }
    }
}
