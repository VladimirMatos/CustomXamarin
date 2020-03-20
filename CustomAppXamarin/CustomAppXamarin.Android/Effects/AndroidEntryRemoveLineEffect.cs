using System;
using CustomAppXamarin.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("CustomizationSample")]
[assembly: ExportEffect(typeof(AndroidEntryRemoveLineEffect), "RemoveLineEffect")]
namespace CustomAppXamarin.Droid.Effects
{
    public class AndroidEntryRemoveLineEffect: PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control != null)
            {
                Control.SetBackground(null);
            }
        }

        protected override void OnDetached()
        {
           
        }
    }
}
