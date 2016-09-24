using DropiumLogin.Effects;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Taritas")]
[assembly: ExportEffect(typeof(RoundedCornerEffect), "RoundedCornerEffect")]
namespace DropiumLogin.iOS
{
    public class RoundedCornerEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control != null)
            {  
                Control.Layer.CornerRadius = 30;
            }
        }

        protected override void OnDetached()
        {   
        }
    }
}
