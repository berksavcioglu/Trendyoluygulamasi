
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Siparis : ContentPage
    {
        public Siparis()
        {
            InitializeComponent();
         

        }
        private void ClickBackButton(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopModalAsync(false);
        }

        private async void Click_Continue_to_Order(object sender, EventArgs e)
        {
            await DisplayAlert("Sipariş Durumu", "Sipariş Alınmıştır", "Bitir");
            await App.Current.MainPage.Navigation.PopModalAsync();
            MessagingCenter.Send<Siparis, bool>(this, "OrderCompleted", true);


        }
        
    }
}