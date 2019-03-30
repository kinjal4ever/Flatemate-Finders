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
	public partial class HomeFeatures : ContentPage
	{
        string search, features = "";
        HomeFeaturesViewModel homeFeaturesViewModel;
		public HomeFeatures (string searchResults = "", string featureResults = "")
		{
            search = searchResults;
            features = featureResults;
			InitializeComponent ();
            BindingContext = homeFeaturesViewModel = new HomeFeaturesViewModel();
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
            features = homeFeaturesViewModel.Features.Where(x=>x.IsChecked ==true).Count() + " features selected";
            Navigation.PushModalAsync(new OfferingHomePage(0, search, features));
        }

        //Check Uncheck Features on Checkbox Checked Event
        private void HomeFeaturesListview_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            FeaturesModel feature = e.Item as FeaturesModel;
            var vm = BindingContext as HomeFeaturesViewModel;
            vm?.CheckUncheckFeature(feature);
        }
    }
}