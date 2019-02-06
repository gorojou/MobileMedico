using Acr.UserDialogs;
using MobileMedico.Models;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileMedico.Views
{
    public partial class LoginPage : ContentPage
    {
      //  IUserDialogs Dialogs = UserDialogs.Instance;
        Doctor doctorlogin = new Doctor();
        public LoginPage()
        {
            InitializeComponent();
            
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            logo.Source = Device.OnPlatform(
               Android: "logo.png",
               iOS: "logo.png",
               WinPhone: null);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        }


        public async void OnLogInClicked(object sender, EventArgs e)
        {
           

            try
            {
                if (!string.IsNullOrEmpty(username.Text) && !string.IsNullOrEmpty(password.Text) && username.TextColor != Color.Red)
                {
                    //Dialogs.ShowLoading("Loading...");
                    await Task.Delay(2000);

                    Repository repository = new Repository();



                    if (CrossConnectivity.Current.IsConnected == false)
                    {
                        await DisplayAlert("Log In", "Internet Issues", "Ok");
                      //  Dialogs.HideLoading();
                        return;
                    }
                 //  Dialogs.HideLoading();
                    Doctor docValid = repository.LogIn(doctorlogin);


                    if (docValid.ID_DOCTOR != 0)
                    {
                        App.Current.Properties["DOCTOR"] = docValid;
                        App.IsLoggedIn = true;
                        var vHomePage = new HomePage();
                        Navigation.InsertPageBefore(vHomePage, this);
                        await Navigation.PopAsync();
                        Device.BeginInvokeOnMainThread(async () =>
                            {
                                await Navigation.PushModalAsync(new HomePage());
                            });


                    }
                    else
                    {
                        await DisplayAlert("Log In", "User not Found", "OK");
                        return;
                    }

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

        public  void OnRecoveryPasswordClicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                await Navigation.PushModalAsync(new RecoverPasswordPage());
            });

        }
    }
}
