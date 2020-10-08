using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFEConnectivitySample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //networkState.Text = Connectivity.NetworkAccess.ToString();

            //if (Connectivity.NetworkAccess == NetworkAccess.None)
            //{
            //    networkState.Text = "Please Connect First";
            //}

            Connectivity.ConnectivityChanged += ConnectivityChangedHandler;
        }

        private void ConnectivityChangedHandler(object sender, ConnectivityChangedEventArgs e)
        {
            networkState.Text = e.NetworkAccess.ToString();

            if (!e.ConnectionProfiles.Contains(ConnectionProfile.Bluetooth))
            {
                // TODO Handle Bluetooth
            }
        }
    }
}
