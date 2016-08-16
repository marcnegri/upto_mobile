using System;
using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
	public class TofinoLabel : Label
	{
		public TofinoLabel()
		{
			this.FontFamily = Device.OnPlatform("Tofino-Regular.ttf", null ,null);
		}
	}
}

