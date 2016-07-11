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
            img.HeightRequest = 150;
            img.Aspect = Aspect.AspectFill;
            mainLayout.Padding = new Thickness(5,5,5,5);
        }
    }
}
