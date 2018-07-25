using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using MvxTemplate.Forms.UI;

namespace MvxTemplate.Forms.UWP
{
    sealed partial class App
    {
        public App()
        {
            this.InitializeComponent();
        }
    }

    public abstract class MvxTemplateApp : MvxWindowsApplication<MvxFormsWindowsSetup<Core.App, FormsApp>, Core.App, FormsApp, MainPage>
    {
    }
}
