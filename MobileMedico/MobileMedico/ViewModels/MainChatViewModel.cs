using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using System.Globalization;
using static Android.App.Notification.MessagingStyle;
using MobileMedico.Helper;

namespace MobileMedico.ViewModels
{
    public class MainChatViewModel 
    {
     //   public ObservableRangeCollection<Message> Messages { get; }
        Helper.ITwilioMessenger twilioMessenger;

        string outgoingText = string.Empty;

        public string OutGoingText
        {
            get { return outgoingText; }
           // set { SetProperty(ref outgoingText, value); }
        }

        public ICommand SendCommand { get; set; }


        public ICommand LocationCommand { get; set; }

        public MainChatViewModel()
        {
            // Initialize with default values
            twilioMessenger = DependencyService.Get<ITwilioMessenger>();



           // Messages = new ObservableRangeCollection<Message>();

            SendCommand = new Command(() =>
            {
                //var message = new Message
                //{
                //    Text = OutGoingText,
                //    IsIncoming = false,
                //    MessageDateTime = DateTime.Now
                //};


                //Messages.Add(message);

                //twilioMessenger?.SendMessage(message.Text);

                //OutGoingText = string.Empty;
            });




            if (twilioMessenger == null)
                return;

            //twilioMessenger.MessageAdded = (message) =>
            //{
            //    Messages.Add(message);
            //};
        }


        public void InitializeMock()
        {
            //Messages.ReplaceRange(new List<Message>
            //    {
                   
            //});
        }
    }
}
