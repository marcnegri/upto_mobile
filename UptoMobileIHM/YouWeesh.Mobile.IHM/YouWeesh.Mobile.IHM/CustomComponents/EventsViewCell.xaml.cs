using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile.Views;

using Xamarin.Forms;
using System.Diagnostics;

namespace YouWeesh.Mobile.CustomComponents
{
    public partial class EventsViewCell : ViewCell
    {

		public EventsViewCell(Boolean displayTime = false)
		{
			InitializeComponent();

			mainLayout.Children.Add(stkEventInfo, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 120;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 140;
			}));

			stkLayoutTime.IsVisible = displayTime;
						/*
			mainLayout.Children.Add(stlDescription, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + 185;
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
				return parent.Height - 195;
			}));*/

		}

		public void eventViewCell_Taped(object sender, EventArgs e)
		{
			/*
			var EventDetails = new EventDetailsView();
			Children.Add(EventDetails);
			this.SelectedItem = Children[1];
			this.Title = "Trail des Roussets";
			CurrentPageChanged += HandleCurrentPageChanged;*/
		}

		public event EventHandler<TappedEventArgs> TappedToto;

		public void HandleTappedEvent(object sender, TappedEventArgs args) // catches TextChanged to Entry (MyENry)
		{
			var handle = TappedToto;

			if (handle != null)
			{
				handle(sender, args);
			}
		}

		public void RelativeLayoutOnTapGestureRecognizerTapped(object sender, TappedEventArgs args) // catches TextChanged to Entry (MyENry)
		{
			MessagingCenter.Send<EventsViewCell, int>(this, "RedirectToEventDetails", int.Parse(lblId.Text));
		}

		public void ImageOnTapGestureRecognizerTapped(object sender, TappedEventArgs args) // catches TextChanged to Entry (MyENry)
		{
			MessagingCenter.Send<EventsViewCell, int>(this, "RedirectToMyProfile", int.Parse(lblId.Text));
		}
    }
}
