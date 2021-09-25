using Foundation;
using UIKit;

namespace AugustUIChallenge.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Xamarin.Forms.Forms.Init();
            Sharpnado.Tabs.iOS.Preserver.Preserve();
            Sharpnado.Shades.iOS.iOSShadowsRenderer.Initialize();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}