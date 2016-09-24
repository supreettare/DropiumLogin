using DropiumLogin.iOS;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(LoginEntryRenderer))]
namespace DropiumLogin.iOS
{
    public class LoginEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.Layer.CornerRadius = 18;
                Control.TextAlignment = UIKit.UITextAlignment.Center; 
            }
        }
    }
}
