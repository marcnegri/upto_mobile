using Xamarin.Forms;
using YouWeesh.Mobile.Views;
using YouWeesh.Mobile.IHM.Droid;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FeedView), typeof(FeedViewRenderer))]
namespace YouWeesh.Mobile.IHM.Droid
{
    public class FeedViewRenderer : TabbedRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TabbedPage> e)
        {
            base.OnElementChanged(e);  
          
        }
    }
}