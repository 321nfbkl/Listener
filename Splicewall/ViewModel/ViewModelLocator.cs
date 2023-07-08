

using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Listener.ViewModel.FindMusic;
using Listener.ViewModel.ReCommendView;
using Listener.Views;

namespace Listener.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);


            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<FindMusicViewModel>();
            SimpleIoc.Default.Register<RecommendViewModel>();

            GlobalContext.Instance.VMLocator = this;
        }

        public MainViewModel MainVM
        {
            get=> ServiceLocator.Current.GetInstance<MainViewModel>();
        }

        public FindMusicViewModel FindMusicVM
        {
            get=> ServiceLocator.Current.GetInstance<FindMusicViewModel>();
        }
        
        public RecommendViewModel RecommendVM
        {
            get=>ServiceLocator.Current.GetInstance<RecommendViewModel>();  
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}