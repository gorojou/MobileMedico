using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileMedico.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            this.BackgroundImage = "Menu700x1500";
            this.BackgroundColor = Color.FromRgba(0, 0, 0, 0.7);
            this.Opacity = 0.7;
        }

        public async void OnClickProfile(object sender, EventArgs e)
        {
            
        }
        public async void OnClickLogout(object sender, EventArgs e)
        {
            var MyAppsFirstPage = new LoginPage();
            Xamarin.Forms.Application.Current.MainPage = new NavigationPage(MyAppsFirstPage);
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync(); //Remove the page currently on top.
            Xamarin.Forms.Application.Current.Properties.Clear();
        }
    }
}
