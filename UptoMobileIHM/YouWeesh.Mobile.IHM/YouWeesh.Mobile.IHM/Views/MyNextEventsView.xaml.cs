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
            events.Add(new Business.Events { Title = "Tennis", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg" });
            events.Add(new Business.Events { Title = "Tennis", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg" });
            //weeshes.Add(new Weesh { Title = "Jouer au #foot", Creator = "Vince", Image = "weesh.png" });
        }
	}
}
