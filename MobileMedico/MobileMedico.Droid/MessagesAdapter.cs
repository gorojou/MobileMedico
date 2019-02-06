using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Runtime.Remoting.Messaging;

namespace MobileMedico.Droid
{
    class MessagesAdapter : BaseAdapter<IMessage>
    {
        public MessagesAdapter(Activity parentActivity)
        {
            activity = parentActivity;
        }

        List<IMessage> messages = new List<IMessage>();
        Activity activity;


        public override long GetItemId(int position)
        {
            return position;
        }


        public override Android.Views.View GetView(int position, Android.Views.View convertView, ViewGroup parent)
        {
            var view = convertView as LinearLayout ?? activity.LayoutInflater.Inflate(Resource.Layout.MessageItemLayout, null) as LinearLayout;
            var msg = messages[position];

            //view.FindViewById<TextView>(Resource.Id.authorTextView).Text = msg.Author;
            //view.FindViewById<TextView>(Resource.Id.messageTextView).Text = msg.MessageBody;

            return view;
        }

        public override int Count { get { return messages.Count; } }
        public override IMessage this[int index] { get { return messages[index]; } }

        public void AddMessage(IMessage msg)
        {
            lock (messages)
            {
                messages.Add(msg);
            }

            activity.RunOnUiThread(() =>
               NotifyDataSetChanged());
        }
    }
}