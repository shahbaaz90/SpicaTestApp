﻿using MvvmCross.IoC;
using MvvmCross.ViewModels;
using SpicaTestApp.ViewModels;

namespace SpicaTestApp
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }
    }
}
