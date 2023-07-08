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

namespace Listener.Views.FindMusic
{
    /// <summary>
    /// FindMusicView.xaml 的交互逻辑
    /// </summary>
    public partial class FindMusicView : UserControl
    {
        public FindMusicView()
        {
            InitializeComponent();
            Loaded += FindMusicView_Loaded;
            GalaSoft.MvvmLight.Messaging.Messenger.Default.Register<string>(this, "SelectedFindMusicMenuChanged", str =>
            {
                if (string.IsNullOrEmpty(str))
                    return;
                if (str == "推荐")
                    this.FrameNavigate("推荐", "Listener.Views.FindMusic.RecommendView");
                else if (str == "排行榜")
                    this.FrameNavigate("排行榜", "OperationSystem.View.DeviceView.DeviceListView");
                else if (str == "歌单")
                    this.FrameNavigate("歌单", "OperationSystem.View.WarningView.WarningInfoView");
                else if (str == "主播电台")
                    this.FrameNavigate("主播电台", "OperationSystem.View.SystemLogs.SystemLogsView");
                else if (str == "歌手")
                    this.FrameNavigate("歌手", "OperationSystem.View.AssetManage.NavigateAssetView");
                else if (str == "新碟上架")
                    this.FrameNavigate("新碟上架", "");
            });
        }

        private void FindMusicView_Loaded(object sender, RoutedEventArgs e)
        {
            GlobalContext.Instance.CurrentFindMusicView = this;
            GlobalContext.Instance.VMLocator.FindMusicVM.SelectedFindMusicMenu = "推荐";
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
    }
}
