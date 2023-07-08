using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener.Models.BindingModel.Recommend
{
    public class PlayListBindingModel:NotifyObject
    {

        private string mPlaylistCover;
        /// <summary>
        /// 歌单封面
        /// </summary>
        public string PlaylistCover
        {
            get => this.mPlaylistCover;
            set => Set(ref this.mPlaylistCover, value);
        }

        private string mPlayTiltle;
        /// <summary>
        /// 歌单标题
        /// </summary>
        public string PlayTiltle
        {
            get => this.mPlayTiltle;
            set => Set(ref this.mPlayTiltle, value);
        }

        private int mPlayNums;
        /// <summary>
        /// 歌单播放数
        /// </summary>
        public int PlayNums
        {
            get => this.mPlayNums;
            set => Set(ref this.mPlayNums, value);
        }

        private string mDiscCover;
        /// <summary>
        /// 新碟标题
        /// </summary>
        public string DiscCover
        {
            get => this.mDiscCover;
            set => Set(ref this.mDiscCover, value);
        }

        private string mDiscSigner;
        /// <summary>
        /// 新碟歌手
        /// </summary>
        public string DiscSigner
        {
            get => this.mDiscSigner;
            set => Set(ref this.mDiscSigner, value);
        }

        private string mDiscTitle;
        /// <summary>
        /// 新碟歌手
        /// </summary>
        public string DiscTitle
        {
            get => this.mDiscTitle;
            set => Set(ref this.mDiscTitle, value);
        }

        private int mIndex;
        /// <summary>
        /// 歌曲排名
        /// </summary>
        public int Index
        {
            get => this.mIndex;
            set => Set(ref this.mIndex, value);
        }

        private string mSongName;
        /// <summary>
        /// 歌曲名称
        /// </summary>
        public string SongName
        {
            get => this.mSongName;
            set => Set(ref this.mSongName, value);
        }
    }
}
