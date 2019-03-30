using FlatmateFinders.Controls;
using FlatmateFinders.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlatmateFinders.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OfferingHomePage : FFTabbedPage
    {
        readonly Xamarin.Forms.Page tabHome,tabOccupants,tab;
        
        // Main Tabbed Page
        public OfferingHomePage(int pageIndex=0,string searchText = "",string features = "")
        {
            InitializeComponent();

            tabHome = new TabbedHome(searchText,features) { Icon = "iconHome.png" };
            tabOccupants = new TabbedOccupants() { Icon = "iconPagingOccupant.png" };
            Children.Add(tabHome);
            Children.Add(new TabbedBedRoom() { Icon = "iconBed.png" });
            Children.Add(tabOccupants);
            Children.Add(new TabbedPhotos() { Icon = "iconUploadPhotos.png" });
            Children.Add(new TabbedOfferingFlatmatePreference() { Icon = "iconpreference.png" });

            SwitchToTabPage(pageIndex);

            //BindingContext = new HomeViewModel();
        }

        //Event for Switching page between tabs
        public void SwitchToTabPage(int pageIndex)
        {
            CurrentPage = Children[pageIndex];
        }

        //Event for Switching to Occupants Page
        public void SwitchToTabOccupants()
        {
            CurrentPage = tabOccupants;
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

    }
}