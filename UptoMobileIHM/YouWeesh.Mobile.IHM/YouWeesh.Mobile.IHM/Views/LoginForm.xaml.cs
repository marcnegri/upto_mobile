using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle.Forms.Plugin.Abstractions;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class LoginForm : ContentPage
    {
        public LoginForm()
        {
            this.BackgroundColor = Color.White;
            InitializeComponent();
            imgWeesh.Aspect = Aspect.AspectFit;

            int photoSize = Device.OnPlatform(50, 50, 80);
            var photo = new CircleImage
            {
                WidthRequest = photoSize,
                HeightRequest = photoSize,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = "weesh72.png"
            };

            //photo.Source = "google32.png";

            stk.Children.Add(photo);
        }

        public void Entry_Focused(object sender, EventArgs e)
        {
            ((Entry)sender).Text = "";
        }

        async void BtnTwitter_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }

        public void btnLogin_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.MenuPage());
            //this.Navigation.PushModalAsync(new Views.WeeshesTest());
        }

        public void btnRegister_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.RegisterForm());
        }
    }
}
