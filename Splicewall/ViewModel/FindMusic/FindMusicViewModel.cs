using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener.ViewModel.FindMusic
{
    public class FindMusicViewModel : ViewModelBase
    {
        #region Property
        /// <summary>
        /// 发现音乐菜单
        /// </summary>
        public IList<string> FindMusicMenuList { get; set; }

        private string mSelectedFindMusicMenu;
        /// <summary>
        /// 选中的发现音乐菜单
        /// </summary>
        public string SelectedFindMusicMenu
        {
            get => mSelectedFindMusicMenu;
            set
            {
                if (Set(ref mSelectedFindMusicMenu, value))
                {
                    GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<string>(value, "SelectedFindMusicMenuChanged");
                }
            }
        }
        #endregion

        public FindMusicViewModel()
        {
            this.FindMusicMenuList = new ObservableCollection<string>();
            this.FindMusicMenuList.Add("推荐");
            this.FindMusicMenuList.Add("排行榜");
            this.FindMusicMenuList.Add("歌单");
            this.FindMusicMenuList.Add("主播电台");
            this.FindMusicMenuList.Add("歌手");
            this.FindMusicMenuList.Add("新碟上架");
        }
    }
}
