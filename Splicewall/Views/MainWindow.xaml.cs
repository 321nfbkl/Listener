using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Listener
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register<string>(this, "SelectedMenuChanged", str =>
            {
                if (string.IsNullOrEmpty(str))
                    return;
                if (str == "发现音乐")
                    this.FrameNavigate("发现音乐", "Listener.Views.FindMusic.FindMusicView");
                else if (str == "我的音乐")
                    this.FrameNavigate("我的音乐", "OperationSystem.View.DeviceView.DeviceListView");
                else if (str == "关注")
                    this.FrameNavigate("关注", "OperationSystem.View.WarningView.WarningInfoView");
                else if (str == "商城")
                    this.FrameNavigate("商城", "OperationSystem.View.SystemLogs.SystemLogsView");
                else if (str == "音乐人")
                    this.FrameNavigate("音乐人", "OperationSystem.View.AssetManage.NavigateAssetView");
            });
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            GlobalContext.Instance.CurrentMain = this;
            GlobalContext.Instance.VMLocator.MainVM.SelectedMenu = GlobalContext.Instance.VMLocator.MainVM.MenuList.FirstOrDefault(); ;
        }

        public void FrameNavigate(string key, string path)
        {
            try
            {
                if (!this.frame.Resources.Contains(key))
                {
                    if (string.IsNullOrEmpty(path))
                        return;
                    var type = Type.GetType(path);
                    var instance = Activator.CreateInstance(type);
                    this.frame.Resources.Add(key, instance);
                }
                this.frame.Navigate(this.frame.Resources[key]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void frame_Navigating(object sender, NavigatingCancelEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back)
                e.Cancel = true;
        }

        private void WindowClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
