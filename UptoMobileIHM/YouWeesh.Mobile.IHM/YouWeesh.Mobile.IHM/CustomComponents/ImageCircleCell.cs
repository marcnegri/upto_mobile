using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YouWeesh.Mobile.CustomComponents
{
    public class ImageCircleCell : ViewCell
    {
        public static readonly BindableProperty TextProperty = BindableProperty.Create("Toto", typeof(string), typeof(ImageCircleCell), "");

        public string Toto
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        /*
        public static readonly BindableProperty CategoryProperty = BindableProperty.Create("Category", typeof(string), typeof(ImageCircleCell), "");

        public string Category
        {
            get { return (string)GetValue(CategoryProperty); }
            set { SetValue(CategoryProperty, value); }
        }

        public static readonly BindableProperty ImageFilenameProperty = BindableProperty.Create("ImageFilename", typeof(string), typeof(ImageCircleCell), "");

        public string ImageFilename
        {
            get { return (string)GetValue(ImageFilenameProperty); }
            set { SetValue(ImageFilenameProperty, value); }
        }
        */

        public ImageCircleCell() { }
    }
}
