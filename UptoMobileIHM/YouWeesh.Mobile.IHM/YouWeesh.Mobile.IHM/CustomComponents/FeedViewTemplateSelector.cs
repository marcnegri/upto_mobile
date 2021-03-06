﻿using System;
using Xamarin.Forms;
using YouWeesh.Mobile.Business;

namespace YouWeesh.Mobile.CustomComponents
{
	class FeedViewTemplateSelector : Xamarin.Forms.DataTemplateSelector
	{
		public FeedViewTemplateSelector()
		{
			// Retain instances!
			//fijofiejfoeijeoijoijos
			//this.eventDataTemplate = new DataTemplate(typeof(EventsViewCell));
			this.eventDataTemplate = new DataTemplate(() =>
			{
				var nativeCell = new EventsViewCell(false);
				return nativeCell;
			});

			this.weeshDataTemplate = new DataTemplate(typeof(WeeshViewCell));
			//this.weeshBackDataTemplate = new DataTemplate(typeof(WeeshBackViewCell));
		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var element = item as Business.Element;
			if (element == null)
				return null;
			return element.IsEvent ? this.eventDataTemplate : this.weeshDataTemplate;
		}

		private readonly DataTemplate eventDataTemplate;
		private readonly DataTemplate weeshDataTemplate;
		//private readonly DataTemplate weeshBackDataTemplate;
	}
}

