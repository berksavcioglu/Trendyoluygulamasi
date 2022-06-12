using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.Data;
using Trendyoluygulamasi.Extensions;

using Trendyoluygulamasi.Models;
using Trendyoluygulamasi.Services;
using Xamarin.Forms;

namespace Trendyoluygulamasi.ViewModels
{
    public class SiparisViewModel : BaseViewModel
    {
        ObservableCollection<Sepetmodel> cartProducts;
      
        private decimal sumOfCart = 0;
        public decimal SumOfCart
        {
            get
            {
                return sumOfCart;
            }
            set
            {
                sumOfCart = value;
                OnPropertyChanged(nameof(SumOfCart));
            }
        }
        public ObservableCollection<Sepetmodel> CartProducts
        {
            get { return cartProducts; }
        }
        ObservableCollection<Ürünmodel> randomProducts;
        private void GetShuffleProducts()
        {
            var data = ÜrünData.GetProducts();
            data.Shuffle();
            randomProducts = data;
        }
        private void GetCartProduct()
        {
            cartProducts = SepetData.CreateCart();
            OnPropertyChanged(nameof(SumOfCart));


        }
        public SiparisViewModel()
        {
            GetCartProduct();
            UpdateCartCost();
        }
        public void UpdateCartCost()
        {
            SumOfCart = 0;
            foreach (var item in CartProducts)
            {

                SumOfCart += item.Product.Fiyatı * item.Count;
            }
        }
        
    }
}