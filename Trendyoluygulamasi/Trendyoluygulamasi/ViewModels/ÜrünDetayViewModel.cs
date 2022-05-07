using System;
using System.Collections.Generic;
using System.Text;
using Trendyoluygulamasi.Data;
using Trendyoluygulamasi.Models;
using Xamarin.Forms;

namespace Trendyoluygulamasi.ViewModels
{
    public class ÜrünDetayViewModel : BaseViewModel
    {
        public ÜrünDetayViewModel()
        {
            AddProductToCart = new Command((product) =>
            {
                CartData.AddProduct((Ürünmodel)product);

            });
        }
        public Command AddProductToCart { get; }
    }
}
