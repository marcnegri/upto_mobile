using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YouWeesh.Mobile;
using YouWeesh.Mobile.Views;
using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
	public partial class AddFloatingButton : ContentView
	{
		public AddFloatingButton()
		{
			InitializeComponent();
		}

		async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			cimFab.BackgroundColor = Color.Transparent;
			await cimFab.ScaleTo(0.65, 60, Easing.CubicOut);
			await cimFab.ScaleTo(0.80, 60, Easing.CubicIn);

			await this.Navigation.PushModalAsync(new AddWeeshForm());

		}
		/*
		void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{

			var imageSender = (Image)sender;
		}*/
	}
}

