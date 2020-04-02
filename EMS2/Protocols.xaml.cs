using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace EMS2
{
    public partial class Protocols : ContentPage
    {
        public Protocols()
        {
            InitializeComponent();
        }
        async void Button(object sender, System.EventArgs e)
        {
            await DisplayAlert((sender as Button).Text, "Here are the protocols", "Close");
        }
    }
}
