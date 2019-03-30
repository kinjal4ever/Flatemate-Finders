using FlatmateFinders.Common;
using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FlatmateFinders.ViewModels
{
    //View Model for Bedroom Page 

    public class BedRoomViewModel : INotifyPropertyChanged
    {
        public bool shared = false;
        public bool isRoomAdded = false;
        public string features = "";
        public IEnumerable<ListButtonModel> _billList, _bondList, _bedroomSizeList, _bedroomFurnitureList, _bathroomfaciliteiesList, _noOfBedsList;


        public IEnumerable<ListButtonModel> BillList
        {
            get
            {
                return _billList;
            }
            set
            {
                _billList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> BondList
        {
            get
            {
                return _bondList;
            }
            set
            {
                _bondList = value;
                OnPropertyChanged();
            }
        }

        public string Features
        {
            get
            {
                return features;
            }
            set
            {
                features = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> BathroomfaciliteiesList
        {
            get
            {
                return _bathroomfaciliteiesList;
            }
            set
            {
                _bathroomfaciliteiesList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> NoOfBedList
        {
            get
            {
                return _noOfBedsList;
            }
            set
            {
                _noOfBedsList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> BedroomFurnitureList
        {
            get
            {
                return _bedroomFurnitureList;
            }
            set
            {
                _bedroomFurnitureList = value;
                OnPropertyChanged();
            }
        }

        public IEnumerable<ListButtonModel> BedroomSizeList
        {
            get
            {
                return _bedroomSizeList;
            }
            set
            {
                _bedroomSizeList = value;
                OnPropertyChanged();
            }
        }

        public bool IsShared
        {
            get { return shared; }
            set
            {
                shared = value;
                OnPropertyChanged();
            }
        }

        public bool IsRoomAdded
        {
            get { return IsRoomAdded; }
            set
            {
                isRoomAdded = value;
                OnPropertyChanged();
            }
        }

        public BedRoomViewModel() {
            BillList = FFCommon.IncludeBillsListButtons;
            BondList = FFCommon.BondListButtons;
            BedroomSizeList = FFCommon.BedroomSizeListButton;
            BedroomFurnitureList = FFCommon.BedroomFurnitureListButton;
            NoOfBedList = FFCommon.NumberOfBedsListButton;
            BathroomfaciliteiesList = FFCommon.BathroomFacilitiesListButton;
            IsShared = true;
        }

        #region PropertyChange 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion
    }
}
