using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
	public partial class MessageBoxView : ContentView
	{
		public MessageBoxView()
		{
			InitializeComponent();
			edtMessageBox.TextColor = Color.Gray;

		}

		public void edtMessageBox_Completed(object sender, EventArgs e)
		{
			if (edtMessageBox.Text == "")
			{
				edtMessageBox.Text = "Type a message";
				edtMessageBox.TextColor = Color.Gray;
			}
		}

		public void edtMessageBox_TextChanged(object sender, EventArgs e)
		{
			
		}

		public void edtMessageBox_Focused(object sender, EventArgs e)
		{
			if (edtMessageBox.Text == "Type a message")
			{
				edtMessageBox.Text = "";
				edtMessageBox.TextColor = Color.Black;
			}
		}
	}
}

