using Caliburn.Micro;
using ManpowerApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManpowerApp
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {

        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }
    }
}
