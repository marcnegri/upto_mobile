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


			rltHeader.Children.Add(stkImgProfile, Constraint.RelativeToParent((parent) =>
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
				return 75;
			}));
		}
    }
}
