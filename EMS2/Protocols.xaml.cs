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
        void Button(object sender, System.EventArgs e)
        {
            if (popupLayout.IsVisible == false)
            {
                popupLayout.IsVisible = true;
                scrollLayout.IsVisible = true;
            }
            else
            {
                popupLayout.IsVisible = false;
                scrollLayout.IsVisible = false;
            }
        }
        void Button2(object sender, System.EventArgs e)
        {
            if (popupLayout2.IsVisible == false)
            {
                popupLayout2.IsVisible = true;
                scrollLayout2.IsVisible = true;
            }
            else
            {
                popupLayout2.IsVisible = false;
                scrollLayout2.IsVisible = true;
            }
        }
        void Button3(object sender, System.EventArgs e)
        {
            if (popupLayout3.IsVisible == false)
            {
                popupLayout3.IsVisible = true;
                scrollLayout3.IsVisible = true;
            }
            else
            {
                popupLayout3.IsVisible = false;
                scrollLayout3.IsVisible = true;
            }
        }
    }
}
