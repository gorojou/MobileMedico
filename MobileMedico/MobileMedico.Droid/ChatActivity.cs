using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Twilio.Common;
using Twilio.IPMessaging;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Graphics;
using Android.Content;
using static Android.Net.Wifi.P2p.WifiP2pManager;
using System.Runtime.Remoting.Channels;
using MobileMedico;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace MobileMedico.Droid
{
    [Activity(Label = "MobileMedico", Icon = "@drawable/logo", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]

    //IPMessagingClientListener, IChannelListener, ITwilioAccessManagerListener

    public class ChatActivity : Activity
    {
        internal const string TAG = "CHAT";

        Android.Widget.Button sendButton;
        EditText textMessage;
        Android.Widget.ListView listView;
        MessagesAdapter adapter;

        ITwilioIPMessagingClient client;
        IChannel generalChannel;

        protected async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.ActionBar.Subtitle = "logging in...";
            var activity = this.ApplicationContext as Activity;
            activity.SetContentView(Resource.Layout.MessageItemLayout);
            
            // SetContentView(Resource.Layout.MessageItemLayout);

            sendButton = FindViewById<Android.Widget.Button>(Resource.Id.sendButton);
            textMessage = FindViewById<EditText>(Resource.Id.messageTextField);
            listView = FindViewById<Android.Widget.ListView>(Resource.Id.listView);

            adapter = new MessagesAdapter(this);
            listView.Adapter = adapter;

            //sendButton.Click = ButtonSend_Click;


            base.OnCreate(savedInstanceState);

            //TwilioIPMessagingSDK.SetLogLevel((int)Android.Util.LogPriority.Debug);

            //if (!TwilioIPMessagingSDK.IsInitialized)
            //{
            //    Console.WriteLine("Initialize");

            //    TwilioIPMessagingSDK.InitializeSDK(this, new InitListener
            //    {
            //        InitializedHandler = async delegate
            //        {
            //            await Setup();
            //        },
            //        ErrorHandler = err =>
            //        {
            //            Console.WriteLine(err.Message);
            //        }
            //    });
            //}
            //else
            //{
            //    await Setup();
            //}


        }

 

    async Task<string> GetIdentity()
        {
            var androidId = Android.Provider.Settings.Secure.GetString(ContentResolver,
                                Android.Provider.Settings.Secure.AndroidId);

            
            var tokenEndpoint = $"http://doctorwebservice.azurewebsites.net/api/GenerateChatToken?device={androidId}";

            var http = new HttpClient();
            var data = await http.GetStringAsync(tokenEndpoint);
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            // var json = System.Json.JsonObject.Parse(data);
            var identity = androidId;
             // var identity = json["identity"]?.ToString()?.Trim('"');
             this.ActionBar.Subtitle = $"Logged in as {identity}";
            var token = json;
            //var token = json["token"]?.ToString()?.Trim('"');

            return token;
        }

        //async Task Setup()
        //{
        //    var token = await GetIdentity();
        //    var accessManager = TwilioAccessManagerFactory.CreateAccessManager(token, this);
        //    client = TwilioIPMessagingSDK.CreateIPMessagingClientWithToken(accessManager, this);

        //    client.Channels.LoadChannelsWithListener(new StatusListener
        //    {
        //        SuccessHandler = () =>
        //        {
        //            generalChannel = client.Channels.GetChannelByUniqueName("general");

        //            if (generalChannel != null)
        //            {
        //                generalChannel.Listener = this;
        //                JoinGeneralChannel();
        //            }
        //            else
        //            {
        //                CreateAndJoinGeneralChannel();
        //            }
        //        }
        //    });
        //}

    public class CreateChannelListener
        {
            public Action<IChannel> OnCreatedHandler { get; set; }
            public Action OnErrorHandler { get; set; }

            //public override void OnCreated(IChannel channel)
            //{
            //    OnCreatedHandler?.Invoke(channel);
            //}

            //public override void OnError(IErrorInfo errorInfo)
            //{
            //    base.OnError(errorInfo);
            //}
        }

        //void ButtonSend_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrWhiteSpace(textMessage.Text))
        //    {
        //        var msg = generalChannel.Messages.CreateMessage(textMessage.Text);

        //        generalChannel.Messages.SendMessage(msg, new StatusListener
        //        {
        //            SuccessHandler = () =>
        //            {
        //                RunOnUiThread(() =>
        //                {
        //                    textMessage.Text = string.Empty;
        //                });
        //            }
        //        });
        //    }
        //}


    
        public void OnMessageAdd(IMessage message)
        {
            adapter.AddMessage(message);
            listView.SmoothScrollToPosition(adapter.Count - 1);
        }

    }

    internal interface ITwilioIPMessagingClient
    {
    }
}