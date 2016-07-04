using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using YouWeesh.Mobile.CustomComponents;
using YouWeesh.Mobile.IHM.Droid.Renderers;
using YouWeesh.Mobile.IHM.Droid.Gestures;
using YouWeesh.Mobile.IHM.Droid;

[assembly: ExportRenderer(typeof(ContentViewFeedCell), typeof(ContentViewFeedViewCellRenderer))]
namespace YouWeesh.Mobile.IHM.Droid.Renderers
{
    public class ContentViewFeedViewCellRenderer : ViewRenderer
    {
        private readonly CustomGestureListener _listener;
        private readonly GestureDetector _detector;

        public ContentViewFeedViewCellRenderer()
        {
            _listener = new CustomGestureListener();
            _detector = new GestureDetector(_listener);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement == null)
            {
                this.GenericMotion -= HandleGenericMotion;
                this.Touch -= HandleTouch;
                _listener.OnSwipeLeft -= HandleOnSwipeLeft;
                _listener.OnSwipeRight -= HandleOnSwipeRight;
                _listener.OnSwipeTop -= HandleOnSwipeTop;
                _listener.OnSwipeDown -= HandleOnSwipeDown;
            }

            if (e.OldElement == null)
            {
                this.GenericMotion += HandleGenericMotion;
                this.Touch += HandleTouch;
                _listener.OnSwipeLeft += HandleOnSwipeLeft;
                _listener.OnSwipeRight += HandleOnSwipeRight;
                _listener.OnSwipeTop += HandleOnSwipeTop;
                _listener.OnSwipeDown += HandleOnSwipeDown;
            }
        }

        void HandleTouch(object sender, TouchEventArgs e)
        {
            _detector.OnTouchEvent(e.Event);
        }

        void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            _detector.OnTouchEvent(e.Event);
        }

        void HandleOnSwipeLeft(object sender, EventArgs e)
        {
            ContentViewFeedCell _gi = (ContentViewFeedCell)this.Element;
            _gi.OnSwipeLeft();
        }

        void HandleOnSwipeRight(object sender, EventArgs e)
        {
            ContentViewFeedCell _gi = (ContentViewFeedCell)this.Element;
            _gi.OnSwipeRight();
        }

        void HandleOnSwipeTop(object sender, EventArgs e)
        {
            ContentViewFeedCell _gi = (ContentViewFeedCell)this.Element;
            _gi.OnSwipeTop();
        }

        void HandleOnSwipeDown(object sender, EventArgs e)
        {
            ContentViewFeedCell _gi = (ContentViewFeedCell)this.Element;
            _gi.OnSwipeDown();
        }


    }
}