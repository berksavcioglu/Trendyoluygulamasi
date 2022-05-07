using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Trendyoluygulamasi.Data;
using Trendyoluygulamasi.Models;
using System.Linq;
using Trendyoluygulamasi.Extensions;


namespace Trendyoluygulamasi.ViewModels
{
    public class AnasayfaViewModel : BaseViewModel
    {
        
        ObservableCollection<Ürünmodel> randomProducts;
        ObservableCollection<Ürünmodel> randomProductsMan;
        public ObservableCollection<Ürünmodel> RandomProducts { get { return randomProducts; } }
        public ObservableCollection<Ürünmodel> RandomProductsMan { get { return randomProductsMan; } }
        public AnasayfaViewModel()
        {
            Title = "About";
            randomProducts = new ObservableCollection<Ürünmodel>();
            randomProductsMan = new ObservableCollection<Ürünmodel>();
            GetRandomProducts(randomProducts);
            GetRandomProducts(RandomProductsMan);
        }
        public void GetRandomProducts(ObservableCollection<Ürünmodel> _randomProducts)
        {
            var data = ÜrünData.GetProducts();
            data.Shuffle();
            var data2 = data.Where(p => p.ÜrünId > 0 && p.ÜrünId < 20);
            foreach (var item in data2)
            {
                _randomProducts.Add(item);
            }

        }
       
    }
    
}