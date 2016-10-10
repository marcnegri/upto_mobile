using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageCircle.Forms.Plugin.Abstractions;

using Xamarin.Forms;

namespace YouWeesh.Mobile.Views
{
    public partial class AddWeeshForm : ContentPage
    {
        public AddWeeshForm()
        {
           // this.BackgroundColor = Color.White;
            InitializeComponent();
            //imgWeesh.Aspect = Aspect.AspectFit;

			//normalFab.SizeChanged += (sender, args) => { layout.ForceLayout(); };
        }

		public void btnAddWeesh_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
			MessagingCenter.Send<AddWeeshForm, String>(this, "NewWeesh", txtWeesh.Text);
			//this.Navigation.PushModalAsync(new Views.WeeshesTesst());
		}

		public void btnCancelWeesh_Clicked(object sender, EventArgs e)
		{
			this.Navigation.PopModalAsync();
			//MessagingCenter.Send<AddWeeshForm, String>(this, "NewWeesh", editorWeesh.Text);
			//this.Navigation.PushModalAsync(new Views.WeeshesTesst());
		}
    }
}
