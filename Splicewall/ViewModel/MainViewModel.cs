using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Documents;
using System.Windows.Input;

namespace Listener.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Properity

        /// <summary>
        /// 主页菜单
        /// </summary>
        public IList<string> MenuList { get; set; }

        private string mSelectedMenu;
        /// <summary>
        /// 选中的菜单
        /// </summary>
        public string SelectedMenu
        {
            get => mSelectedMenu;
            set
            {
                if (Set(ref mSelectedMenu, value))
                {
                    GalaSoft.MvvmLight.Messaging.Messenger.Default.Send<string>(value, "SelectedMenuChanged");
                }
            }
        }

        public IList<string> DataList { get; set; }
        #endregion

        #region Command

        public ICommand SearchCommand { get; set; }
        #endregion
        public MainViewModel()
        {
            this.MenuList = new ObservableCollection<string>();
            this.MenuList.Add("发现音乐");
            this.MenuList.Add("我的音乐");
            this.MenuList.Add("关注");
            this.MenuList.Add("商城");
            this.MenuList.Add("音乐人");

            this.DataList = new ObservableCollection<string>();
            this.MenuList.Add("个人设置");

            this.SearchCommand = new RelayCommand<string>(this.SearchMusic);
        }

        /// <summary>
        /// 搜索音乐
        /// </summary>
        /// <param name="obj"></param>
        private void SearchMusic(string text)
        {
            Console.WriteLine($"搜索的关键词为:{text}");
        }
    }
}