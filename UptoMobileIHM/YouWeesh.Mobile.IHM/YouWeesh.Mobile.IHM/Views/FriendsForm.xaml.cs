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

			Users ami4 = new Users();
			ami4.FirstName = "Vincent";
			ami4.Username = "Vince";
			ami4.Picture = "portrait2.png";

			Users ami5 = new Users();
			ami5.FirstName = "Jérémy";
			ami5.Username = "Jezzer";
			ami5.Picture = "portrait3.png";

			Users ami6 = new Users();
			ami6.FirstName = "Jérémy";
			ami6.Username = "Jezzer";
			ami6.Picture = "portrait3.png";
			ami6.ListTags = "#Yoga, #Boxe, #Petanque, #Badminton";

			Users ami7 = new Users();
			ami7.FirstName = "Vincent";
			ami7.Username = "Vince";
			ami7.Picture = "portrait2.png";

			Users ami8 = new Users();
			ami8.FirstName = "Jérémy";
			ami8.Username = "Jezzer";
			ami8.Picture = "portrait3.png";

			usersList.Add(ami);
            usersList.Add(ami2);
            usersList.Add(ami3);
			usersList.Add(ami4);
			usersList.Add(ami5);
			usersList.Add(ami6);
			usersList.Add(ami7);
			usersList.Add(ami8);
            #endregion

            feedView.ItemsSource = usersList;

			MessagingCenter.Subscribe<FriendsViewCell, int>(this, "RedirectToMyProfile", (page, idFriend) =>
			{
				//YouWeesh.Mobile.Business.Element element = elements.FirstOrDefault(x => x.Id == idElement);
				this.Navigation.PushAsync(new MyProfileView());

			});

        }
    }
}
