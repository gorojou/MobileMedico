using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileMedico.CustomRenderer
{
    public class MyButton : Button
    {
        public MyButton()
        {
            // BackgroundColor = Color.FromHex("#D55B0F");
            HorizontalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Center;
            WidthRequest = 1000;
            TextColor = Color.FromHex("#000000");
            BorderRadius = 0;
            BorderColor = Color.Transparent;
            TextColor = Color.FromHex("#FFFFFF");
        }
    }
}
