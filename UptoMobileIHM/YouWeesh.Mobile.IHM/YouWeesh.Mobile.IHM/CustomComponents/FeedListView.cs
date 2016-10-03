using System;
using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
	public class FeedListView : ListView
	{
		public FeedListView(ListViewCachingStrategy strategy):base(strategy)
		{
			
				
		}

		public event EventHandler Scroll;
		public event EventHandler StopScroll;


		public void OnScroll()
		{
			if (Scroll != null)
				Scroll(this, null);
		}

		public void OnStopScroll()
		{
			if (StopScroll != null)
				StopScroll(this, null);
		}

	}
}
