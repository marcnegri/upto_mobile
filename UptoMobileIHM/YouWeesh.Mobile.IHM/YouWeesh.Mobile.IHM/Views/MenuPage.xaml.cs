using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnFriends_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.FriendsForm());
        }

        private void btnSettings_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.SettingsForm());
        }

        private void btnMyWeesh_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.MyWeeshView());
        }

        private void btnWE_Clicked(object sender, EventArgs e)
        {
            //this.Navigation.PushModalAsync(new Views.MyNextEventsView());
        }

        private void btnNextEvents_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Views.MyNextEventsView());
        }
        
    }
}
