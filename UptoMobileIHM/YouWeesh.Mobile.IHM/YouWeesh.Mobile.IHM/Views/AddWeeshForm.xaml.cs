using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
	public partial class AddWeeshForm : ContentPage
	{
		public AddWeeshForm()
		{
			InitializeComponent();
		}

		public void btnAddWeesh_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
			//this.Navigation.PushModalAsync(new Views.WeeshesTesst());
		}
	}
}

