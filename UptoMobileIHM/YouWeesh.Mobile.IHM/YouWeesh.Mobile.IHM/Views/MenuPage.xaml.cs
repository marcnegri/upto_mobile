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
        public ListView ListView { get { return listView; } }

        public MenuPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "My Weesh",
                IconSource = "contacts.png",
                TargetType = typeof(MyWeeshView)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "My Next Events",
                IconSource = "todo.png",
                TargetType = typeof(MyNextEventsView)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Weesh/Events feed",
                IconSource = "reminders.png",
                TargetType = typeof(FeedView)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Friends",
                IconSource = "todo.png",
                TargetType = typeof(FriendsForm)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Settings",
                IconSource = "settings.png",
                TargetType = typeof(SettingsForm)
            });
            listView.ItemsSource = masterPageItems;

        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                listView.SelectedItem = null;
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
