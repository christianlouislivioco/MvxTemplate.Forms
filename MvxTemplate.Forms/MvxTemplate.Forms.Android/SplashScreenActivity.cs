using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using MvxTemplate.Core;
using MvxTemplate.Forms.UI;

namespace MvxTemplate.Forms.Droid
{
    [Activity(
        MainLauncher = true,
        Theme = "@style/AppTheme.Splash",
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreenActivity : MvxFormsSplashScreenActivity<MvxFormsAndroidSetup<App, FormsApp>, App, FormsApp>
    {
        public SplashScreenActivity() 
            : base(Resource.Layout.SplashScreen)
        {
        }

        protected override void RunAppStart(Bundle bundle)
        {
            StartActivity(typeof(MainActivity));
            base.OnCreate(bundle);
        }
    }
}