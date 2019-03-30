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
    //View Model for Signup Page
    public class SignupViewModel : INotifyPropertyChanged
    {

        #region Properties
        INavigation Navigation;
        private readonly IRegistrationService _registrationService;
        bool Valid = false;
        string firstName = "";
        string lastName = "";
        string email = "";
        string password = "";
        string contactPersonSelectedItem = "";
        bool isMale = true;
        bool isOffering = false;

        public bool IsValid
        {
            get { return Valid; }
            set
            {
                Valid = value;
                OnPropertyChange();
                CreateAccountCommand.ChangeCanExecute();
            }
        }

        public bool IsOffering
        {
            get { return isOffering; }
            set
            {
                isOffering = value;
                OnPropertyChange();
            }
        }

        public List<string> ContactPerson
        {
            get { return FFCommon.ContactPersonList; }
        }

        public string ContactPersonSelectedItem
        {
            get { return contactPersonSelectedItem; }
            set { contactPersonSelectedItem = value; OnPropertyChange(); }
        }

      
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChange();
                CheckIsValid();
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChange();
                CheckIsValid();

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

        public bool IsMale
        {
            get { return isMale; }
            set
            {
                isMale = value;
                OnPropertyChange();
            }
        }

        public Command CreateAccountCommand { get; }

        #endregion

        public SignupViewModel(INavigation MainPageNav, Element Parent)
        {
            Navigation = MainPageNav;
            _registrationService = new RegistrationService();
            CreateAccountCommand = new Command(async () => await CreateAccount());

        }


        #region PropertyChange 
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChange([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion


        #region Methods/Events

        //Check model is valid or not
        public void CheckIsValid()
        {

            if (firstName == "" || firstName.Length > 100)
            {
                IsValid = false;
            }
            else if (lastName == "" || firstName.Length > 100)
            {
                IsValid = false;
            }
            else if (!Regex.IsMatch(email, ErrorList.EmailRegex))
            {
                IsValid = false;
            }
            else if (!Regex.IsMatch(password, ErrorList.PWDRegex))
            {
                IsValid = false;
            }
            else
                IsValid = true;
        }

        //Create Account Event
        async Task CreateAccount()
        {
            if (this.IsValid)
            {
                if (await _registrationService.CreateAccount(new FFUsers()
                {
                    FirstName = this.FirstName,
                    Lastname = this.LastName,
                    Email = this.Email,
                    Password = this.Password,
                    isOffering = this.IsOffering,
                    ContactPerson = this.ContactPersonSelectedItem
                }))
                {
                    Global.ShowToastMessage("Registration Complete..");
                    await Navigation.PushModalAsync(new LoginPage());
                }
                else
                {
                    Global.ShowToastMessage("Try After Sometime.");
                }
            }
            else
            {
                Global.ShowToastMessage("Please Correct Errors.");
            }
        }
        #endregion
    }
}
