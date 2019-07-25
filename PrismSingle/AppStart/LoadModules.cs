using NavModule;
using ContentModule;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismSingle.AppStart
{
    class LoadModules
    {
        public void Init(IModuleCatalog moduleCatalog)
        {
            var NavModule = typeof(NavModuleModule);

            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = NavModule.Name,
                ModuleType = NavModule.AssemblyQualifiedName,
                InitializationMode = InitializationMode.WhenAvailable
            });

            var ContentModule = typeof(ContentViewModule);

            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = ContentModule.Name,
                ModuleType = ContentModule.AssemblyQualifiedName,
                InitializationMode = InitializationMode.OnDemand
            });
        }
    }
}
