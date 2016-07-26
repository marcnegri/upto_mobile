using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Android;

namespace YouWeesh.Mobile.IHM.Droid
{
    [Activity(Label = "YouWeesh", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Theme = "@style/CustomTheme")]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {

        readonly string[] PermissionsLocation =
        {
            Manifest.Permission.AccessCoarseLocation,
            Manifest.Permission.AccessFineLocation
        };

        const int RequestLocationId = 0;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            if ((int)Build.VERSION.SdkInt >= 23)
            {

                const string permission = Manifest.Permission.AccessFineLocation;
                if (CheckSelfPermission(permission) != (int)Permission.Granted)
                {
                    RequestPermissions(PermissionsLocation, RequestLocationId);

                }
                
            }
            global::Xamarin.Forms.Forms.Init(this, bundle);
            global::Xamarin.FormsMaps.Init(this, bundle);
            ImageCircleRenderer.Init();
			App.ScreenWidth = (int)(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density);
			App.ScreenHeight = (int)(Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density);
            LoadApplication(new App());
        }
    }
}

