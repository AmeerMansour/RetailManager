using Caliburn.Micro;
using RetailManagerWpfUserInterface.ViewModels;
using RetailManagerWpfUserInterface.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RetailManagerWpfUserInterface
{
    public class Bootstrapper : BootstrapperBase
    {

        #region Fields



        #endregion

        #region Properties



        #endregion

        #region Constructors

        public Bootstrapper()
        {
            Initialize();
        }

        #endregion

        #region Methods

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }

        #endregion

    }
}