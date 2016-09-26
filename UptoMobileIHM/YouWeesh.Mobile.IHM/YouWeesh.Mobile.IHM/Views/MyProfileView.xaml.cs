using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using YouWeesh.Mobile.Business;

namespace YouWeesh.Mobile
{
	public partial class MyProfileView : ContentPage
	{
		void Handle_Clicked(object sender, System.EventArgs e)
		{
			throw new NotImplementedException();
		}

		public MyProfileView()
		{
			InitializeComponent();

			#region MOCKS
			ObservableCollection<Business.Element> elements = new ObservableCollection<Business.Element>();
			elements.Add(new Business.Element { Title = "#courrir !!", Picture = "portrait4.jpg", CreationDate = "06h15 ago", Location = "2 km", IsEvent = false, WeeshBack = 4 });
			elements.Add(new Business.Element { Title = "Discuter autour d'un #verre", Picture = "portrait4.jpg", CreationDate = "06h45 ago", Location = "1,2 km", IsEvent = false, WeeshBack = 30 });
			elements.Add(new Business.Element { Title = "Aller regarder l'#euro", Picture = "portrait4.jpg", CreationDate = "07h00 ago", Location = "2,6 km", IsEvent = false, WeeshBack = 5 });
			#endregion

			this.BackgroundColor = Color.White;//Color.FromHex("#ececec");
			stkActionInfo.BackgroundColor = Color.FromRgb(252, 113, 2);
			rltHeader.BackgroundColor = Color.FromRgb(252, 113, 2);
			stkHeaderWeesh.BackgroundColor = Color.FromRgb(252, 113, 2);
			stkHeaderEvents.BackgroundColor = Color.FromRgb(252, 113, 2);

			rltHeader.Children.Add(lblProfileName, Constraint.RelativeToParent((parent) =>
			{
				return parent.X + 10;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + rltHeader.Height - 50;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height;
			}));


			rltHeader.Children.Add(stkImgProfile, Constraint.RelativeToParent((parent) =>
			{
				return parent.X ;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height;
			}));


			rltHeader.Children.Add(lblRating, Constraint.RelativeToParent((parent) =>
			{
				return parent.X ;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + rltHeader.Height - 50;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height;
			}));
			/*
			ObservableCollection<Weesh> weeshesList = new ObservableCollection<Weesh>();
			ObservableCollection<Business.Events> events = new ObservableCollection<Business.Events>();

			Weesh we = new Weesh("Je veux jouer aux #echecs");
			Weesh we2 = new Weesh("Pourquoi pas aller #courir ce soir ?");
			Weesh we3 = new Weesh("Je pars #naviguer en #bateau, ca tente quelqu'un ?");

			Events ev1 = new Business.Events { Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", Picture = "trail.jpg", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km" };
			Events ev2 = new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", Location = "Centre sportif du bout du monde", Description = "Grand tournoi de Tennis au bout du monde. Un public en folie avec une journée pleine de grands matchs. Venez nombreux !" };
			Events ev3 = new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar", Description = "Final des WPT avec Patrick Bruel en Guest Star ! Du lourd " };

			events.Add(ev1);
			events.Add(ev2);
			events.Add(ev3);*/
			/*
			weeshesList.Add(we);
			weeshesList.Add(we2);
			weeshesList.Add(we3);*/

			lstRecentWeeshes.ItemsSource = elements;
			//lstRecentEvents.ItemsSource = events;

		}
		/// <summary>
		/// Buttons the show history clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void btnShowHistory_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new MyStory());
			//MessagingCenter.Send<MyStory, String>(this, "MyStory");
		}
	}
}

