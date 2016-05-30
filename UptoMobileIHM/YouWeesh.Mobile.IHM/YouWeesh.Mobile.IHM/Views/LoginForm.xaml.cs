﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile
{
    public partial class LoginForm : ContentPage
    {
        public LoginForm()
        {
            this.BackgroundColor = Color.White;
            InitializeComponent();
        }

        public void Entry_Focused(object sender, EventArgs e)
        {
            ((Entry)sender).Text = "Well Done !";
        }

        async void BtnTwitter_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }

        public void btnLogin_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.HomePage());
        }
    }
}
