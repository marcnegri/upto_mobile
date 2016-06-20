using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouWeesh.Mobile.Business;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace YouWeesh.Mobile.Views
{
    public partial class MyWeeshView : ContentPage
    {
        public MyWeeshView()
        {
            ObservableCollection<Business.Weesh> weeshes = new ObservableCollection<Business.Weesh>();
            InitializeComponent();
            Business.Weesh w = new Business.Weesh();
            w.Label = "Je veux jouer au #foot";

            Business.Weesh w1 = new Business.Weesh();
            w1.Label = "Je veux regarde un #concert ce soir !";

        }
    }
}
