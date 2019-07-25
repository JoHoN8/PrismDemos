using ContentModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentModule
{
    public class ContentViewModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Blue));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Red));
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(Green));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
