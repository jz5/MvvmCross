using System;
using MvvmCross.Core;
using MvvmCross.Platforms.Wpf.Core;
using MvvmCross.Platforms.Wpf.Views;

namespace Playground.Wpf
{
    public partial class App : MvxApplication
    {
        private static App _instace;
        public static App Instance => _instace;

        static App()
        {
            MvxSetup.RegisterSetupType<MvxWpfSetup<Core.App>>();
        }

        App()
        {
            _instace = this;
        }

        public void Activate() => OnActivated(EventArgs.Empty);
    }
}
