using System;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using YouWeesh.Mobile.CustomComponents;
using YouWeesh.Mobile.IHM.Droid.Renderers;

[assembly: ExportRenderer(typeof(FeedListView), typeof(FeedListViewRenderer))]
namespace YouWeesh.Mobile.IHM.Droid.Renderers
{
	public class FeedListViewRenderer : ListViewRenderer
	{
		public FeedListViewRenderer()
		{

		}


	protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null)
			{
				// unsubscribe
				//Control.ItemClick -= OnItemClick;


			}

			if (e.NewElement != null)
			{
				var listView = this.Control as Android.Widget.ListView;
				listView.ScrollStateChanged += (s, el) =>
				{
					if (el.ScrollState == ScrollState.TouchScroll)
					{
						((FeedListView)e.NewElement).OnScroll();
					}
					if (el.ScrollState == ScrollState.Idle)
					{
						((FeedListView)e.NewElement).OnStopScroll();
					}
				};

				listView.ScrollChange += (s, el) =>
				{

				};



			}
		}
	}
 
}	

