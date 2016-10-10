using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
    public partial class FriendsViewCell : ViewCell
    {
        public FriendsViewCell()
        {
            InitializeComponent();
        }

		async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{
			//AnimateButton();
			await imgProfile.ScaleTo(0.40, 60, Easing.CubicOut);
			await imgProfile.ScaleTo(0.70, 60, Easing.CubicIn);
			MessagingCenter.Send<FriendsViewCell, int>(this, "RedirectToMyProfile", int.Parse("1"));
			//await this.Navigation.PushModalAsync(new MyProfileView());
			//await this.Navigation.PushAsync(new MyProfileView());

		}
    }
}
