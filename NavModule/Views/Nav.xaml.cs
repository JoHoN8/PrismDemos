using ContentModule.Views;
using NavModule.enums;
using Prism.Commands;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace NavModule.Views
{
    /// <summary>
    /// Interaction logic for NavView.xaml
    /// </summary>
    public partial class Nav : UserControl
    {
        protected IModuleManager _moduleManager;

        public IContainerExtension _container { get; private set; }
        public IRegion _region;

        private Red _red { get; set; }
        private Green _green { get; set; }
        private Blue _blue { get; set; }

        public Nav(IModuleManager moduleManager, IContainerExtension container, IRegionManager regionManager)
        {
            InitializeComponent();
            _container = container;

            _region = regionManager.Regions["ContentRegion"];

            _red = _container.Resolve<Red>();
            _green = _container.Resolve<Green>();
            _blue = _container.Resolve<Blue>();

            _region.Add(_blue);
            _region.Deactivate(_blue);
            _region.Add(_red);
            _region.Add(_green);

            _moduleManager = moduleManager;
            _moduleManager.LoadModule("ContentViewModule");
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            closeView();
            _region.Activate(_red);
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            closeView();
            _region.Activate(_blue);
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            closeView();
            _region.Activate(_green);
        }

        private void closeView()
        {
            var useableView = _region.ActiveViews.ToList();

            _region.Deactivate(useableView[0]);
        }
    }
}
