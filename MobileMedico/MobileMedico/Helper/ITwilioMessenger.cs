using MobileMedico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileMedico.Helper
{
    public class ITwilioMessenger
    {


        Action<Message> MessageAdded { get; set; }
    }
}
