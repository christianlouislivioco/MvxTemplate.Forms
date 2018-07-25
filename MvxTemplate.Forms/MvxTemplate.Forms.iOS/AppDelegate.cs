using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvxTemplate.Core;
using MvxTemplate.Forms.UI;
using UIKit;

namespace MvxTemplate.Forms.iOS
{
    [Register(nameof(AppDelegate))]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<App, FormsApp>, App, FormsApp>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            return base.FinishedLaunching(app, options);
        }
    }
}
