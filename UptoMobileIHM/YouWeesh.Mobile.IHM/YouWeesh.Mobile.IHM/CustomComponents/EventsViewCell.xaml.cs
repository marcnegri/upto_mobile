using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile.Views;

using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
    public partial class EventsViewCell : ViewCell
    {
		public EventsViewCell()
		{
			InitializeComponent();
			mainLayout.Padding = new Thickness(5, 5, 5, 5);

			mainLayout.Children.Add(stlDescription, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + 120;
			}), Constraint.RelativeToParent((parent) =>
			{
				if (lblDescription.Text == null)
				{
					return 0;
				}
				else {
					return parent.Width;
				}
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Height - 125;
			}));
		}

		/*
		public void eventViewCell_Taped(object sender, EventArgs e)
		{
			//var EventDetails = new EventDetailsView();
			MessagingCenter.Send<EventsViewCell>(this, "RedirectToEventDetails");
			//App.Current.MainPage.Navigation.PushAsync(EventDetails);
			//Children.Add(EventDetails);
			//this.SelectedItem = Children[1];
			//this.Title = "Trail des Roussets";
		}*/

		/*
		public event EventHandler<TappedEventArgs> TappedToto;

		public void HandleTappedEvent(object sender, TappedEventArgs args) // catches TextChanged to Entry (MyENry)
		{
			var handle = TappedToto;

			if (handle != null)
			{
				handle(sender, args);
			}
		}*/
    }
}
