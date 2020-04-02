using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EMS2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        void Protocols(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Protocols());
        }
        void Drugs(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Drugs());
        }
        void Hospitals(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Hospitals());
        }
        void SendStat(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SendStat());
        }
        void EMSImaging(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new EMSImaging());
        }
        void Tools(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Tools());
        }
    }
}
