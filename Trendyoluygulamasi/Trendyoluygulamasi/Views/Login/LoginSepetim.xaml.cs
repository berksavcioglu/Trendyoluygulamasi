using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.Data;
using Trendyoluygulamasi.ViewModels;
using Trendyoluygulamasi.Views.NavigationPages;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginSepetim : ContentPage
    {
        public LoginSepetim()
        {
            InitializeComponent();
            InitiliazeMessagingCenters();
            SetCartButton();
            MessagingCenter.Subscribe<Üründetay, bool>(this, "MakeVisible", (sender, value) => {
                SepetList.IsVisible = value;
                BosList.IsVisible = !value;
            });
            if (SepetData.IsNotEmpty())
            {
                ChangeCartVisibilty();
            }
        }
        private void InitiliazeMessagingCenters()
        {
            
#pragma warning disable CS1998 // Zaman uyumsuz yöntemde 'await' işleçleri yok ve zaman uyumlu çalışacak
            MessagingCenter.Subscribe<Siparis, bool>(this, "OrderCompleted", async (sender, value) =>
            {
                var context = (LoginSepetimViewModel)BindingContext;
                context.UpdateCartCost();
                
                    SepetList.IsVisible = false;
                    CostFlexLayout.IsVisible = false;
                    BosList.IsVisible = true;
                



            });
#pragma warning restore CS1998 // Zaman uyumsuz yöntemde 'await' işleçleri yok ve zaman uyumlu çalışacak
        }
        private void VisibilityClick(object sender, EventArgs e)
        {
            ChangeCartVisibilty();
        }

        private void ChangeCartVisibilty()
        {
            BosList.IsVisible = false;
            SepetList.IsVisible = true;
            CostFlexLayout.IsVisible = true;
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            var data = (LoginSepetimViewModel)BindingContext;
            if (data.SumOfCart == 0)
            {
                SepetList.IsVisible = false;
                CostFlexLayout.IsVisible = false;
                BosList.IsVisible = true;
            }
        }
        private void Click_Continue_to_Order(object sender, EventArgs e)
        {
            if (!Preferences.Get("Registered", false))
            {
                App.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
            else
            {
                App.Current.MainPage.Navigation.PushModalAsync(new ÜrünNavigation(new Siparis()));
            }
        }
        private void SetCartButton()
        {
            if (!Preferences.Get("Registered", false))
            {
                CartPageButton.Text = "Giriş Yap";
            }
            else
            {
                CartPageButton.Text = "Alışverişe Devam Et";
            }
        }
      
        private void RouteLogingPage(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }
       
    }
}