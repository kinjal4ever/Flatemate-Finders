using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for Select Location Page

    public class SelectLocationLookingForViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<string> LocationList { get; set; }
        public List<string> Locations
        {
            get { return LocationList; }
            set
            {
                LocationList = value;
                OnPropertyChange();
            }
        }
        public SelectLocationLookingForViewModel()
        {
            Locations = new List<string>
            {
                "Paddington, Sydney, NSW 2021",
                "Parramatta, Sydney, NSW 2150",
                "Paddington, Brisbane, QLD, 4064",
                "Parkville, Melbourne, VIC, 3052",
                "Palm Beach, Gold Coast, QLD 4221"
            };
            Locations = LocationList;

        }

        void OnPropertyChange([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
