using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using Xamarin.Forms;

namespace MvxTemplate.Forms.UI
{
    public partial class FormsApp : Application
    {
        public FormsApp()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            base.OnStart();

            AppCenter.Start("android=29b323b6-ddcf-4a45-9b5f-712cda2365e3;" +
                              "uwp=03022ec3-10de-4d29-9dbc-aebc2227a5af;" +
                              "ios=bc88859b-3b39-4ad0-a4b4-df40dd759637", 
                              typeof(Analytics), typeof(Crashes), typeof(Distribute));
        }
    }
}