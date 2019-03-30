using FlatmateFinders.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace FlatmateFinders.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectLocation : ContentPage
    {
        SelectLocationViewModel locationViewModel;
        string search, features = "";
        public SelectLocation(string searchResults = "", string featureResults = "")
        {
            InitializeComponent();
            search = searchResults;
            features = featureResults;
            locationViewModel = new SelectLocationViewModel();
            LocationListview.ItemsSource = locationViewModel.Locations;
        }

        //Search bar Text Change Event
        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            var keyword = ((Entry)sender).Text;
            var selectedList = locationViewModel.Locations.Where(x => x.Contains(keyword)).ToList();
            LocationListview.ItemsSource = selectedList;
        }

        // Redirect to Previous Page
        private void Back_Tapped(object sender, EventArgs e)
        {
            Navigation.PopModalAsync(true);
        }

        // Selt Seleted Location
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var entity = ((StackLayout)sender);
            entity.BackgroundColor = (Color)Application.Current.Resources["PrimaryFormBackground"];
            string label = ((Label)entity.Children[1]).Text;
            Navigation.PushModalAsync(new OfferingHomePage(0,label,features));
        }
    }
}