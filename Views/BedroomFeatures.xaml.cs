using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatmateFinders.Models;
using FlatmateFinders.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlatmateFinders.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BedroomFeatures : ContentPage
	{
        string features = "";
        BedroomFeatureViewModel bedroomFeaturesViewModel;
		public BedroomFeatures(string featureResults = "")
		{
            features = featureResults;
			InitializeComponent ();
            BindingContext = bedroomFeaturesViewModel = new BedroomFeatureViewModel();
        }

        //Previous Page Event
        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }

        // 
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var entity = ((Grid)sender);
            entity.BackgroundColor = (Color)Application.Current.Resources["clean"];
        }

        //Done Button Event
        private void BtnDone_Clicked(object sender, EventArgs e)
        {
            features = bedroomFeaturesViewModel.Features.Where(x=>x.IsChecked ==true).Count() + " features selected";
            Navigation.PushModalAsync(new AddBedRoom(features));
        }

        //Check Uncheck Features on Checkbox Checked Event
        private void HomeFeaturesListview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            FeaturesModel feature = e.Item as FeaturesModel;
            var vm = BindingContext as BedroomFeatureViewModel;
            vm?.CheckUncheckFeature(feature);
        }
    }
}