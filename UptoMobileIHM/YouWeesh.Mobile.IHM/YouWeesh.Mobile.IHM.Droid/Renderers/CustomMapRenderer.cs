using System;
using System.Collections.Generic;
using System.ComponentModel;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using YouWeesh.Mobile.CustomComponents;
using YouWeesh.Mobile.IHM.Droid.Renderers;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace YouWeesh.Mobile.IHM.Droid.Renderers
{
	
	public class CustomMapRenderer : MapRenderer, GoogleMap.IInfoWindowAdapter, IOnMapReadyCallback
	{
		GoogleMap map;
		List<CustomPin> customPins;
		bool isDrawn;

		protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null)
			{
				map.InfoWindowClick -= OnInfoWindowClick;
			}

			if (e.NewElement != null)
			{
				var formsMap = (CustomMap)e.NewElement;
				customPins = formsMap.CustomPins;
				((MapView)Control).GetMapAsync(this);
			}
		}

		public void OnMapReady(GoogleMap googleMap)
		{
			map = googleMap;
			map.InfoWindowClick += OnInfoWindowClick;
			map.SetInfoWindowAdapter(this);
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);

			if (e.PropertyName.Equals("VisibleRegion") && !isDrawn && map != null)
			{
				map.Clear();

				foreach (var pin in customPins)
				{
					var marker = new MarkerOptions();
					marker.SetPosition(new LatLng(pin.Pin.Position.Latitude, pin.Pin.Position.Longitude));
					marker.SetTitle(pin.Pin.Label);
					marker.SetSnippet(pin.Pin.Address);

					if (pin.Pin.Label == "Marcus")
					{
						marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.portrait2_marker));
					}
					else
					{
						marker.SetIcon(BitmapDescriptorFactory.FromResource(Resource.Drawable.portrait4_marker));
					}


					map.AddMarker(marker);
				}
				isDrawn = true;
			}
		}

		protected override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			base.OnLayout(changed, l, t, r, b);

			if (changed)
			{
				isDrawn = false;
			}
		}

		void OnInfoWindowClick(object sender, GoogleMap.InfoWindowClickEventArgs e)
		{
			var customPin = GetCustomPin(e.Marker);
			if (customPin == null)
			{
				throw new Exception("Custom pin not found");
			}

			if (!string.IsNullOrWhiteSpace(customPin.Url))
			{
				var url = Android.Net.Uri.Parse(customPin.Url);
				var intent = new Intent(Intent.ActionView, url);
				intent.AddFlags(ActivityFlags.NewTask);
				Android.App.Application.Context.StartActivity(intent);
			}
		}

		public Android.Views.View GetInfoContents(Marker marker)
		{
			var inflater = Android.App.Application.Context.GetSystemService(Context.LayoutInflaterService) as Android.Views.LayoutInflater;
			if (inflater != null)
			{
				Android.Views.View view;

				var customPin = GetCustomPin(marker);
				if (customPin == null)
				{
					throw new Exception("Custom pin not found");
				}

				if (customPin.Id == "Event")
				{
					view = inflater.Inflate(Resource.Layout.EventMapInfoWindow, null);
				}
				else {
					view = inflater.Inflate(Resource.Layout.UserMapInfoWindow, null);
				}

				var infoTitle = view.FindViewById<TextView>(Resource.Id.InfoWindowTitle);
				var infoMultiLine = view.FindViewById<EditText>(Resource.Id.textMultiLine);
				var imageView = view.FindViewById<ImageView>(Resource.Id.imageView);


				if (infoTitle != null)
				{
					infoTitle.Text = marker.Title;
				}
				if (infoMultiLine != null)
				{
					//infoMultiLine.Text = marker.Snippet;
					if (customPin.Pin.Label == "Marcus")
					{
						infoMultiLine.Text = "- J'ai envie de jouer au #foot\n- Motivé pour un #tennis\n - Faire une partie de #pétanque";
						imageView.SetImageResource(Resource.Drawable.portrait2_marker);
					
					}
					else
					{
						infoMultiLine.Text = "- Motivée pour la #Zumba\n- Envie de faire un #tennis\n - Envie de se défouler en faisant un petit #running";
						imageView.SetImageResource(Resource.Drawable.portrait4_marker);
					}

				}

				return view;
			}
			return null;
		}

		public Android.Views.View GetInfoWindow(Marker marker)
		{
			return null;
		}

		CustomPin GetCustomPin(Marker annotation)
		{
			var position = new Position(annotation.Position.Latitude, annotation.Position.Longitude);
			foreach (var pin in customPins)
			{
				if (pin.Pin.Position == position)
				{
					return pin;
				}
			}
			return null;
		}
	}
}

