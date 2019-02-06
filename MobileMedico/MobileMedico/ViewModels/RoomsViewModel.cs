using MobileMedico.Helper;
using MobileMedico.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileMedico.ViewModels
{
    public class RoomsViewModel
    {
        ITwilioMessenger twilioMessenger;

        public Command ConnectCommand { get; }

        Page page;

        public RoomsViewModel(Page page)
        {
            this.page = page;
            twilioMessenger = DependencyService.Get<ITwilioMessenger>();

            ConnectCommand = new Command(async () =>
            {
                var IsBusy = true;
                var success = false;
                string message = string.Empty;
                try
                {
                    
                    success = true;
                    var a = twilioMessenger.ToString();
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                finally
                {
                    IsBusy = false;
                }

                if (success)
                {
                    await page.DisplayAlert("Success", "Now joining #general.", "OK");
                    await page.Navigation.PushAsync(new MainChatPage());
                }
                else
                {
                    await page.DisplayAlert("Sad", $"Unable to join #general: {message}", "OK");
                }
            });
        }
    }
}
