using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomAppXamarin.iOS.Services;
using CustomAppXamarin.Services;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(DeviceOrientationServiceIos))]
namespace CustomAppXamarin.iOS.Services
{
    public class DeviceOrientationServiceIos: IDeviceOrientation
    {
       
        public DeviceOrientation GetOrientation()
        {
            var currentOrientation = UIApplication.SharedApplication.StatusBarOrientation;
            bool isPortrait = currentOrientation == UIInterfaceOrientation.Portrait || currentOrientation == UIInterfaceOrientation.PortraitUpsideDown;

            return !isPortrait ? DeviceOrientation.Landscape : DeviceOrientation.Portrait;


        }
        
       
    }
}