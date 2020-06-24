using System;
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyNewProject.Data.Orders;
using MyNewProject.Framework.DataSources;
using MyNewProject.UI.Orders.ViewModels;
using MyNewProject.UI.Orders.Views;
using MyNewProject.UseCases.Orders;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace MyNewProject
{
    public partial class App
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.Register<OrdersRepository>();
            containerRegistry.Register<IOrdersSource, InMemoryOrdersSource>();
            containerRegistry.Register<GetCurrentUserOrders>();
        }
    }
}
