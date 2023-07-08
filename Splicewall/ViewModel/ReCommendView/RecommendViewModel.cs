using GalaSoft.MvvmLight;
using Listener.Models.BindingModel.Recommend;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener.ViewModel.ReCommendView
{
    public class RecommendViewModel:ViewModelBase
    {
        #region properity
        public IList<PlayListBindingModel> HomePlayList { get; set; }=new ObservableCollection<PlayListBindingModel>();

        public IList<PlayListBindingModel> NewDiscList { get; set; }=new ObservableCollection<PlayListBindingModel>();
        public IList<PlayListBindingModel> TopOfCharts { get; set; }=new ObservableCollection<PlayListBindingModel>();
        public IList<PlayListBindingModel> NewSongsCharts { get; set; }=new ObservableCollection<PlayListBindingModel>();
        public IList<PlayListBindingModel> OriginalCharts { get; set; }=new ObservableCollection<PlayListBindingModel>();
        #endregion

        public RecommendViewModel()
        {
            this.HomePlayList.Add(new PlayListBindingModel() { PlayNums = 2469, PlayTiltle = "[国电新势力] 网易电子音乐人精选",PlaylistCover= "https://p1.music.126.net/K9bA_-ipru1XgW1tHWGDaw==/109951168679285761.jpg?param=177y177" });
            this.HomePlayList.Add(new PlayListBindingModel() { PlayNums = 2469, PlayTiltle = "[国电新势力] 网易电子音乐人精选",PlaylistCover= "https://p1.music.126.net/K9bA_-ipru1XgW1tHWGDaw==/109951168679285761.jpg?param=177y177" });
            this.HomePlayList.Add(new PlayListBindingModel() { PlayNums = 2469, PlayTiltle = "[国电新势力] 网易电子音乐人精选",PlaylistCover= "https://p1.music.126.net/K9bA_-ipru1XgW1tHWGDaw==/109951168679285761.jpg?param=177y177" });

            this.NewDiscList.Add(new PlayListBindingModel() { DiscCover= "https://p1.music.126.net/K9bA_-ipru1XgW1tHWGDaw==/109951168679285761.jpg?param=177y177",DiscSigner="苏诗丁",DiscTitle="生如夏花"});
            this.NewDiscList.Add(new PlayListBindingModel() { DiscCover= "https://p1.music.126.net/K9bA_-ipru1XgW1tHWGDaw==/109951168679285761.jpg?param=177y177",DiscSigner="苏诗丁", DiscTitle = "生如夏花" });
            this.NewDiscList.Add(new PlayListBindingModel() { DiscCover= "https://p1.music.126.net/K9bA_-ipru1XgW1tHWGDaw==/109951168679285761.jpg?param=177y177",DiscSigner="苏诗丁", DiscTitle = "生如夏花" });
            this.NewDiscList.Add(new PlayListBindingModel() { DiscCover= "https://p1.music.126.net/K9bA_-ipru1XgW1tHWGDaw==/109951168679285761.jpg?param=177y177",DiscSigner="苏诗丁", DiscTitle = "生如夏花" });

            for(int i = 1; i <= 5; i++)
            {
                this.TopOfCharts.Add(new PlayListBindingModel() { Index =i,SongName= "凄美地" });
            }
            for (int i = 1; i <= 5; i++)
            {
                this.NewSongsCharts.Add(new PlayListBindingModel() { Index = i, SongName = "笼" });
            }
            for (int i = 1; i <= 5; i++)
            {
                this.OriginalCharts.Add(new PlayListBindingModel() { Index = i, SongName = "爱是" });
            }
        }
    }
}
