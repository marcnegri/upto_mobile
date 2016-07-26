using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

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
			InitializeComponent();

			//Add Buttons on top bar
			ToolbarItems.Add(new ToolbarItem
			{
				Text = "List",
				Icon = "Listviewicon.png",
				Order = ToolbarItemOrder.Primary,
				Priority = 0
			});

			ToolbarItems.Add(new ToolbarItem
			{
				Text = "Map",
				Icon = "Mappinicon.png",
				Order = ToolbarItemOrder.Primary,
				Priority = 0
			});

			ToolbarItems.Add(new ToolbarItem
			{
				Text = "Filter",
				Icon = "Filtericon.png",
				Order = ToolbarItemOrder.Primary,
				Command = new Command(this.ShowFilterView),
				Priority = 1
			});

			elements.Add(new Business.Element { Title = "Jouer au #foot", Picture = "portrait2.png", CreationDate = "01h30 ago", Location = "1 km", IsEvent=false });
			elements.Add(new Business.Element { Title = "Faire une partie de #tennis", Picture = "portrait3.png", CreationDate = "03h30 ago", Location = "1,5 km", IsEvent = false });
			elements.Add(new Business.Element { Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km",CreationDate = "02h30 ago", Picture = "trail.jpg", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km", IsEvent = true });
			elements.Add(new Business.Element { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", CreationDate = "03h30 ago", Location = "Centre sportif du bout du monde", IsEvent=true });
			elements.Add(new Business.Element { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", CreationDate = "02h20 ago", Location = "Centre sportif du bout du monde", IsEvent=true });
			elements.Add(new Business.Element { Title = "Motivé pour aller au #theatre", Picture = "portrait4.png", CreationDate = "06h00 ago", Location = "0.5 km", IsEvent = false });
			elements.Add(new Business.Element { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", CreationDate = "04h40 ago", Location = "Bout du monde", IsEvent = true });
			elements.Add(new Business.Element { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", CreationDate = "05h50 ago", Location = "Pickwick Bar", IsEvent = true });
			elements.Add(new Business.Element { Title = "#courrir !!", Picture = "portrait5.png", CreationDate = "06h15 ago", Location = "2 km", IsEvent = false });
			elements.Add(new Business.Element { Title = "Discuter autour d'un #verre", Picture = "portrait.jpg", CreationDate = "06h45 ago", Location = "1,2 km", IsEvent = false });
			elements.Add(new Business.Element { Title = "Aller regarder l'#euro", Picture = "portrait2.png", CreationDate = "07h00 ago", Location = "2,6 km", IsEvent = false });
			elements.Add(new Business.Element { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", CreationDate = "01h30 ago", Location = "Pickwick Bar", Description = "Final des WPT avec Patrick Bruel en Guest Star ! Du lourd ", IsEvent = true });
			elements.Add(new Business.Element { Title = "Je vais mater l'#euro a la #fanzone", Picture = "portrait3.png", CreationDate = "07h15 ago", Location = "0.6 km", IsEvent = false });
			elements.Add(new Business.Element { Title = "J'ai faim de  #nectarine", Picture = "portrait4.png", CreationDate = "12h00 ago", Location = "0,3 km", IsEvent = false });

			feedView.ItemsSource = elements;

			var positionMarcus = new Position(46.1914286, 6.1354516);
			var pinMarcus = new Pin
			{
				Type = PinType.Place,
				Position = positionMarcus,
				Label = "Marcus",
				Address = "Marcus Home"
			};

			//Add of the floating button to add a weesh
			relativeLayout.Children.Add(myFloatingButton, Constraint.Constant(YouWeesh.Mobile.App.ScreenWidth - 80), Constraint.Constant(YouWeesh.Mobile.App.ScreenHeight - 150));

			//MyMap.Pins.Add(pinMarcus);          

			// 1 - test hide /unhide during an event (scroll)
			// grdListType.HeightRequest = 0;

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>

		async void ShowFilterView()
		{
			filterVisible = !filterVisible;

			if (filterVisible == true)
			{
				relativeLayout.Children.Add(feedFilterForm, Constraint.Constant(0), Constraint.Constant(-400));
				await feedFilterForm.LayoutTo(new Rectangle(0, 0, feedFilterForm.Width, feedFilterForm.Height), 250);
			}
			else
			{
				await feedFilterForm.LayoutTo(new Rectangle(0, -1 * feedFilterForm.Height, feedFilterForm.Width, feedFilterForm.Height), 250);
				relativeLayout.Children.Remove(feedFilterForm);
			}

		}



	}


}
