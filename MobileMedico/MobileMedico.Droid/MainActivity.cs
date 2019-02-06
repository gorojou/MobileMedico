using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Twilio;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;
using Android.Content;
using static Android.Net.Wifi.P2p.WifiP2pManager;
using System.Runtime.Remoting.Channels;

namespace MobileMedico.Droid
{
    [Activity(Label = "MobileMedico", Icon = "@drawable/logo", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation) ]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {







        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            //UserDialogs.Init();

            base.OnCreate(bundle);


            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
        protected override void OnNewIntent(Intent intent)
        {
            base.OnNewIntent(intent);
            this.Intent = intent;
        }



    }
}


