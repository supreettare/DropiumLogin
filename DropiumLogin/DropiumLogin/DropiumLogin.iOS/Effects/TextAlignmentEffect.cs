using DropiumLogin.iOS.Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

//[assembly: ResolutionGroupName("Taritas")]
[assembly: ExportEffect(typeof(TextAlignmentEffect), "TextAlignmentEffect")]
namespace DropiumLogin.iOS.Effects
{
    public class TextAlignmentEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
           ((UITextView)Control).TextAlignment = UITextAlignment.Center;
        }

        protected override void OnDetached()
        {
        }
    }
}
