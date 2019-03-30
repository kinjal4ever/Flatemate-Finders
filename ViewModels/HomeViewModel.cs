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
    //View Model for Home Page
    public class HomeViewModel : INotifyPropertyChanged
    {
        #region Properties
        private readonly ILoginService _loginService;
        public IEnumerable<ListButtonModel> _parkingList, _hometypelist, _homeSizeList;


        public IEnumerable<ListButtonModel> HomeTypeList
        {
            get
            {
                return _hometypelist;
            }
            set
            {
                _hometypelist = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> HomeSizeList
        {
            get
            {
                return _homeSizeList;
            }
            set
            {
                _homeSizeList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> ParkingList
        {
            get
            {
                return _parkingList;
            }
            set
            {
                _parkingList = value;
                OnPropertyChanged();
            }
        }
        public string Search { get; set; }
        public string Feature { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string OldSearch { get; set; }
        public string OldFeature { get; set; }
        public string Lastname { get; set; }
        #endregion

        public HomeViewModel()
        {
            HomeTypeList = FFCommon.HomeTypeListButtons;
            HomeSizeList = FFCommon.HomeSizeListButtons;
            ParkingList = FFCommon.OffStreetListButtons;

            _loginService = new LoginService();
            Task<FFUsers> opt = Task.Run(() =>
             {
                 return _loginService.GetLoggedInUser();
             });

            if (opt != null)
            {
                //this.Firstname = opt.Result.FirstName;
                //this.Lastname = opt.Result.Lastname;
                //this.Email = opt.Result.Email;
            }
        }

        #region PropertyChange 
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        #endregion
    }
}
