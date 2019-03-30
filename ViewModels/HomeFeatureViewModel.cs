using FlatmateFinders.Common;
using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FlatmateFinders.ViewModels
{
    //View Model for Home Features Page

    public class HomeFeaturesViewModel
    {
        public ObservableCollection<FeaturesModel> Features { get; set; }

        public HomeFeaturesViewModel()
        {
            Features = FFCommon.HomeFeatures;
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
