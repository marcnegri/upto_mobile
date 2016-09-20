using System;
using System.Collections.Generic;
using YouWeesh.Mobile;
using Xamarin.Forms;
using YouWeesh.Mobile.Business;
using YouWeesh.Mobile.Views;
using System.Collections.ObjectModel;
using YouWeesh.Mobile.CustomComponents;

namespace YouWeesh.Mobile
{
	public partial class MyStory : CarouselPage
	{
		ObservableCollection<Business.Events> events = new ObservableCollection<Business.Events>();

		public MyStory()
		{
			InitializeComponent();

			List<DateTypeGroup> dateList = new List<DateTypeGroup>
			{
				new DateTypeGroup("2016"),
				new DateTypeGroup("2015"),
		
            };

			lstDate.ItemsSource = dateList;

			List<PageTypeGroup> pgs = new List<PageTypeGroup>
			{
				new PageTypeGroup("27.06.2016")
				{
					new Business.Element {Id = 0, Title = "Jouer au #foot", Picture = "portrait4.png", CreationDate = "01h30 ago", Location = "1 km", IsEvent = false, WeeshBack = 10 },
					new Business.Element {Id = 2, Title = "Trail des Roussets", StartDatetime = "2:30 ago", EndDatetime = "<-> 205km", CreationDate = "02h30 ago", Picture = "trail.jpg", Location = "Centre sportif du bout du monde", Description = "Samedi une marche découverte et dimanche les courses avec 3 distances : 12 km, 20 km et 32 km", IsEvent = true },
					new Business.Element { Id = 1, Title = "Faire une partie de #tennis", Picture = "portrait4.png", CreationDate = "03h30 ago", Location = "1,5 km", IsEvent = false, WeeshBack = 23 }
			
				},
				new PageTypeGroup("30.06.2016")
				{
					new Business.Element {Id = 3, Title = "#courrir !!", Picture = "portrait4.png", CreationDate = "06h15 ago", Location = "2 km", IsEvent = false,WeeshBack = 4 },
					new Business.Element { Id = 4, Title = "Discuter autour d'un #verre", Picture = "portrait4.jpg", CreationDate = "06h45 ago", Location = "1,2 km", IsEvent = false, WeeshBack = 30 },
					new Business.Element { Id = 5, Title = "Aller regarder l'#euro", Picture = "portrait4.png", CreationDate = "07h00 ago", Location = "2,6 km", IsEvent = false, WeeshBack = 5 }
					
				}
				/*,
                new PageTypeGroup("14.07.2016")
                {
                    new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" },
                    new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" },
                    new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" }
                },*/
            };

			lstMyStory.ItemsSource = pgs;

			MessagingCenter.Subscribe<WeeshViewCell, int>(this, "RedirectToMyProfile", (page, idElement) =>
			{
				//YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new MyProfileView());

			});
	
		}


		public void HandleCurrentPageChanged(object sender, EventArgs e)
		{
			if (Children.Count > 1)
			{
				this.SelectedItem = Children[0];
				Children.Remove(Children[1]);
				CurrentPageChanged -= HandleCurrentPageChanged;
			}
		}

	

	}

	public class DateTypeGroup : List<Month>
	{
		public string Title { get; set; }
		//private List<Month> months;
		//public string ShortName { get; set; } 

		public DateTypeGroup(string title)//string shortName)
		{
			 Title = title;
			this.Add(new Month { Label = "Dec", Id = 12 });		 	
			this.Add(new Month { Label = "Nov", Id = 11 });
			this.Add(new Month { Label = "Oct", Id = 10 });
			this.Add(new Month { Label = "Sep", Id = 9 });
			this.Add(new Month { Label = "Aug", Id = 8 });
			this.Add(new Month { Label = "Jul", Id = 7 });
			this.Add(new Month { Label = "Jun", Id = 6 });
			this.Add(new Month { Label = "May", Id = 5 });
			this.Add(new Month { Label = "Apr", Id = 4 });
			this.Add(new Month { Label = "Mar", Id = 3 });
			this.Add(new Month { Label = "Feb", Id = 2 });
			this.Add(new Month { Label = "Jan", Id = 1 });		
			//ShortName = shortName;
		}

		public static IList<DateTypeGroup> All { private set; get; }
	}

	public class Month
	{
		private string label;
		private int id;

		public string Label
		{
			get
			{
				return label;
			}

			set
			{
				label = value;
			}
		}

		public int Id
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
			}
		}


	}

	public class PageTypeGroup : List<Business.Element>
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


}

