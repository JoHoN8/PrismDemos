using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using PrismSingle.Views;
using NavModule;
using System.Windows;
using PrismSingle.AppStart;

namespace PrismSingle
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }

        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell(Window win)
        {
            
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            var modLoader = new LoadModules();
            modLoader.Init(moduleCatalog);

        }

    }
}
