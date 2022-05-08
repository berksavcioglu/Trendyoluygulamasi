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
    public partial class KayitOl : ContentPage
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        private void ChooseGender(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var text = button.Text;
            if (text == "Kadın")
            {
                Kadın.BackgroundColor = Color.FromHex("#ffffff");
                Kadın.BorderColor = Color.FromHex("#f27f26");
                button.TextColor = Color.FromHex("#f38836");
                SetDefault("Erkek");
            }
            else if (text == "Erkek")
            {
                Erkek.BackgroundColor = Color.FromHex("#ffffff");
                Erkek.BorderColor = Color.FromHex("#f27f26");
                button.TextColor = Color.FromHex("#f38836");
                SetDefault("Kadın");
            }
        }
        private void SetDefault(string gender)
        {
            if (gender == "Kadın")
            {
                Kadın.BackgroundColor = Color.FromHex("#f6f6f6");
                Kadın.BorderColor = Color.Transparent;
                KadınButton.TextColor = Color.FromHex("#8a8a8a");
            }
            else if (gender == "Erkek")
            {
                Erkek.BackgroundColor = Color.FromHex("#f6f6f6");
                Erkek.BorderColor = Color.Transparent;
                ErkekButton.TextColor = Color.FromHex("#8a8a8a");
            }
        }

        private void campaign_checkbox(object sender, EventArgs e)
        {
            if (!kampanyabox.IsChecked)
            {
                kampanyabox.BoxBackgroundColor = Color.White;
            }
            else
            {
                kampanyabox.Color = Color.FromHex("#f27a1c");
                kampanyabox.IconColor = Color.White;

            }
        }

        private void RouteLoginPage(object sender, EventArgs e)
        {
            this.Navigation.PopModalAsync();
        }
    }
}