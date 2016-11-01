using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using YouWeesh.Mobile.Business;
using Xamarin.Forms;
using YouWeesh.Mobile.CustomComponents;

namespace YouWeesh.Mobile.Views
{
	public partial class MyNextEventsView : CarouselPage
    {
        ObservableCollection<Business.Events> events = new ObservableCollection<Business.Events>();

        public MyNextEventsView()
        {
			
			InitializeComponent();

			eventsListPage.BackgroundColor = Color.FromRgb(243, 243, 243);

			#region Events MOCKS

			/*
			rllEvents.Children.Add(
				normalFab,
				xConstraint: Constraint.RelativeToParent((parent) => { return (parent.Width - normalFab.Width) - 16; }),
				yConstraint: Constraint.RelativeToParent((parent) => { return (parent.Height - normalFab.Height) - 16; })
			);
            /*
            events.Add(new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", Location = "Centre sportif du bout du monde" });
            events.Add(new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" });
            events.Add(new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" });
            events.Add(new Business.Events { Title = "Drinking", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Pickwick Bar" });
            events.Add(new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" });
            */
            //nextEvent.ItemsSource = events;

            List<PageTypeGroup> pgs = new List<PageTypeGroup>
            {
                new PageTypeGroup("27.06.2016")
				{
					new Business.Events {Id = 10, Title = "Trail des Roussets", StartDatetime = "19:00", EndDatetime = "20:00", Picture = "trail.png", Location = "Centre sportif du bout du monde", Description="Samedi une marche déouverte et dimanche les courses avec 3 istances  12 km, 20 km et 32 km" },
					new Business.Events {Id = 11,  Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.png", Location = "Centre sportif du bout du monde", Description="Grand tournoi de Tennis au bout du monde. Un public en folie avec une journé pleine de grands matchs. Venez nombreux !" },
					new Business.Events {Id = 12,  Title = "Streetbasket", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "basket.png", Location = "Terrain de Thonex", Description="Streetbasket sur du bon HipHop old school" }
				},
				new PageTypeGroup("30.06.2016")
				{
					new Business.Events {Id = 13, Title = "Squash", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "squash.png", Location = "Centre sportif des vernets", Description="Un Squash de fou à" },
					new Business.Events {Id = 14,  Title = "#Futsal", StartDatetime = "20:00", EndDatetime = "21:00", Picture = "futsal.png", Location = "Bout du monde", Description="Match de futsal entre potes, inscrits toi pour jouer avec nous !" },
					new Business.Events {Id = 15,  Title = "Session de boxe", StartDatetime = "21:00", EndDatetime = "22:30", Picture = "boxe.png", Location = "Ring de Rives", Description="Session de boxe animé par Mike Tyson au Ring de Rives" }
				} 
				/*,
                new PageTypeGroup("14.07.2016")
                {
                    new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" },
                    new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" },
                    new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" }
                },*/
            };
			#endregion
			nextEvent.ItemTemplate = new DataTemplate(() =>
			{
				var nativeCell = new EventsViewCell(true);
				return nativeCell;
			});

            nextEvent.ItemsSource = pgs;
			nextEvent.BackgroundColor = Color.FromRgb(243, 243, 243);

			MessagingCenter.Subscribe<EventsViewCell, int>(this, "RedirectToMyProfile", (page, idElement) =>
			{
				//YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new MyProfileView());

			});

			MessagingCenter.Subscribe<EventsViewCell, int>(this, "RedirectToEventDetails", (page, idEvent) =>
			{
				//YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new EventDetailsView());

			});
			//nextEvent.GroupHeaderTemplate.SetValue(TextCell.TextProperty, Color.Black);
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

        public void eventViewCell_Taped(object sender, EventArgs e)
        {
			var EventDetails = new EventDetailsView();
            Children.Add(EventDetails);
            this.SelectedItem = Children[1];
			this.Title = "Trail des Roussets";
            CurrentPageChanged += HandleCurrentPageChanged;
        }

        public void HandleCurrentPageChanged(object sender, EventArgs e)
        {
            if(Children.Count > 1)
            {
                this.SelectedItem = Children[0];
                Children.Remove(Children[1]);
                CurrentPageChanged -= HandleCurrentPageChanged;
            }
        }
		/*
		MessagingCenter.Subscribe<WeeshViewCell, int>(this, "RedirectToEventDetails", (page, idElement) =>
		{
			lst.
			lstfeedView.BeginRefresh();
			YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
			this.Navigation.PushAsync(new EventDetailsView());
			lstfeedView.EndRefresh();

		});*/
    }
}
