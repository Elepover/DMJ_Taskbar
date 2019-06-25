using System.Threading;
using System.Windows.Forms;
using System.Windows.Threading;
using BilibiliDM_PluginFramework;
using DMJ_Taskbar.Properties;

namespace DMJ_Taskbar
{
    public partial class Main : DMPlugin
    {
        public NotifyIcon Icon;
        public ContextMenu Strip;

        private bool _inited = false;

        public Main()
        {
            PluginAuth = "Elepover";
            PluginCont = "elepover@outlook.com";
            PluginDesc = "在任务栏通知区域创建一个图标以显示/隐藏弹幕姬";
            PluginName = "任务栏助手";
            PluginVer = Vars.AppVer.ToString();
            Connected += OnConnected;
            Disconnected += OnDisconnected;
            ReceivedRoomCount += OnReceivedRoomCount;
        }

        public override void Start()
        {
            if (!_inited)
            {
                Log("正在初始化控件");

                // 初始化菜单
                Strip = new ContextMenu();
                Strip.MenuItems.Add(Vars.UnknownMsg);           // 0
                Strip.MenuItems.Add("捐赠 (外部链接)");          // 1
                Strip.MenuItems.Add("关于 (外部链接)");          // 2
                Strip.MenuItems.Add("打开插件面板");             // 3
                Strip.MenuItems.Add("切换弹幕姬可见性");         // 4
                Strip.MenuItems.Add("停用插件");                 // 5
                Strip.MenuItems.Add("退出弹幕姬");               // 6

                // 设置属性并分配事件
                Strip.MenuItems[0].Checked = false;

                Strip.MenuItems[1].Click += OnDonateClick;

                Strip.MenuItems[2].Click += OnAboutClick;

                Strip.MenuItems[3].Click += OnPluginPanelClick;

                Strip.MenuItems[4].Click += OnDoubleClick;
                Strip.MenuItems[4].DefaultItem = true;

                Strip.MenuItems[5].Click += OnStop;

                Strip.MenuItems[6].Click += OnItemExitClick;
                
                // 初始化图标
                Icon = new NotifyIcon
                {
                    Icon = Resources.unknown,
                    Visible = false,
                    Text = Vars.NotifyIconText.Replace("%s", Vars.UnknownIdMsg),
                    ContextMenu = Strip
                };
                Icon.MouseDoubleClick += OnDoubleClick;

                // 初始化线程
                Vars.Worker = new Thread(Worker) { IsBackground = true } ;
                Vars.Worker.Start();

                Log("初始化成功");
                _inited = true;
            }

            Icon.Visible = true;
            Log("已显示通知图标");
            base.Start();
        }

        public override void Stop()
        {
            if (!_inited) { return; }
            Icon.Visible = false;
            Log("已隐藏通知图标");
            base.Stop();
        }

        public override void DeInit()
        {
            if (!_inited) { return; }
            Vars.RequestWorkerStop = true;
            var frame = new DispatcherFrame();
            var thread = new Thread(() =>
            {
                while (Vars.RequestWorkerStop) { Thread.Sleep(250); }
                frame.Continue = false;
            });
            thread.Start();
            Dispatcher.PushFrame(frame);
            Icon.Visible = false;
            base.DeInit();
        }
    }
}
