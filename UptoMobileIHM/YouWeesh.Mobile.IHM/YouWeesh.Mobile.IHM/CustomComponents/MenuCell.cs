using System;

using Xamarin.Forms;

namespace YouWeesh.Mobile
{
	public class MenuCell : ContentPage
	{
		public MenuCell()
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

