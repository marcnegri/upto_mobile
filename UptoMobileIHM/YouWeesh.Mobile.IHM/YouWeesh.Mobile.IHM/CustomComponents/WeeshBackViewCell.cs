using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle.Forms.Plugin.Abstractions;

using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
    public partial class WeeshBackViewCell : ViewCell
    {
		public WeeshBackViewCell()
		{
			InitializeComponent();

			contentView.SwipeDown += (s, e) =>
			{

			};

			contentView.SwipeTop += (s, e) =>
			{


			};

			contentView.SwipeLeft += (s, e) =>
			{
				/*if (!buttonDelete.IsVisible)
				{
					buttonDelete.IsVisible = true;
					buttonDelete.LayoutTo(new Rectangle(buttonDelete.X, buttonDelete.Y, 80, buttonDelete.Height), 200);
					contentView.BackgroundColor = Color.FromHex("#D3D3D3");
				}*/

			};

			contentView.SwipeRight += (s, e) =>
			{
				/*if (buttonDelete.IsVisible)
				{
					deactivateDeleteButton();

				}
				*/
				//MessagingCenter.Send<AddWeeshForm, String>(this, "NewWeesh", editorWeesh.Text);

			};
	


		}
        private async void deactivateDeleteButton()
        {
            contentView.BackgroundColor = Color.White;
            await buttonDelete.LayoutTo(new Rectangle(buttonDelete.X, buttonDelete.Y, 0, buttonDelete.Height), 200);
            buttonDelete.IsVisible = false;
        }
    }
}
