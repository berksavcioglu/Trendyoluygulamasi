using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Üründetay : ContentPage
    {
        readonly private Ürünmodel _product;

        public Üründetay(object product)
        {
            InitializeComponent();
            _product = (Ürünmodel)product;
            ProductArea.BindingContext = _product;
        }

        private void ClickBackButton(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(false);
        }
        private void ClickCartButton(object sender, EventArgs e)
        {
            MessagingCenter.Send<Üründetay, bool>(this, "MakeVisible", true);
        }
    }
}