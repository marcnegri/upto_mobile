using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile
{
    public partial class PageTest : ContentPage
    {
        public PageTest()
        {
            this.BackgroundColor = Color.White;
            InitializeComponent();
        }

        public void Entry_Focused(object sender, EventArgs e)
        {
            ((Entry)sender).Text = "Well Done !";
        }

        async void BtnTwitter_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: Send to?", "Cancel", null, "Email", "Twitter", "Facebook");
        }
    }
}
