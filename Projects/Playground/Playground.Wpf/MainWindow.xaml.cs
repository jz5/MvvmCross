using System.Windows;
using MvvmCross;
using MvvmCross.ViewModels;

namespace Playground.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // When using SplashScreen, force to activate application for initialization.
            Loaded += (_, __) => App.Instance.Activate();
        }
    }
}
