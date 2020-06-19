using CrossStore.Application.Models.ViewModels;
using CrossStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossStoreApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProductPage : ContentPage
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        private void BtnAdd_Clicked(object sender, EventArgs e)
        {
            var name = EntryName.Text;
            var photo = EntryPhoto.Text;
            Decimal price = 0;
            if (!Decimal.TryParse(EntryPrice.Text, out price))
            {
                DisplayAlert("Invalid Price", "Please, type a valid price", "Ok");
                return;
            }
                
            var product = new ProductViewModel
            {
                Name = name,
                Photo = photo,
                Price = price
            };

            App.Service.AddProduct(product);
            Navigation.PopModalAsync(true);
        }

        private void BtnCancel_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }
    }
}