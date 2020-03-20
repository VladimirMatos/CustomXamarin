using System;
using CustomizationsSample.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("CustomizationSample")]
[assembly: ExportEffect(typeof(iOSEntryRemoveLineEffect), "RemoveLineEffect")]

namespace CustomizationsSample.iOS.Effects
{
    public class iOSEntryRemoveLineEffect: PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is UITextField text)
            {
                text.BorderStyle = UITextBorderStyle.None;
            }
        }

        protected override void OnDetached()
        {
            
        }
    }
}
