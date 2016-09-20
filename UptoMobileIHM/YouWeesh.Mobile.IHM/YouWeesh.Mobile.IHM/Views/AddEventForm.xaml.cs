using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YouWeesh.Mobile
{
	public partial class AddEventForm : ContentPage
	{
		public AddEventForm()
		{
			InitializeComponent();
			this.BackgroundColor = Color.FromHex("#ececec");
		}

		public void edtDescription_Completed(object sender, EventArgs e)
		{
			if (edtDescription.Text == "")
			{
				edtDescription.Text = "Description";
				edtDescription.TextColor = Color.Gray;
			}
		}


		public void edtDescription_Focused(object sender, EventArgs e)
		{
			if (edtDescription.Text == "Description")
			{
				edtDescription.Text = "";
				edtDescription.TextColor = Color.Black;
			}
		}
	}
}

