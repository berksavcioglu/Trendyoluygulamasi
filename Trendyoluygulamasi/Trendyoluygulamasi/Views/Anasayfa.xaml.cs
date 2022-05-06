
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Anasayfa : ContentPage
    {
        public ICommand ScrollListCommand { get; set; }
        public Anasayfa()
        {
            InitializeComponent();

            List<string> CarouselItems = new List<string>()
        {
            "https://m.media-amazon.com/images/I/517NWUDVktL._SX1500_.jpg",
            "https://m.media-amazon.com/images/I/61WILLsl4RL._SX3000_.jpg",
            "https://images.hepsiburada.net/banners/s/0/672-378/bannerImage2134_20220429192734.jpeg/format:webp",
            "https://images.hepsiburada.net/banners/s/0/672-378/bannerImage2158_20220428134947.jpeg/format:webp",
            "https://mcdn01.gittigidiyor.net/ps/hero_banner_2496x760_annelergunu_1650966907.jpg?type=homepage-banner-1&index=1",

         };
            Carouselürün.ItemsSource = CarouselItems;
        }
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new LoginPage());
        }

        
    }
}