using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile.Business;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace YouWeesh.Mobile.Views
{
	public partial class MyNextEventsView : ContentPage
	{
        ObservableCollection<Business.Events> events = new ObservableCollection<Business.Events>();
        public MyNextEventsView ()
		{
			InitializeComponent ();

            #region Events MOCKS
            events.Add(new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", Location = "Centre sportif du bout du monde"});
            events.Add(new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" });
            events.Add(new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" });
            events.Add(new Business.Events { Title = "Drinking", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Pickwick Bar" });
            events.Add(new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" });

            nextEvent.ItemsSource = events;
            #endregion
        }
	}
}
