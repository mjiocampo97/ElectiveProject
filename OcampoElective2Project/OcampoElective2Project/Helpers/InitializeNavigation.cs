using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using OcampoElective2Project.Services;
using OcampoElective2Project.Views;

namespace OcampoElective2Project.Helpers
{

    public class InitializeNavigation
    {
        public NavigationService navigationService { get; }
        public InitializeNavigation()
        {
            navigationService = new NavigationService();
            SimpleIoc.Default.Reset();
            SetPages();
            SimpleIoc.Default.Register<INavigationService>(() => navigationService);

        }

        public void SetPages()
        {
            navigationService.Configure(ViewModelLocator.LogInPage, typeof(LogInPage));
            navigationService.Configure(ViewModelLocator.ClothesPage, typeof(ClothesPage));
            navigationService.Configure(ViewModelLocator.FoodPage, typeof(FoodPage));
            navigationService.Configure(ViewModelLocator.HomePage, typeof(HomePage));
            navigationService.Configure(ViewModelLocator.MenuPage, typeof(MenuPage));
            navigationService.Configure(ViewModelLocator.OthersPage, typeof(OthersPage));
            navigationService.Configure(ViewModelLocator.RegistrationPage, typeof(RegistrationPage));
            navigationService.Configure(ViewModelLocator.TransportationPage, typeof(TransportationPage));


            /*SimpleIoc.Default.Register<LogInViewModel>();
            SimpleIoc.Default.Register<ClothesViewModel>();
            SimpleIoc.Default.Register<FoodViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
            SimpleIoc.Default.Register<MenuViewModel>();
            SimpleIoc.Default.Register<OthersViewModel>();
            SimpleIoc.Default.Register<RegistrationViewModel>();
            SimpleIoc.Default.Register<TransportationViewModel>();*/
        }
    }
}
