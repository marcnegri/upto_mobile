using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile.Views;

using Xamarin.Forms;
using System.Diagnostics;
using YouWeesh.Mobile.Business;

namespace YouWeesh.Mobile.CustomComponents
{
    public partial class NotificationsViewCell : ViewCell
    {

		public NotificationsViewCell()
		{
			InitializeComponent();
		}

		/*
		public event EventHandler<TappedEventArgs> TappedToto;

		public void HandleTappedEvent(object sender, TappedEventArgs args) // catches TextChanged to Entry (MyENry)
		{
			var handle = TappedToto;

			if (handle != null)
			{
				handle(sender, args);
			}
		}

		public void RelativeLayoutOnTapGestureRecognizerTapped(object sender, TappedEventArgs args) // catches TextChanged to Entry (MyENry)
		{
			//MessagingCenter.Send<EventsViewCell, int>(this, "RedirectToEventDetails", int.Parse(lblId.Text));
		}

		public void ImageOnTapGestureRecognizerTapped(object sender, TappedEventArgs args) // catches TextChanged to Entry (MyENry)
		{
			//MessagingCenter.Send<EventsViewCell, int>(this, "RedirectToMyProfile", int.Parse(lblId.Text));
		}

		async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			//await imgProfile.ScaleTo(0.65, 60, Easing.CubicOut);
			//await imgProfile.ScaleTo(0.95, 60, Easing.CubicIn);
			//MessagingCenter.Send<EventsViewCell, int>(this, "RedirectToMyProfile", int.Parse(lblId.Text));
			//await this.Navigation.PushModalAsync(new MyProfileView());
			//await this.Navigation.PushAsync(new MyProfileView());
		}*/
    }
}
