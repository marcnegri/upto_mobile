using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using YouWeesh.Mobile.Business;

namespace YouWeesh.Mobile
{
	public partial class MyProfileView : ContentPage
	{
		public MyProfileView()
		{
			InitializeComponent();


			this.BackgroundColor = Color.FromHex("#ececec");
			lblLocation.TextColor = Color.FromRgb(49, 159, 212);

			rltHeader.Children.Add(stkProfileImg, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (parent.Height * 0.1);
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height * 0.3;
			}));

			rltHeader.Children.Add(lblProfileName, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (parent.Height * 0.4);
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height;
			}));

			rltHeader.Children.Add(stkLocation, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (parent.Height * 0.55);
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 20;
			}));

			rltHeader.Children.Add(stkParticipants, Constraint.RelativeToParent((parent) =>
			{
				return parent.X ;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y ;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 60;
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

			rltHeader.Children.Add(lblTopTag, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + rltHeader.Height - 30;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height;
			}));

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
			events.Add(ev3);

			weeshesList.Add(we);
			weeshesList.Add(we2);
			weeshesList.Add(we3);

			lstRecentWeeshes.ItemsSource = weeshesList;
			lstRecentEvents.ItemsSource = events;


		}
	}
}

