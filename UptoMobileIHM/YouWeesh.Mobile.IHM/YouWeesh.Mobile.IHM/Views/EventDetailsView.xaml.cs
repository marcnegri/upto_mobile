using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class EventDetailsView : ContentPage
    {
        public EventDetailsView()
        {
            InitializeComponent();
			this.BackgroundColor = Color.FromHex("#ececec");
			lblLocation.TextColor = Color.FromRgb(49, 159, 212);

			rltHeader.Children.Add(stkImgProfile, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (rltHeader.Height - (imgProfile.Height / 2));
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 75;
			}));


			rltHeader.Children.Add(lblProfileName, Constraint.RelativeToParent((parent) =>
			{
				return parent.X;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y;
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
				return parent.Y + (parent.Height * 0.15);
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 20;
			}));

			rltHeader.Children.Add(stkParticipants, Constraint.RelativeToParent((parent) =>
			{
				return parent.X + (parent.Height /4) ;
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Y + (parent.Height - stkParticipants.Height );
			}), Constraint.RelativeToParent((parent) =>
			{
				return parent.Width;
			}), Constraint.RelativeToParent((parent) =>
			{
				return 30;
			}));

			lblDescription.Margin = new Thickness(10,(imgProfile.HeightRequest / 2) + 10,10,10);
			lblPrice.Margin = new Thickness(10, 10, 10, 10);
		}
    }
}
