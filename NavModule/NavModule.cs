using ContentModule.ViewModels;
using ContentModule.Views;
using NavModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace NavModule
{
    public class NavModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("NavRegion", typeof(Nav));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
