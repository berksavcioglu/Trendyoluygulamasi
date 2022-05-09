using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Hesabim : ContentPage
    {
        public Hesabim()
        {
            InitializeComponent();
        }
        private void RouteLogingPage(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }
    }
}