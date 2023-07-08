using Listener.Views.FindMusic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listener
{
    public class GlobalContext
    {
        private static object lockObj = new object();
        private static GlobalContext mInstance;
        public static GlobalContext Instance
        {
            get
            {
                if (mInstance == null)
                {
                    lock (lockObj)
                    {
                        if (mInstance == null)
                        {
                            mInstance = new GlobalContext();
                        }
                    }
                }

                return mInstance;
            }
        }

        /// <summary>
        /// 全局VM管理类
        /// </summary>
        public ViewModel.ViewModelLocator VMLocator { get; set; }

        /// <summary>
        /// 主窗口
        /// </summary>
        public MainWindow CurrentMain { get; set; }
        /// <summary>
        /// 发现音乐窗口
        /// </summary>
        public FindMusicView CurrentFindMusicView { get; set; }
    }
}
