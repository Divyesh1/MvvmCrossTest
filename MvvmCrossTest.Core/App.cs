using System;
using MvvmCross;
using MvvmCross.ViewModels;
using MvvmCrossTest.Core.Services;
using MvvmCrossTest.Core.ViewModels;

namespace MvvmCrossTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
