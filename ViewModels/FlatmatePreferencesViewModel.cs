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

    public class FlatmatePreferencesViewModel : INotifyPropertyChanged
    {
        public IEnumerable<ListButtonModel> _genderList,_ageList,_smokingList,_petList;
        
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

        
        public event PropertyChangedEventHandler PropertyChanged;

        public FlatmatePreferencesViewModel()
        {
            GenderList = FFCommon.GenderListButtons;
            PetList = FFCommon.PetListButtons;
            AgeList = FFCommon.AgeListButtons;
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
