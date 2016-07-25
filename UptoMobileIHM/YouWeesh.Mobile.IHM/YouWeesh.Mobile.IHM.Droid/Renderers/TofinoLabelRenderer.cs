using System;
using Xamarin.Forms.Platform.Android;
using YouWeesh.Mobile;
using YouWeesh.Mobile.IHM.Droid;
using YouWeesh.Mobile.CustomComponents;
using Xamarin.Forms;
using Android.Widget;
using Android.Graphics;


[assembly: ExportRenderer (typeof (TofinoLabel), typeof (TofinoLabelRenderer))]
namespace YouWeesh.Mobile.IHM.Droid
{
	public class TofinoLabelRenderer : LabelRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
			var label = (TextView)Control; // for example
			Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "Fonts/Tofino-Regular.ttf");  // font name specified here
			label.Typeface = font;
		}
	}
}

