using NavModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace NavModule
{
    public class NavModuleModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("NavRegion", typeof(NavView));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
