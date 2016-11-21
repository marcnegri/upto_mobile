using System;
using System.Collections.Generic;
using YouWeesh.Mobile.Business;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace YouWeesh.Mobile
{
	public partial class NotificationsView : ContentPage
	{
		ObservableCollection<Notifications> notifications = new ObservableCollection<Notifications>();
		public NotificationsView()
		{
			InitializeComponent();
			notifications.Add(new Notifications { Message = "00:12 - Teddy backed your Weesh", RelatedObject="Play #Tennis on a dry court in the sun, with", Type="WeeshBack", ProfilePicture="portrait4.png", ActionPicture="weeshBackOrange.png" });
			notifications.Add(new Notifications { Message = "00:54 - Jon added you as a friend", RelatedObject = "See Jons's profile, Weesh, Weesh back and events", Type = "WeeshBack", ProfilePicture = "portrait3.png", ActionPicture="notifFriend.png" });
			notifications.Add(new Notifications { Message = "04:38 - Event is coming tomorrow, Don't forget it", RelatedObject = "Les trails EDF de Rousset Serre Ponçon", Type = "WeeshBack" , ProfilePicture = "portrait2.png", ActionPicture = "notifReminder.png" });
			notifications.Add(new Notifications { Message = "00:12 - Teddy backed your Weesh", RelatedObject = "Play #Tennis on a dry court in the sun, with", Type = "WeeshBack" , ProfilePicture = "portrait4.png", ActionPicture = "notifWeeshMatching.png" });
			notifications.Add(new Notifications { Message = "00:12 - Teddy backed your Weesh", RelatedObject = "Play #Tennis on a dry court in the sun, with", Type = "WeeshBack" , ProfilePicture = "portrait2.png", ActionPicture = "weeshBackOrange.png" });
			notifications.Add(new Notifications { Message = "00:12 - Teddy backed your Weesh", RelatedObject = "Play #Tennis on a dry court in the sun, with", Type = "WeeshBack" , ProfilePicture = "portrait3.png", ActionPicture = "weeshBackOrange.png" });
			notifications.Add(new Notifications { Message = "00:12 - Teddy backed your Weesh", RelatedObject = "Play #Tennis on a dry court in the sun, with", Type = "WeeshBack", ProfilePicture = "portrait4.png", ActionPicture = "weeshBackOrange.png" });

			vwNotifications.ItemsSource = notifications;
		}
	}
}
