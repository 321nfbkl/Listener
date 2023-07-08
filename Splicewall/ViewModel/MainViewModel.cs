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
        /// ��ҳ�˵�
        /// </summary>
        public IList<string> MenuList { get; set; }

        private string mSelectedMenu;
        /// <summary>
        /// ѡ�еĲ˵�
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
            this.MenuList.Add("��������");
            this.MenuList.Add("�ҵ�����");
            this.MenuList.Add("��ע");
            this.MenuList.Add("�̳�");
            this.MenuList.Add("������");

            this.DataList = new ObservableCollection<string>();
            this.MenuList.Add("��������");

            this.SearchCommand = new RelayCommand<string>(this.SearchMusic);
        }

        /// <summary>
        /// ��������
        /// </summary>
        /// <param name="obj"></param>
        private void SearchMusic(string text)
        {
            Console.WriteLine($"�����Ĺؼ���Ϊ:{text}");
        }
    }
}