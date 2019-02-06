using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileMedico.Views
{
    public partial class RecoverPasswordPage : ContentPage
    {
        public RecoverPasswordPage()
        {
            InitializeComponent();

            logo.Source = Device.OnPlatform(
            Android: "logo.png",
            iOS: "logo.png",
            WinPhone: null);
        }

        public async void OnSendEmailClicked(object sender, EventArgs e)
        {


            try
            {
                if (!string.IsNullOrEmpty(username.Text)  && username.TextColor != Color.Red)
                {
                    //IUserDialogs Dialogs = UserDialogs.Instance;
                    //Dialogs.ShowLoading("Loading...");
                    //await Task.Delay(2000);

                    //Dialogs.HideLoading();

                    Device.OpenUri(new Uri("http://xamarin.com"));
                   


                }
              

                else
                {
                    await DisplayAlert("Log In", "Verify the Information", "OK");
                }

            }

            catch (Exception ex)
            {
                //await DisplayAlert("Log In", "User not Found", "OK");
                await DisplayAlert("Log In", ex.Message, "OK");
            }

        }
    }
}
