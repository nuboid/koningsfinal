﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KoningsApp.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginContentPage : ContentPage
    {
        public LoginContentPage()
        {
            InitializeComponent();
        }

        private void OkCancelContentView_OnClickedCancel(object sender, EventArgs e)
        {
           
        }

        private void OkCancelContentView_OnClickedOK(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1ContentPage());
        }
    }
}