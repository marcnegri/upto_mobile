using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using YouWeesh.Mobile.Business;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class EventDetailsView : ContentPage
    {
        public EventDetailsView()
        {
            InitializeComponent();
			this.BackgroundColor = Color.FromHex("#ececec");
			Title = "Trail des Roussets";
			ObservableCollection<String> msgList = new ObservableCollection<String>();
			String msg = "g";
			String msg2 = "message2";
			String msg3 = "message3";
			String msg4 = "message4";

			msgList.Add(msg);
			msgList.Add(msg2);
			msgList.Add(msg3);
			msgList.Add(msg4);
			lstMessages.ItemsSource = msgList;


			/*
			ObservableCollection<Events> lstEventPictures = new ObservableCollection<Events>();


			Events ev1 = new Business.Events { Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km" };
			Events ev2 = new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Grand tournoi de Tennis au bout du monde. Un public en folie avec une journée pleine de grands matchs. Venez nombreux !" };
			Events ev3 = new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "trail.png", Location = "Pickwick Bar", Description = "Final des WPT avec Patrick Bruel en Guest Star ! Du lourd " };

			//MyDataSource.Add("test1");
			//MyDataSource.Add("test2");
			crvEventPictures.ItemsSource = lstEventPictures;*/
		}

		async void InfosOnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			stkContentInfo.IsVisible = true;
			stkContentChat.IsVisible = false;
			infoLabel.TextColor = Color.White;
			chatLabel.Source = "icoBlackChat.png";
			grdSwitchViews.Children[1].BackgroundColor = Color.White;
			grdSwitchViews.Children[0].BackgroundColor = Color.FromHex("#FC7102");
			//await this.Navigation.PushModalAsync(new MyProfileView());
			//await this.Navigation.PushAsync(new MyProfileView());

		}

		async void ChatOnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			stkContentInfo.IsVisible = false;
			stkContentInfo.HeightRequest = 0;
			stkContentChat.IsVisible = true;
			infoLabel.TextColor = Color.Black;
			chatLabel.Source = "icoWhiteChat.png";
			grdSwitchViews.Children[0].BackgroundColor = Color.White;
			grdSwitchViews.Children[1].BackgroundColor = Color.FromHex("#FC7102");
			//await this.Navigation.PushModalAsync(new MyProfileView());
			//await this.Navigation.PushAsync(new MyProfileView());

		}
    }
}
