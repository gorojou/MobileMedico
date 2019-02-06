using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileMedico.CustomRenderer
{
    public class MyLabel : Label
    {
        public MyLabel()
        {
            TextColor = Color.White;
            HorizontalOptions = LayoutOptions.Center;
            FontSize = 64;
        }
    }
}
