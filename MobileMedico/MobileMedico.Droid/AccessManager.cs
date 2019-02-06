using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Twilio;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MobileMedico.Droid
{
    class AccessManager
    {
        public void OnTokenExpired(ITwilioAccessManager p0)
        {
            Console.WriteLine("token expired");
        }

        public void OnTokenUpdated(ITwilioAccessManager p0)
        {
            Console.WriteLine("token updated");
        }

        //void JoinGeneralChannel()
        //{
        //    generalChannel.Join(new StatusListener
        //    {
        //        SuccessHandler = () =>
        //        {
        //            RunOnUiThread(() =>
        //               Toast.MakeText(this, "Joined general channel!", ToastLength.Short).Show());
        //        }
        //    });
        //}

        //void CreateAndJoinGeneralChannel()
        //{
        //    var options = new Dictionary<string, Java.Lang.Object>();
        //    options["friendlyName"] = "General Chat Channel";
        //    options["ChannelType"] = ChannelChannelType.ChannelTypePublic;
        //    client.Channels.CreateChannel(options, new CreateChannelListener
        //    {
        //        OnCreatedHandler = channel =>
        //        {
        //            generalChannel = channel;
        //            channel.SetUniqueName("general", new StatusListener
        //            {
        //                SuccessHandler = () => { Console.WriteLine("set unique name successfully!"); }
        //            });
        //            this.JoinGeneralChannel();
        //        },
        //        OnErrorHandler = () => { }
        //    });
        //}

    }
}