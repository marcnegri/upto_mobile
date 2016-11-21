using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class MenuPage : MasterDetailPage
    {
		public ListView ListView { get { return lstLeftMenu; } }

        public MenuPage()
        {
            InitializeComponent();
			//ctnHeader.BackgroundColor = Color.FromRgb(252, 113, 2);// Color.FromRgb(49, 159, 212);
            var masterPageItems = new List<MasterPageItem>();

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Weesh place",
				IconSource = "weeshplace.png",
				TargetType = typeof(FeedView)
			});

			masterPageItems.Add(new MasterPageItem
			{
				Title = "My Next Events",

				IconSource = "date.png",
				TargetType = typeof(MyNextEventsView)
			});

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Notifications",
				IconSource = "icoNotifications.png",
				TargetType = typeof(NotificationsView)
			});

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Profile",
				IconSource = "contacts.png",
				TargetType = typeof(MyProfileView)
			});

            masterPageItems.Add(new MasterPageItem
            {
                Title = "Friends",
                IconSource = "Friends.png",
                TargetType = typeof(FriendsForm)
            });

			masterPageItems.Add(new MasterPageItem
			{
				Title = "Settings",
				IconSource = "settings72.png",
				TargetType = typeof(SettingsForm)
			});

			/*
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Log out",
				IconSource = "logOut.png",
				TargetType = typeof(LoginForm)
			});*/

			lstLeftMenu.ItemsSource = masterPageItems;
            NavigationPage p = new NavigationPage(new FeedView());
			p.BarBackgroundColor = Color.FromRgb(252, 113, 2);
			Detail = p;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType))
                {
                    BarBackgroundColor = Color.FromRgb(252, 113, 2)//Color.FromRgb(49, 159, 212)
                };
                lstLeftMenu.SelectedItem = null;
                IsPresented = false;
            }
        }
    }

    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }

}
