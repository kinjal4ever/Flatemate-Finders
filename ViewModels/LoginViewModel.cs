using FlatmateFinders.Common;
using FlatmateFinders.Models;
using FlatmateFinders.Services;
using FlatmateFinders.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlatmateFinders.ViewModels
{
    //View Model for Login Page
    public class LoginViewModel : INotifyPropertyChanged
    {
        #region Properties
        private readonly ILoginService _loginService;
        INavigation Navigation;
        bool Valid = false;
        string email = "";
        string password = "";
        public bool IsValid
        {
            get { return Valid; }
            set
            {
                Valid = value;
                OnPropertyChange();
                LoginCommand.ChangeCanExecute();
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChange();
                CheckIsValid();
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChange();
                CheckIsValid();
            }
        }

        //Login Command 
        public Command LoginCommand { get; }

        #endregion

        #region PropertyChange 
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChange([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public LoginViewModel(INavigation MainPageNav)
        {
            Navigation = MainPageNav;
            _loginService = new LoginService();
            LoginCommand = new Command(async () => await Login());
        }

        #endregion

        #region Methods/Events

        //Check if model valid or not
        public void CheckIsValid()
        {
            if (!Regex.IsMatch(email, ErrorList.EmailRegex))
            {
                IsValid = false;
            }
            else if (!Regex.IsMatch(email, ErrorList.PWDRegex))
            {
                IsValid = false;
            }
            else
                IsValid = true;
        }

        //Login Event
        async Task Login()
        {

            if (this.IsValid)
            {
                var login = await _loginService.AuthorizationAsync(new FFUsers()
                {
                    Email = this.Email,
                    Password = this.Password
                });

                if (login != 0)
                {
                    Global.ShowToastMessage("LoggedIn Successfully");
                    if(login == 1)
                        //await Navigation.PushModalAsync(new OfferingHomePage());
                        Application.Current.MainPage = new OfferingHomePage();
                    if (login == 2)
                        Application.Current.MainPage = new LookingForHomePage();
                        //await Navigation.PushModalAsync(new LookingForHomePage());
                }
                else
                {
                    Global.ShowToastMessage("Wrong Email or password");
                    return;
                }
            }
            else
            {
                Global.ShowToastMessage("Wrong Email or password");
            }
        }
        #endregion
    }
}
