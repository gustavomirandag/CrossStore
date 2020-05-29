using CrossStore.Domain.Entities;
using CrossStore.Domain.Services;
using CrossStore.Infra.DataAccess.Repositories.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CrossStoreApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            ListProducts(App.Service.GetAllProducts());
        }

        private void ListProducts(IEnumerable<Product> products)
        {

            foreach(var product in products)
            {
                var lblName = new Label
                {
                    //Text = product.Name + " - " + product.Price
                    Text = $"{product.Name} - {product.Price}"
                };
                StackLayoutProducts.Children.Add(lblName);
            }
        }

        private void BtAddProduct_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddProductPage(), true);
        }
    }
}
