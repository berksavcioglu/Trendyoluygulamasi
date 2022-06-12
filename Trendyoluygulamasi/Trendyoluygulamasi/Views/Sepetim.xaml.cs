using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sepetim : ContentPage
    {
        public Sepetim()
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
        }
    
        private void RouteLogingPage(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }
    }
}