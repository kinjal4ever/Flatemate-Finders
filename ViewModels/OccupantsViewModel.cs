using FlatmateFinders.Common;
using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for Occupants Page

    public class OccupantsViewModel : INotifyPropertyChanged
    {
        public bool _personalIntro, _pets, _personalqualities, _isLivingHome = false;

        public IEnumerable<ListButtonModel> _genderList, _ageList, _smokingList, _petList;

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



        public bool IsLivingHome
        {
            get
            {
                return _isLivingHome;
            }
            set
            {
                _isLivingHome = value;
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

        public OccupantsViewModel() {
            GenderList = FFCommon.GenderListButtons;
            PetList = FFCommon.PetListButtons;
            AgeList = FFCommon.AgeListButtons;
            SmokingList = FFCommon.SmokingListButtons;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
