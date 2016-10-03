using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
	public partial class MenuCell : ViewCell
	{
		public MenuCell()
		{
			InitializeComponent();
			lblMenuTitle.TextColor = Color.FromRgb(252, 113, 2);
		}
	}
}
