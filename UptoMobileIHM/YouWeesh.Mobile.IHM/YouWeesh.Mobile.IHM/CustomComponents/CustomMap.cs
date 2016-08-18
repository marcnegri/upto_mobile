using System;
using Xamarin.Forms.Maps;
using System.Collections.Generic;

namespace YouWeesh.Mobile.CustomComponents
{
	public class CustomMap : Map
	{
		public List<CustomPin> CustomPins { get; set; }

		public CustomMap()
		{
			
		}
	}

	public class CustomPin
	{
		public Pin Pin { get; set; }
		public string Id { get; set; }
		public string Url { get; set; }
	}
}

