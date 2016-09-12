using System;
using Xamarin.Forms;
using YouWeesh.Mobile.Business;

namespace YouWeesh.Mobile.CustomComponents
{
	class FeedViewTemplateSelector : Xamarin.Forms.DataTemplateSelector
	{
		public FeedViewTemplateSelector()
		{
			// Retain instances!
			this.eventDataTemplate = new DataTemplate(typeof(EventsViewCell));
			this.weeshDataTemplate = new DataTemplate(typeof(WeeshViewCell));
			this.weeshBackDataTemplate = new DataTemplate(typeof(WeeshBackViewCell));
		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var element = item as Business.Element;
			if (element == null)
				return null;
			return element.IsEvent ? this.eventDataTemplate : element.IsWeeshBacked ? this.weeshBackDataTemplate : this.weeshDataTemplate;
		}

		private readonly DataTemplate eventDataTemplate;
		private readonly DataTemplate weeshDataTemplate;
		private readonly DataTemplate weeshBackDataTemplate;
	}
}

