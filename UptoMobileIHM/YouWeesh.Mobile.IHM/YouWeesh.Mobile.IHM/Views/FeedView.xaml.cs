using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile;
using YouWeesh.Mobile.CustomComponents;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using YouWeesh.Mobile.Business;

namespace YouWeesh.Mobile.Views
{
	public partial class FeedView : ContentPage
	{
		ObservableCollection<Business.Element> elements = new ObservableCollection<Business.Element>();
		bool filterVisible = false;
		FeedFilterForm feedFilterForm = new FeedFilterForm();
		AddFloatingButton myFloatingButton = new AddFloatingButton();


		public FeedView()
		{
			this.Icon = "whiteWeeshIco.png";
			InitializeComponent();

			//Add Buttons on top bar
			ToolbarItems.Add(new ToolbarItem
			{
				Text = "List",
				Icon = "Listviewicon.png",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(this.SwitchView),
				Priority = 0
			});

			ToolbarItems.Add(new ToolbarItem
			{
				Text = "Map",
				Icon = "Mappinicon.png",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(this.SwitchView),
				Priority = 0
			});

			ToolbarItems.Add(new ToolbarItem
			{
				Text = "Filter",
				Icon = "FiltericonWhite.png",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(this.ShowFilterView),
				Priority = 1
			});

			elements.Add(new Business.Element { Id = 0, Title = "Jouer au #foot au stade de France avec Zinedine Zidane et Griezman !", Picture = "portrait2.png", CreationDate = "01h30 ago", Location = "1 km", IsEvent = false, WeeshBack = 10, OwnerName="Teddy Riner" });
			elements.Add(new Business.Element { Id = 1, Title = "Faire une partie de #tennis", Picture = "portrait3.png", CreationDate = "03h30 ago", Location = "1,5 km", IsEvent = false, WeeshBack = 23, OwnerName="Vincent Haring" });
			//elements.Add(new Business.Element { Id = 2, Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", CreationDate = "02h30 ago", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km", IsEvent = true });
			//elements.Add(new Business.Element { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", CreationDate = "03h30 ago", Location = "Centre sportif du bout du monde", IsEvent=true });
			//elements.Add(new Business.Element { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", CreationDate = "02h20 ago", Location = "Centre sportif du bout du monde", IsEvent=true });
			//elements.Add(new Business.Element { Title = "Motivé pour aller au #theatre", Picture = "portrait4.png", CreationDate = "06h00 ago", Location = "0.5 km", IsEvent = false });
			//elements.Add(new Business.Element { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", CreationDate = "04h40 ago", Location = "Bout du monde", IsEvent = true });
			//elements.Add(new Business.Element { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", CreationDate = "05h50 ago", Location = "Pickwick Bar", IsEvent = true });
			elements.Add(new Business.Element { Id = 3, Title = "#courir !!", Picture = "portrait5.png", CreationDate = "06h15 ago", Location = "2 km", IsEvent = false, WeeshBack = 4 });
			//elements.Add(new Business.Element { Id = 4, Title = "Discuter autour d'un #verre", Picture = "portrait4.jpg", CreationDate = "06h45 ago", Location = "1,2 km", IsEvent = false, WeeshBack = 30 });
			elements.Add(new Business.Element { Id = 5, Title = "Aller regarder l'#euro", Picture = "portrait2.png", CreationDate = "07h00 ago", Location = "2,6 km", IsEvent = false, WeeshBack = 5 });
			//elements.Add(new Business.Element { Tile = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", CreationDate = "01h30 ago", Location = "Pickwick Bar", Description = "Final des WPT avec Patrick Bruel en Guest Star ! Du lourd ", IsEvent = true });
			elements.Add(new Business.Element { Id = 6, Title = "Je vais mater l'#euro a la #fanzone", Picture = "portrait3.png", CreationDate = "07h15 ago", Location = "0.6 km", IsEvent = false, WeeshBack = 6 });
			elements.Add(new Business.Element { Id = 7, Title = "J'ai faim de  #nectarine", Picture = "portrait4.png", CreationDate = "12h00 ago", Location = "0,3 km", IsEvent = false, WeeshBack = 40 });
			elements.Add(new Business.Element { Id = 0, Title = "Jouer au #foot", Picture = "portrait2.png", CreationDate = "01h30 ago", Location = "1 km", IsEvent = false, WeeshBack = 10 });
			elements.Add(new Business.Element { Id = 1, Title = "Faire une partie de #tennis", Picture = "portrait3.png", CreationDate = "03h30 ago", Location = "1,5 km", IsEvent = false, WeeshBack = 23 });
			//elements.Add(new Business.Element { Id = 2, Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", CreationDate = "02h30 ago", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km", IsEvent = true });
			elements.Add(new Business.Element { Id = 0, Title = "Jouer au #foot", Picture = "portrait2.png", CreationDate = "01h30 ago", Location = "1 km", IsEvent = false, WeeshBack = 10 });
			elements.Add(new Business.Element { Id = 1, Title = "Faire une partie de #tennis", Picture = "portrait3.png", CreationDate = "03h30 ago", Location = "1,5 km", IsEvent = false, WeeshBack = 23 });
			//elements.Add(new Business.Element { Id = 2, Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", CreationDate = "02h30 ago", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km", IsEvent = true });
			elements.Add(new Business.Element { Id = 6, Title = "Je vais mater l'#euro a la #fanzone", Picture = "portrait3.png", CreationDate = "07h15 ago", Location = "0.6 km", IsEvent = false, WeeshBack = 6 });
			elements.Add(new Business.Element { Id = 7, Title = "J'ai faim de  #nectarine", Picture = "portrait4.png", CreationDate = "12h00 ago", Location = "0,3 km", IsEvent = false, WeeshBack = 40 });
			elements.Add(new Business.Element { Id = 6, Title = "Je vais mater l'#euro a la #fanzone", Picture = "portrait3.png", CreationDate = "07h15 ago", Location = "0.6 km", IsEvent = false, WeeshBack = 6 });
			elements.Add(new Business.Element { Id = 7, Title = "J'ai faim de  #nectarine", Picture = "portrait4.png", CreationDate = "12h00 ago", Location = "0,3 km", IsEvent = false, WeeshBack = 40 });
			elements.Add(new Business.Element { Id = 6, Title = "Je vais mater l'#euro a la #fanzone", Picture = "portrait3.png", CreationDate = "07h15 ago", Location = "0.6 km", IsEvent = false, WeeshBack = 6 });
			elements.Add(new Business.Element { Id = 7, Title = "J'ai faim de  #nectarine", Picture = "portrait4.png", CreationDate = "12h00 ago", Location = "0,3 km", IsEvent = false, WeeshBack = 40 });
			elements.Add(new Business.Element { Id = 6, Title = "Je vais mater l'#euro a la #fanzone", Picture = "portrait3.png", CreationDate = "07h15 ago", Location = "0.6 km", IsEvent = false, WeeshBack = 6 });
			elements.Add(new Business.Element { Id = 7, Title = "J'ai faim de  #nectarine", Picture = "portrait4.png", CreationDate = "12h00 ago", Location = "0,3 km", IsEvent = false, WeeshBack = 40 });

			lstfeedView.ItemsSource = elements;

			var pinMarcus = new CustomPin
			{
				Pin = new Pin
				{
					Type = PinType.Place,
					Position = new Position(46.1914286, 6.1354516),
					Label = "Marcus",
					Address = "Route des Acacias 23, 1227 Les Acacias, Switzerland"
				},
				Id = "User",
				Url = "http://xamarin.com/about/"
			};

			var pinJen = new CustomPin
			{
				Pin = new Pin
				{
					Type = PinType.Place,
					Position = new Position(46.1963894, 6.142172699999946),
					Label = "Jen",
					Address = "Avenue Henri-Dunant 11, 1205 Genève, Switzerland"
				},
				Id = "User",
				Url = "http://xamarin.com/about/"
			};

			myMap.CustomPins = new List<CustomPin> { pinMarcus, pinJen };
			myMap.Pins.Add(pinMarcus.Pin);
			myMap.Pins.Add(pinJen.Pin);

			relativeLayout.Children.Add(myFloatingButton, Constraint.Constant(YouWeesh.Mobile.App.ScreenWidth - 80), Constraint.Constant(YouWeesh.Mobile.App.ScreenHeight - 150));

			//Refresh List when current user add a weesh
			MessagingCenter.Subscribe<AddWeeshForm, String>(this, "NewWeesh", (page, text) =>
			{
				lstfeedView.BeginRefresh();
				elements.Insert(0, new Business.Element { Title = text, Picture = "portrait4.png", CreationDate = "0h00 ago", Location = "0 km", IsEvent = false });
				lstfeedView.EndRefresh();

			});

			MessagingCenter.Subscribe<WeeshViewCell, int>(this, "WeeshBack", (page, idElement) =>
			{
				lstfeedView.BeginRefresh();
				YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				//int indexElement = elements.IndexOf(element);
				element.WeeshBack++;
				//element.IsWeeshBacked = true;
				//elements.Remove(element);
				//elements.Insert(indexElement,element);
				lstfeedView.EndRefresh();

			});

			MessagingCenter.Subscribe<WeeshViewCell, int>(this, "RedirectToEventDetails", (page, idElement) =>
			{
				lstfeedView.BeginRefresh();
				YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new EventDetailsView());
				lstfeedView.EndRefresh();

			});

			MessagingCenter.Subscribe<WeeshViewCell, int>(this, "RedirectToMyProfile", (page, idElement) =>
			{
				YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new MyProfileView());

			});

			MessagingCenter.Subscribe<EventsViewCell, int>(this, "RedirectToMyProfile", (page, idElement) =>
			{
				YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new MyProfileView());

			});

			MessagingCenter.Subscribe<EventsViewCell, int>(this, "RedirectToEventDetails", (page, idEvent) =>
			{
				//YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new EventDetailsView());

			});

			lstfeedView.Scroll += (s, e) => {

				HideFilterView();
				myFloatingButton.FadeTo(0, 250);
				//myFloatingButton.IsVisible = false;
				
			};	

			lstfeedView.StopScroll += (s, e) =>
			{
				myFloatingButton.FadeTo(1, 250);
				//myFloatingButton.IsVisible = true;

			};


			// 1 - test hide /unhide during an event (scroll)
			// grdListType.HeightRequest = 0;

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param> 
		/// 
		/// 
		async void ShowFilterView()
		{
			filterVisible = !filterVisible;

			if (filterVisible == true)
			{
				relativeLayout.Children.Add(feedFilterForm, Constraint.Constant(0), Constraint.Constant(-400));
				await feedFilterForm.LayoutTo(new Rectangle(0, 0, feedFilterForm.Width, feedFilterForm.Height), 250);
				//lstfeedView.LayoutTo(new Rectangle(0, feedFilterForm.Height, lstfeedView.Width, lstfeedView.Height), 250);
			}
			else
			{
				await feedFilterForm.LayoutTo(new Rectangle(0, -1 * feedFilterForm.Height, feedFilterForm.Width, feedFilterForm.Height), 250);
				relativeLayout.Children.Remove(feedFilterForm);
			}

		}

		async void HideFilterView()
		{

			if (filterVisible)
			{
				filterVisible = false;
				await feedFilterForm.LayoutTo(new Rectangle(0, -1 * feedFilterForm.Height, feedFilterForm.Width, feedFilterForm.Height), 250);
				relativeLayout.Children.Remove(feedFilterForm);			
			}	
					
		}

		void SwitchView()
		{
			if (myMap.IsVisible == false)
			{
				
				myMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(46.2043907, 6.143157699999961), Distance.FromMiles(1)));

			}
			lstfeedView.IsVisible = !lstfeedView.IsVisible;
			myMap.IsVisible = !myMap.IsVisible;
		}


	}


}
