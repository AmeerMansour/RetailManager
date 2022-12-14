using Caliburn.Micro;
using RetailManagerWpfUserInterface.ViewModels;
using RetailManagerWpfUserInterface.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RetailManagerWpfUserInterface
{
    public class Bootstrapper : BootstrapperBase
    {

        #region Fields

        SimpleContainer _container;

        #endregion

        #region Properties



        #endregion

        #region Constructors

        public Bootstrapper()
        {
            _container = new SimpleContainer();
            Initialize();
        }

        #endregion

        #region Methods

        protected override void Configure()
        {
            _container.Instance(_container);
            _container
                .Singleton<IWindowManager, WindowManager>()
                .Singleton<IEventAggregator, EventAggregator>();

            GetType().Assembly.GetTypes().Where(type => type.IsClass && type.Name.EndsWith("ViewModel")).ToList()
                .ForEach(viewmodelType => _container.RegisterPerRequest(viewmodelType, viewmodelType.ToString(), viewmodelType));
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewForAsync<ShellViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return _container.GetInstance(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return _container.GetAllInstances(service);
        }

        protected override void BuildUp(object instance)
        {
            _container.BuildUp(instance);
        }

        #endregion

    }
}