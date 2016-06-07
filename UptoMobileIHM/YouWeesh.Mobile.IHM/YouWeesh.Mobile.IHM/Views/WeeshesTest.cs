using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public class WeeshesTest : MasterDetailPage
    {
        public WeeshesTest()
        {
            Label weeshes = new Label
            {
                Text = "Weeshes",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Label preferences = new Label
            {
                Text = "Preferences",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            // Create the master page with the ListView.
            this.Master = new ContentPage
            {
                Icon = "showmenu.png",
                Title = weeshes.Text,
                Content = new StackLayout
                {
                    Children =
                    {
                        weeshes,
                        preferences
                    }
                }
            };

            this.Detail = new ContentPage
            {
                BackgroundColor = Color.White,
                Content = new TableView
                {
                    BackgroundColor = Color.White,
                    Intent = TableIntent.Form,
                    Root = new TableRoot("Table Title") {
                    new TableSection ("Vincent Haring") {
                        new ImageCell
                        {
                            ImageSource="twitter128.png",
                            Text = "Jouer au #Tennis",
                            Detail = "1h20 ago"
                        },
                    
                    },
                    new TableSection ("Marc Negri") {
                        new ImageCell
                        {
                            ImageSource="icon.png",
                            Text = "Matter #starWars",
                            Detail = "3h20 ago"
                        },
                    },

                    new TableSection ("Sylvain Lamouille") {
                        new ImageCell
                        {
                            ImageSource="foot.jpg",
                            Text = "Jouer au #foot mercredi",
                            Detail = "3h20 ago"
                        },
                    }
                }
                }
            };
        }
    }
}