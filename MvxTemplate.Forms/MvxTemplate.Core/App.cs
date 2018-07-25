using MvvmCross;
using MvvmCross.ViewModels;
using MvxTemplate.Core.Services;
using MvxTemplate.Core.ViewModels;

namespace MvxTemplate.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<RootViewModel>();
        }
    }
}