using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.Data;
using Trendyoluygulamasi.ViewModels;
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
            MessagingCenter.Subscribe<Üründetay, bool>(this, "MakeVisible", (sender, value) => {
                SepetList.IsVisible = value;
                BosList.IsVisible = !value;
            });
            if (SepetData.IsNotEmpty())
            {
                ChangeCartVisibilty();
            }
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
        private void RouteLogingPage(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }
    }
}