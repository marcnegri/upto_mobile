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
            InitializeComponent();

            #region Friends mocks
            Users ami = new Users();
            ami.FirstName = "Marc";
            ami.Username = "Marcus";
            ami.Picture = "icon.png";

            Users ami2 = new Users();
            ami2.FirstName = "Vincent";
            ami2.Username = "Vince";
            ami2.Picture = "icon.png";

            usersList.Add(ami);
            usersList.Add(ami2);
            #endregion

            //lstFriends.ItemsSource = usersList;

        }
    }
}
