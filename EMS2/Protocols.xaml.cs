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
            if (popupLayout.IsVisible==false)
            {
                popupLayout.IsVisible = true;
            }
            else
            {
                popupLayout.IsVisible = false;
            }
            //popupLayout.ForceLayout();
        }
        void Button2(object sender, System.EventArgs e)
        {
            if (popupLayout2.IsVisible == false)
            {
                popupLayout2.IsVisible = true;
            }
            else
            {
                popupLayout2.IsVisible = false;
            }
            //popupLayout.ForceLayout();
        }
    }
}
