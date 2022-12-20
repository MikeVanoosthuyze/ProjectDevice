using ProjectDevice.Views;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectDevice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
            Connectivity.ConnectivityChanged += ConnectivityChangedHandler;
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {

            Connectivity.ConnectivityChanged += ConnectivityChangedHandler;
        }

        private void ConnectivityChangedHandler(object sender, ConnectivityChangedEventArgs e)
        {

            if (e.NetworkAccess == NetworkAccess.Internet)
            {
                MainPage = new NavigationPage(new MainPage());
            }
            else
            {
                /*Ga naar NoNetworkPage*/
              MainPage = new NavigationPage(new NoNetworkPage());
            }
        }
    }
}
