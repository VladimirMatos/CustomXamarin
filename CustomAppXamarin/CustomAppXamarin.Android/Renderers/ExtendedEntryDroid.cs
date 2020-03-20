using System;
using Android.Content;
using CustomAppXamarin.Controls;
using CustomAppXamarin.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtendedEntry), typeof(ExtendedEntryDroid))]
namespace CustomAppXamarin.Droid.Renderers
{
    public class ExtendedEntryDroid: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control!=null)
                 Control.SetBackground(null);

        }

        public ExtendedEntryDroid(Context context) : base(context)
        {
        }
    }
}
