using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile.Business;
using YouWeesh.Mobile.CustomComponents;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace YouWeesh.Mobile.Views
{
    public partial class FriendsForm : ContentPage
    {
        public FriendsForm()
        {
            ObservableCollection<Users> usersList = new ObservableCollection<Users>();
			this.BackgroundColor = Color.FromHex("#ececec");
            InitializeComponent();

            #region Friends mocks
            Users ami = new Users();
            ami.FirstName = "Marc";
            ami.Username = "Marcus";
            ami.Picture = "portrait4.png";
			ami.ListTags = "#Yoga, #Diving, #Surf";

            Users ami2 = new Users();
            ami2.FirstName = "Vincent";
            ami2.Username = "Vince";
            ami2.Picture = "portrait2.png";

            Users ami3 = new Users();
            ami3.FirstName = "Jérémy";
            ami3.Username = "Jezzer";
            ami3.Picture = "portrait3.png";

            usersList.Add(ami);
            usersList.Add(ami2);
            usersList.Add(ami3);
            #endregion

            feedView.ItemsSource = usersList;

        }
    }
}
