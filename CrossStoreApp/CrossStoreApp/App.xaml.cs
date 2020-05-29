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
        public static ProductService Service { get; set; }

        public App()
        {
            InitializeComponent();
            Service = new ProductService(new SQLiteProductsRepository(Device.RuntimePlatform));
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
