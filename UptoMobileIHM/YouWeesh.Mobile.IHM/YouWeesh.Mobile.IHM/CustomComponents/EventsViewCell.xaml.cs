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
        }
    }
}
