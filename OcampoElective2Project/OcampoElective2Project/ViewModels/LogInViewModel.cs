using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using OcampoElective2Project.Helpers;

namespace OcampoElective2Project.ViewModels
{
    public class LogInViewModel : OcampoElective2ProjectViewModel
    {

        public ICommand LoginCommand => new RelayCommand(LoginProc);
        public void LoginProc()
        {
            //var user = LoginService.Check(Username, Password);
            //if (user != null)
            //{
            //    NavigationService.NavigateTo(ViewModelLocator.HomePage, user, true);
            //    SettingsImplementation.User = JsonConvert.SerializeObject(user);
            //    SettingsImplementation.IsLoggedIn = true;
            //}
            //else
            {
                ////TODO Show error message   
                //Application.Current.MainPage.DisplayAlert("Login Failed", "Invalid entries. Username is 'username' and Password is 'password'", "Close");
                NavigationService.NavigateTo(ViewModelLocator.HomePage);
                //Username = "";
                //Password = "";
            }
        }
    }
}
