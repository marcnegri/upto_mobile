using System;
using YouWeesh.Mobile.Views;
using Xamarin.Forms;
using YouWeesh.Mobile.IHM.iOS;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using System.Collections.Generic;

[assembly:ExportRenderer(typeof(FeedView), typeof(FeedViewRenderer))]
namespace YouWeesh.Mobile.IHM.iOS
{
	public class FeedViewRenderer : PageRenderer
	{
		public new FeedView Element
		{
			get { return (FeedView)base.Element; }
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			var LeftNavList = new List<UIBarButtonItem>();
			var rightNavList = new List<UIBarButtonItem>();

			var navigationItem = this.NavigationController.TopViewController.NavigationItem;

			UIBarButtonItem menu = navigationItem.LeftBarButtonItem;
			LeftNavList.Add(menu);
			for (var i = 0; i < Element.ToolbarItems.Count; i++)
			{

				var reorder = (Element.ToolbarItems.Count - 1);
				var ItemPriority = Element.ToolbarItems[reorder - i].Priority;

				if (ItemPriority == 1)
				{
					UIBarButtonItem LeftNavItems = navigationItem.RightBarButtonItems[i];
					LeftNavList.Add(LeftNavItems);
				}
				else if (ItemPriority == 0)
				{
					UIBarButtonItem RightNavItems = navigationItem.RightBarButtonItems[i];
					rightNavList.Add(RightNavItems);
				}
			}

			navigationItem.SetLeftBarButtonItems(LeftNavList.ToArray(), false);
			navigationItem.SetRightBarButtonItems(rightNavList.ToArray(), false);

		}
	}
}

