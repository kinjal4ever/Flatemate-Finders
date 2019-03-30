using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for Select Location Page

    public class SelectLocationViewModel
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
        public SelectLocationViewModel()
        {
            Locations = new List<string>
            {
                "18 Bobart Street Parramatta NSW",
                "18 Bourke Street Woolloomooloo NSW",
                "18 Bourke Road Alexandaria NSW",
                "18 Bondi Road Bondi Junction NSW",
                "18 Bondi Road Northmead NSW"
            };
            Locations = LocationList;

        }

        void OnPropertyChange([CallerMemberName]string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
