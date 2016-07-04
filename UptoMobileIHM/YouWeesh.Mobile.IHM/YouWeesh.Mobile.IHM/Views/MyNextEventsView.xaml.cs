using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile.Business;
using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
	public partial class MyNextEventsView : CarouselPage
    {
        ObservableCollection<Business.Events> events = new ObservableCollection<Business.Events>();
        public MyNextEventsView()
        {
            InitializeComponent();

            #region Events MOCKS
            events.Add(new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", Location = "Centre sportif du bout du monde" });
            events.Add(new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" });
            events.Add(new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" });
            events.Add(new Business.Events { Title = "Drinking", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Pickwick Bar" });
            events.Add(new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" });

            //nextEvent.ItemsSource = events;

            List<PageTypeGroup> pgs = new List<PageTypeGroup>
            {
                new PageTypeGroup("27.06.2016")
                {
                    new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", Location = "Centre sportif du bout du monde" },
                    new Business.Events { Title = "Tennis playing", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "tennis.jpg", Location = "Centre sportif du bout du monde" }
                },
                new PageTypeGroup("30.06.2016")
                {
                    new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" },
                    new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" },
                    new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" }
                },
                new PageTypeGroup("14.07.2016")
                {
                    new Business.Events { Title = "Vernissage", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "drink.jpg", Location = "Centre sportif du bout du monde" },
                    new Business.Events { Title = "#Futsal", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "futsal.jpg", Location = "Bout du monde" },
                    new Business.Events { Title = "Poker party", StartDatetime = "18:00", EndDatetime = "20:00", Picture = "poker.jpg", Location = "Pickwick Bar" }
                },
            };
            #endregion

            nextEvent.ItemsSource = pgs;
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
            var redContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Red",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Red,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };

            Children.Add(redContentPage);
            this.SelectedItem = Children[1];
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
    }
}
