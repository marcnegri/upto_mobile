using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace YouWeesh.Mobile.Views
{
    public partial class FeedView : TabbedPage
    {
        ObservableCollection<Weesh> weeshes = new ObservableCollection<Weesh>();
        bool filterVisible = false;
        FeedFilterForm feedFilterForm = new FeedFilterForm();

        public FeedView()
        {
            InitializeComponent();

            weeshes.Add(new Weesh { Title = "Jouer au #foot", Creator = "Vince", Image = "portrait.jpg", CreationDate = "01h30 ago", Distance = "1 km" });
            weeshes.Add(new Weesh { Title = "Faire une partie de #tennis", Creator = "Marcus", Image = "portrait.jpg", CreationDate = "03h30 ago", Distance = "1,5 km" });
            weeshes.Add(new Weesh { Title = "Motivé pour aller au #theatre", Creator = "James", Image = "portrait.jpg", CreationDate = "06h00 ago", Distance = "0.5 km" });
            weeshes.Add(new Weesh { Title = "#courrir !!", Creator = "Nadia", Image = "portrait.jpg", CreationDate = "06h15 ago", Distance = "2 km" });
            weeshes.Add(new Weesh { Title = "Discuter autour d'un #verre", Creator = "Jenny", Image = "portrait.jpg", CreationDate = "06h45 ago", Distance = "1,2 km" });
            weeshes.Add(new Weesh { Title = "Aller regarder l'#euro", Creator = "Loic", Image = "portrait.jpg", CreationDate = "07h00 ago", Distance = "2,6 km" });
            weeshes.Add(new Weesh { Title = "Je vais mater l'#euro a la #fanzone", Creator = "Marcus", Image = "portrait.jpg", CreationDate = "07h15 ago", Distance = "0.6 km" });
            weeshes.Add(new Weesh { Title = "J'ai faim de  #nectarine", Creator = "Vivi", Image = "portrait.jpg", CreationDate = "12h00 ago", Distance = "0,3 km" });

            feedView.ItemsSource = weeshes;

            var positionMarcus = new Position(46.1914286, 6.1354516);
            var pinMarcus = new Pin
            {
                Type = PinType.Place,
                Position = positionMarcus,
                Label = "Marcus",
                Address = "Marcus Home"
            };
            MyMap.Pins.Add(pinMarcus);          

            // 1 - test hide /unhide during an event (scroll)
            // grdListType.HeightRequest = 0;

        }

        private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            feedView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                feedView.ItemsSource = weeshes;
            else
                feedView.ItemsSource = weeshes.Where(i => i.Title.ToLower().Contains(e.NewTextValue) || i.Creator.ToLower().Contains(e.NewTextValue));

            feedView.EndRefresh();
        }

        private void ImageCell_OnTapped(object sender, EventArgs e)
        {
            //grdListType.HeightRequest = 60;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void feedView_OnItemAppaering(object sender, EventArgs e)
        {
            //grdListType.HeightRequest = 60;
        }

        private void scrlMainView_Scrolled(object sender, ScrolledEventArgs e)
        {

            if (((ScrollView)sender).ScrollY < e.ScrollY)
            {
                feedView.BackgroundColor = Color.Aqua;
            }
        }

        async void BtnFilter_Clicked(object sender, EventArgs e)
        {
            //var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
            //await Navigation.PushModalAsync(new FeedFilterForm());           

            filterVisible = !filterVisible;

            if (filterVisible == true)
            {
                relativeLayout.Children.Add(feedFilterForm, Constraint.Constant(0),Constraint.Constant(-400));
                await feedFilterForm.LayoutTo(new Rectangle(0, 0, feedFilterForm.Width, feedFilterForm.Height), 250);                
            }
            else
            {
                await feedFilterForm.LayoutTo(new Rectangle(0, -1 * feedFilterForm.Height, feedFilterForm.Width, feedFilterForm.Height), 250);
                relativeLayout.Children.Remove(feedFilterForm);
            }


        }



    }

    public class Weesh
    {
        public string Title { get; set; }
        public string Creator { get; set; }
        public string Image { get; set; }
        public string CreationDate { get; set; }
        public string Distance { get; set; }
    }


}
