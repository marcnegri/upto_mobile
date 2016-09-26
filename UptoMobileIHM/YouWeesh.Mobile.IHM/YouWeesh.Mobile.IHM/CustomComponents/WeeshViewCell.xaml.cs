using System;
using System.Collections.Generic;
using YouWeesh.Mobile.Business;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle.Forms.Plugin.Abstractions;

using Xamarin.Forms;
using YouWeesh.Mobile.Views;

namespace YouWeesh.Mobile.CustomComponents
{
    public partial class WeeshViewCell : ViewCell
    {
		public WeeshViewCell()
		{
			InitializeComponent();

			contentView.SwipeDown += (s, e) =>
			{

			};

			contentView.SwipeTop += (s, e) =>
			{


			};

			contentView.SwipeLeft += (s, e) =>
			{
				/*if (!buttonDelete.IsVisible)
				{
					buttonDelete.IsVisible = true;
					buttonDelete.LayoutTo(new Rectangle(buttonDelete.X, buttonDelete.Y, 80, buttonDelete.Height), 200);
					contentView.BackgroundColor = Color.FromHex("#D3D3D3");
				}*/

			};

			contentView.SwipeRight += (s, e) =>
			{
				/*if (buttonDelete.IsVisible)
				{
					deactivateDeleteButton();

				}*/
				MessagingCenter.Send<WeeshViewCell, int>(this, "WeeshBack", int.Parse(lblId.Text));
				imgProfile.TranslateTo(App.ScreenWidth-80, imgProfile.Y, 200);
				//imgProfile.TranslateTo(imgProfile.X + 280, imgProfile.Y, 200);
				//contentView.LayoutTo(new Rectangle(contentView.X, contentView.Y, contentView.Width - 40, contentView.Height), 200);


			};


			//name.SetBinding(
		}
        private async void deactivateDeleteButton()
        {
            contentView.BackgroundColor = Color.White;
            await buttonDelete.LayoutTo(new Rectangle(buttonDelete.X, buttonDelete.Y, 0, buttonDelete.Height), 200);
            buttonDelete.IsVisible = false;
        }

		async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			await imgProfile.ScaleTo(0.65, 60, Easing.CubicOut);
			await imgProfile.ScaleTo(0.95, 60, Easing.CubicIn);
			MessagingCenter.Send<WeeshViewCell, int>(this, "RedirectToMyProfile", int.Parse(lblId.Text));
			//await this.Navigation.PushModalAsync(new MyProfileView());
			//await this.Navigation.PushAsync(new MyProfileView());

		}

		async void WeeshBackOnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			MessagingCenter.Send<WeeshViewCell, int>(this, "WeeshBack", int.Parse(lblId.Text));
			//App.Current.MainPage.Navigation
			//await this.Navigation.PushModalAsync(new MyProfileView());
			//await this.Navigation.PushAsync(new MyProfileView());

		}
    }
}
