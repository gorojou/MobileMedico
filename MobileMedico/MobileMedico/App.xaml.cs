using MobileMedico.ViewModels;
using MobileMedico.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileMedico
{
    public partial class App : Application
    {
        public static bool IsLoggedIn { get; set; }
        public App()
        {
            InitializeComponent();
            IsLoggedIn = false;
            var page = new LoginPage();
            //var page = new HomePage();
            MainPage = new NavigationPage(page);
            //if (IsLoggedIn)
            //{ MainPage = new NavigationPage(new HomePage()); }
            //else MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static class ViewModelLocator
        {
            static MainChatViewModel chatVM;
            public static MainChatViewModel MainChatViewModel
            {
                get
                {
                    if (chatVM == null)
                    {
                        chatVM = new MainChatViewModel();
                        chatVM.InitializeMock();
                    }
                    return chatVM;

                }
            }

        }
    }

}
