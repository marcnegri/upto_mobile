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
			MessagingCenter.Send<AddWeeshForm, String>(this, "NewWeesh", editorWeesh.Text);
			//this.Navigation.PushModalAsync(new Views.WeeshesTesst());
		}

		public void btnCancelWeesh_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
			//MessagingCenter.Send<AddWeeshForm, String>(this, "NewWeesh", editorWeesh.Text);
			//this.Navigation.PushModalAsync(new Views.WeeshesTesst());
		}
	}
}

