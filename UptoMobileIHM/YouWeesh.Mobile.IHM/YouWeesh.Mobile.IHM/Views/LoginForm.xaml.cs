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
           // this.BackgroundColor = Color.White;
            InitializeComponent();
            //imgWeesh.Aspect = Aspect.AspectFit;

			//normalFab.SizeChanged += (sender, args) => { layout.ForceLayout(); };
        }

        public void Entry_Focused(object sender, EventArgs e)
        {
            ((Entry)sender).Text = "";
        }

        async void BtnTwitter_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }

        async void btnLogin_Clicked(object sender, EventArgs e)
        {
			await imgLogginButton.ScaleTo(0.80, 60, Easing.CubicOut);
			await imgLogginButton.ScaleTo(1, 60, Easing.CubicIn);
            this.Navigation.PushModalAsync(new Views.MenuPage());
            //this.Navigation.PushModalAsync(new Views.WeeshesTesst());
        }

        public void btnRegister_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.RegisterForm());
        }
    }
}
