using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Trendyoluygulamasi.Models;
using System.Linq;
using Trendyoluygulamasi.Data;
using Trendyoluygulamasi.Extensions;
using Xamarin.Forms;

namespace Trendyoluygulamasi.ViewModels
{
    public class SepetimViewModel : BaseViewModel
    {
        ObservableCollection<Sepetmodel> cartProducts;


        public ObservableCollection<Sepetmodel> CartProducts
        {
            get { return cartProducts; }
        }
        ObservableCollection<Ürünmodel> randomProducts;

        public ObservableCollection<Ürünmodel> RandomProducts { get { return randomProducts; } }
        public SepetimViewModel()
        {
            GetShuffleProducts();
            GetCartProduct();
            AddProduct = new Command(
                (product) =>
                {
                    SepetData.AddProduct((Ürünmodel)product);
                    OnPropertyChanged(nameof(CartProducts));
                }

                );

        }

        private void GetShuffleProducts()
        {
            var data = ÜrünData.GetProducts();
            data.Shuffle();
            randomProducts = data;
        }
        private void GetCartProduct()
        {
            cartProducts = SepetData.CreateCart();

        }

        public Command AddProduct { get; set; }

    }
}
