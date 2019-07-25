using ContentModule.Views;
using NavModule.enums;
using Prism.Modularity;
using Prism.Regions;
using System.Windows;
using System.Windows.Controls;

namespace NavModule.Views
{
    /// <summary>
    /// Interaction logic for NavView.xaml
    /// </summary>
    public partial class NavView : UserControl
    {
        protected IModuleManager _moduleManager;
        protected IRegionManager _regionManager;
        protected ContentViews _buttonClicked;
        public NavView(IModuleManager moduleManager, IRegionManager regoingManager)
        {
            InitializeComponent();
            _moduleManager = moduleManager;
            _regionManager = regoingManager;

            _moduleManager.LoadModule("ContentViewModule");
        }

        private void EleCrashReport_click(object sender, RoutedEventArgs e)
        {
            _buttonClicked = ContentViews.BlueView;
            viewLoader();
        }

        private void FrLetterError_click(object sender, RoutedEventArgs e)
        {
            _buttonClicked = ContentViews.RedView;
            viewLoader();
        }

        private void PurgeErrors_click(object sender, RoutedEventArgs e)
        {
            _buttonClicked = ContentViews.GreenView;
            viewLoader();
        }
        private void viewLoader()
        {

            switch (_buttonClicked)
            {
                case ContentViews.RedView:
                    _regionManager.RequestNavigate(
                    "ContentRegion",
                    typeof(Red).FullName);
                    break;
                case ContentViews.GreenView:
                    _regionManager.RequestNavigate(
                    "ContentRegion",
                    typeof(Green).FullName);
                    break;
                case ContentViews.BlueView:
                    _regionManager.RequestNavigate(
                    "ContentRegion",
                    typeof(Blue).FullName);
                    break;
                default:
                    break;
            }
        }
    }
}
