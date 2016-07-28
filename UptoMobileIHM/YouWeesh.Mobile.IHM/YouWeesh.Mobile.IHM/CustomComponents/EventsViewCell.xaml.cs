using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
    public partial class EventsViewCell : ViewCell
    {
        public EventsViewCell()
        {
            InitializeComponent();
            mainLayout.Padding = new Thickness(5,5,5,5);

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
    }
}
