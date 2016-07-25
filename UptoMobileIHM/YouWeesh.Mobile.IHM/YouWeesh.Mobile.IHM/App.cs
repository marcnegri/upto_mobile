using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace YouWeesh.Mobile
{

    public class App : Application
    {
        public App()
        {
            MainPage = new Views.LoginForm();
            MainPage.BackgroundColor = Color.FromRgb(243, 243, 243);
            //var backgroundImage = new Image();
            //backgroundImage.Source = ImageSource.FromFile("model.jpg");
            //MainPage.BackgroundImage = "model.jpg";
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
