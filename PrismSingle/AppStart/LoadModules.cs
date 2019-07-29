using ContentModule;
using Prism.Modularity;

namespace PrismSingle.AppStart
{
    class LoadModules
    {
        public void Init(IModuleCatalog moduleCatalog)
        {
            var NavModule = typeof(NavModule.NavModule);

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
