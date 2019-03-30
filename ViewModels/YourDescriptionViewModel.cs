using FlatmateFinders.Common;
using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for Occupants Page

    public class YourDescriptionViewModel : INotifyPropertyChanged
    {
        public bool _personalIntro, _pets, _personalqualities, _foodfurniture = false;
        public IEnumerable<ListButtonModel> _lenghtOfStayList,_adultsList,_genderList,_ageList,_employementList,_smokingList,_petList;

        
        public IEnumerable<ListButtonModel> StayList
        {
            get
            {
                return _lenghtOfStayList;
            }
            set
            {
                _lenghtOfStayList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> AdultsList
        {
            get
            {
                return _adultsList;
            }
            set
            {
                _adultsList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> GenderList
        {
            get
            {
                return _genderList;
            }
            set
            {
                _genderList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> AgeList
        {
            get
            {
                return _ageList;
            }
            set
            {
                _ageList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> EmployementList
        {
            get
            {
                return _employementList;
            }
            set
            {
                _employementList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> SmokingList
        {
            get
            {
                return _smokingList;
            }
            set
            {
                _smokingList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> PetList
        {
            get
            {
                return _petList;
            }
            set
            {
                _petList = value;
                OnPropertyChanged();
            }
        }

        public bool FoodFurniture
        {
            get
            {
                return _foodfurniture;
            }
            set
            {
                _foodfurniture = value;
                OnPropertyChanged();
            }
        }

        public bool PersonalIntro
        {
            get
            {
                return _personalIntro;
            }
            set
            {
                _personalIntro = value;
                OnPropertyChanged();
            }
        }

        public bool PersonalQualities
        {
            get
            {
                return _personalqualities;
            }
            set
            {
                _personalqualities = value;
                OnPropertyChanged();
            }
        }

        public bool Pets
        {
            get
            {
                return _pets;
            }
            set
            {
                _pets = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public YourDescriptionViewModel()
        {
            _personalIntro = true;

            StayList = FFCommon.StayListButtons;
            AdultsList = FFCommon.AdultListButtons;
            GenderList = FFCommon.GenderListButtons;
            PetList = FFCommon.PetListButtons;
            AgeList = FFCommon.AgeListButtons;
            EmployementList = FFCommon.EmployementListButtons;
            SmokingList = FFCommon.SmokingListButtons;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
