using System;
using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
	public class RobotoLabel : Label
	{
		public RobotoLabel()
		{
			this.FontFamily = Device.OnPlatform("Roboto-Regular.ttf", null ,null);
		}
	}
}

