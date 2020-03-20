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
using CustomAppXamarin.Droid.Services;
using CustomAppXamarin.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;


[assembly: Dependency(typeof(DevicesOrentationDroid))]
namespace CustomAppXamarin.Droid.Services
{
    public class DevicesOrentationDroid : IDeviceOrientation
    {
        public DeviceOrientation GetOrientation()
        {

            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            var rotation = windowManager.DefaultDisplay.Rotation;


            bool isLandscape = rotation == SurfaceOrientation.Rotation90 || rotation == SurfaceOrientation.Rotation270;

            return isLandscape ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;
        }
    }
}