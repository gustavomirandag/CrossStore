using CrossStore.Application.Services;
using CrossStore.Domain.Services;
using CrossStore.Infra.DataAccess.Repositories.Products;
using CrossStoreApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossStoreApp
{
    public partial class App : Application
    {
        public static CrossPlatformAppService Service { get; set; }

        public App()
        {
            InitializeComponent();
            var domainService = new ProductService(new SQLiteProductsRepository(Device.RuntimePlatform));
            Service = new CrossPlatformAppService(domainService);
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
