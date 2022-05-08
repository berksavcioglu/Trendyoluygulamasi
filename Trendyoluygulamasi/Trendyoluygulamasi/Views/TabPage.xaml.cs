using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trendyoluygulamasi.Views.Login;
using Trendyoluygulamasi.Views.NavigationPages;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trendyoluygulamasi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabPage : TabbedPage
    {
        NavigationBar _hesabimNav;
        AnasayfaNavigation _anasayfaNavigation;
        AnasayfaNavigation _favoriNavigation;
        AnasayfaNavigation _sepetimNavigation;
        ContentPage _hesabim;
        ContentPage _sepetim;
        ContentPage _favorilerim;
        Anasayfa _anasayfa;
        Yemeksayfasi _yemeksayfasi;
        LoginPage _loginPage;

        public TabPage()
        {
            InitializeComponent();
            this.CurrentPageChanged += TabPage_CurrentPageChanged;
            AddPages();
        }
        public void AddPages()
        {
            if (!Preferences.Get("Registered", false))
            {
                _loginPage = new LoginPage();
                _hesabim = new Hesabim();
                _sepetim = new Sepetim();
                _favorilerim = new Favorilerim();
                _loginPage.Title = "Giriş Yap";
            }
            else
            {
                _hesabim = new LoginHesabim();
                _sepetim = new LoginSepetim();
                _favorilerim = new LoginFavorilerim();
            }
            _yemeksayfasi = new Yemeksayfasi();
            _hesabimNav = new NavigationBar(_hesabim);
            _sepetimNavigation = new AnasayfaNavigation(_sepetim);
            _favoriNavigation = new AnasayfaNavigation(_favorilerim);
            _anasayfa = new Anasayfa();
            _anasayfaNavigation = new AnasayfaNavigation(_anasayfa);


            _hesabim.Title = "Hesabım";
            _hesabim.IconImageSource = "hesabim.png";
            _yemeksayfasi.Title = "Trendyol Go";
            _yemeksayfasi.IconImageSource = "go.png";
            _hesabimNav.Title = "Hesabım";
            _hesabimNav.IconImageSource = "hesabim.png";
            _sepetim.IconImageSource = "sepetim.png";
            _sepetim.Title = "Sepetim";
            _sepetimNavigation.Title = "Sepetim";
            _sepetimNavigation.IconImageSource = "sepetim.png";
            _sepetimNavigation.BarTextColor = Color.Black;
            _sepetimNavigation.BarBackgroundColor = Color.FromHex("#ffffff");
            _favorilerim.Title = "Favorilerim";
            _favorilerim.IconImageSource = "kalp.png";
            _favoriNavigation.BarBackgroundColor = Color.White;
            _favoriNavigation.BarTextColor = Color.Black;
            _favoriNavigation.Title = "Favorilerim";
            _favoriNavigation.IconImageSource = "kalp.png";

            _anasayfaNavigation.Title = "Anasayfa";
            _anasayfaNavigation.IconImageSource = "anasayfa.png";

            this.Children.Add(_anasayfaNavigation);
            this.Children.Add(_yemeksayfasi);
            this.Children.Add(_favoriNavigation);
            this.Children.Add(_sepetimNavigation);
            this.Children.Add(_hesabimNav);



        }

        private void TabPage_CurrentPageChanged(object sender, EventArgs e)
        {
            if (this.CurrentPage is NavigationBar && !(Preferences.Get("Registered", false)))
            {
                _hesabim.Navigation.PushModalAsync(_loginPage);

            }
        }
        public void LoadNotLoginPages()
        {


        }
    }
}