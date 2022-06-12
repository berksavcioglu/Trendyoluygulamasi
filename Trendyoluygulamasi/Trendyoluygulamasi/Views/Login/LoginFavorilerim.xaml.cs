using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginFavorilerim : ContentPage
    {
        public LoginFavorilerim()
        {
            InitializeComponent();
        }
         private void Urungorclick(object sender, EventArgs e)
        {

            this.Navigation.PushModalAsync(new LoginSepetim());
        }
    }
}