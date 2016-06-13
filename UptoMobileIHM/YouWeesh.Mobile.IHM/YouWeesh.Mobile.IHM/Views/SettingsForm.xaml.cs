using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class SettingsForm : ContentPage
    {
        public SettingsForm()
        {
            InitializeComponent();
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            pkrLanguage.Items.Add("French");
            pkrLanguage.Items.Add("English");
            pkrLanguage.Items.Add("Spanish");
        }
    }
}
