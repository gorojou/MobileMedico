using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedico.Models
{
    public class Message
    {
        string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        DateTime messageDateTime;

        public DateTime MessageDateTime
        {
            get { return messageDateTime; }
            set { messageDateTime=value; }
        }

        public string MessageTimeDisplay => MessageDateTime.Date.ToString();

        bool isIncoming;

        public bool IsIncoming
        {
            get { return isIncoming; }
            set { isIncoming = value; }
        }

        public bool HasAttachement => !string.IsNullOrEmpty(attachementUrl);

        string attachementUrl;

        public string AttachementUrl
        {
            get { return attachementUrl; }
            set { attachementUrl = value; }
        }
    }
}
