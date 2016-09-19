using System;

using Xamarin.Forms;

namespace YouWeesh.Mobile
{
	public class AddEventForm : ContentPage
	{
		public AddEventForm()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


