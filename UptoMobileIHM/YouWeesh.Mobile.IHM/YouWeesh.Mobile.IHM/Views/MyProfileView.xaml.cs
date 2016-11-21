using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using YouWeesh.Mobile.Business;
using YouWeesh.Mobile.CustomComponents;
using YouWeesh.Mobile.Views;

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
			elements.Add(new Business.Element { Title = "#courir !!", Picture = "portrait4.png", CreationDate = "06h15 ago", Location = "2 km", IsEvent = false, WeeshBack = 4 });
			elements.Add(new Business.Element { Title = "Discuter autour d'un #verre", Picture = "portrait4.png", CreationDate = "06h45 ago", Location = "1,2 km", IsEvent = false, WeeshBack = 30 });
			elements.Add(new Business.Element { Title = "Aller regarder l'#euro", Picture = "portrait4.png", CreationDate = "07h00 ago", Location = "2,6 km", IsEvent = false, WeeshBack = 5 });
			#endregion

			this.BackgroundColor = Color.White;//Color.FromHex("#ececec");
			stkActionInfo.BackgroundColor = Color.FromRgb(252, 113, 2);
			rltHeader.BackgroundColor = Color.FromRgb(252, 113, 2);

			rltHeader.Children.Add(stkActionInfo, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + 95;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height;
			}));

			rltHeader.Children.Add(stkImgProfile, Constraint.RelativeToParent((parent) =>
			{
				return 15;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 135;//return imgBackground.Height - 55;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 70;//parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 70;//parent.Height;
			}));


			/*ObservableCollection<Weesh> weeshesList = new ObservableCollection<Weesh>();
			ObservableCollection<Business.Events> events = new ObservableCollection<Business.Events>();

			Events ev1 = new Business.Events { Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km" };
			Events ev2 = new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Grand tournoi de Tennis au bout du monde. Un public en folie avec une journée pleine de grands matchs. Venez nombreux !" };
			Events ev3 = new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "trail.png", Location = "Pickwick Bar", Description = "Final des WPT avec Patrick Bruel en Guest Star ! Du lourd " };

			events.Add(ev1);
			events.Add(ev2);
			events.Add(ev3);*/

			List<PageTypeGroup> pgs = new List<PageTypeGroup>
			{
				new PageTypeGroup("27.06.2016")
				{
					new Business.Element {Id = 10, Title = "Trail des Roussets", IsEvent=true, StartDatetime = "19:00", EndDatetime = "20:00", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description="Samedi une marche déouverte et dimanche les courses avec 3 istances  12 km, 20 km et 32 km" },
					new Business.Element {Id = 0, Title = "Jouer au #foot au stade de France avec Zinedine Zidane et Griezman !", Picture = "portrait2.png", CreationDate = "01h30 ago", Location = "1 km", IsEvent = false, WeeshBack = 10, OwnerName="Teddy Riner" },
					new Business.Element {Id = 11,  Title = "Tennis playing", IsEvent=true, StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.png", Location = "Centre sportif du bout du monde", Description="Grand tournoi de Tennis au bout du monde. Un public en folie avec une journé pleine de grands matchs. Venez nombreux !" },
					new Business.Element {Id = 12,  Title = "Streetbasket", IsEvent=true, StartDatetime = "18:00", EndDatetime = "20:00", Picture = "basket.png", Location = "Terrain de Thonex", Description="Streetbasket sur du bon HipHop old school" }
				},
				new PageTypeGroup("30.06.2016")
				{
					new Business.Element {Id = 1, Title = "Faire une partie de #tennis", Picture = "portrait3.png", CreationDate = "03h30 ago", Location = "1,5 km", IsEvent = false, WeeshBack = 23, OwnerName = "Vincent Haring" },
					new Business.Element {Id = 13, Title = "Squash", StartDatetime = "18:00", IsEvent=true, EndDatetime = "20:00", Picture = "squash.png", Location = "Centre sportif des vernets", Description="Un Squash de fou à" },
					new Business.Element {Id = 14,  Title = "#Futsal", StartDatetime = "20:00",IsEvent=true, EndDatetime = "21:00", Picture = "futsal.png", Location = "Bout du monde", Description="Match de futsal entre potes, inscrits toi pour jouer avec nous !" },
					new Business.Element {Id = 15,  Title = "Session de boxe", StartDatetime = "21:00",IsEvent=true, EndDatetime = "22:30", Picture = "boxe.png", Location = "Ring de Rives", Description="Session de boxe animé par Mike Tyson au Ring de Rives" }
				}
			
		
			//elements.Add(new Business.Element { Id = 2, Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", CreationDate = "02h30 ago", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses av
				/*,
                new PageTypeGroup("14.07.2016")
                {
                    new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" },
                    new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" },
                    new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" }
                },*/
            };

			myProfileListView.ItemsSource = pgs;
		}
		/// <summary>
		/// Buttons the show history clicked.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public void btnShowHistory_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new MyStory());
			//MessagingCenter.Send<MyStory, String>(this, "MyStory");
		}

		async void FriendsOnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			await this.Navigation.PushAsync(new FriendsForm());
			//await this.Navigation.PushModalAsync(new MyProfileView());

		}

		async void TagsOnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			await this.Navigation.PushAsync(new FeedView());
			//await this.Navigation.PushModalAsync(new MyProfileView());

		}
	}

}


public class PageTypeGroup : List<Events>
{
	public string Title { get; set; }
	//public string ShortName { get; set; } 

	public PageTypeGroup(string title)//string shortName)
	{
		Title = title;
		//ShortName = shortName;
	}

	public static IList<PageTypeGroup> All { private set; get; }
}
