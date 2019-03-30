using FlatmateFinders.Common;
using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for Home Features Page

    public class BedroomFeatureViewModel
    {
        private FeaturesModel _oldFeature;
        public ObservableCollection<FeaturesModel> Features { get; set; }

        public BedroomFeatureViewModel()
        {
            Features = FFCommon.BedroomFeatures;
        }

        public void CheckUncheckFeature(FeaturesModel f)
        {
            var Index = Features.IndexOf(f);
            f.IsChecked = !f.IsChecked;
            Features.Remove(f);
            Features.Insert(Index, f);
        }

    }
}
