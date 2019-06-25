using System;
using System.Threading;

namespace DMJ_Taskbar
{
    public static class Vars
    {
        public static string NotifyIconText { get; } = "双击切换弹幕姬显示状态\n连接状态: %s";
        public static string ConnectedMsg { get; } = "已连接到: %s";
        public static string DisconnectedMsg { get; } = "未连接";
        public static string UnknownMsg { get; set; } = "连接状态未知...";
        public static string UnknownIdMsg { get; set; } = "未知";
        public static Version AppVer { get; } = new Version("2.0.2.15");

        public static bool ConnectionState { get; set; } = false;
        public static string RoomId { get; set; } = UnknownIdMsg;
        public static bool RequestWorkerStop { get; set; } = false;
        public static Thread Worker { get; set; }
    }
}
