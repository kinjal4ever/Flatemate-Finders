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
    public partial class LookingForHomePage : FFTabbedPage
    {
        readonly Xamarin.Forms.Page tabDescription;
        
        // Main Tabbed Page
        public LookingForHomePage()
        {
            InitializeComponent();

            tabDescription = new TabbedYourDescription() { Icon = "iconPagingOccupant.png" };
            Children.Add(tabDescription);
            Children.Add(new TabbedYourDescription() { Icon = "iconLocation.png" });
            Children.Add(new TabbedHomePreferences() { Icon = "iconHome.png" });
            Children.Add(new TabbedFlatmatePreferences() { Icon = "iconPagingOccupant.png" });
            Children.Add(new TabbedPhotosLookingForHome() { Icon = "iconUploadPhotos.png" });
        }

        //Event for Switching page between tabs
        public void SwitchToTabPage(int pageIndex)
        {
            CurrentPage = Children[pageIndex];
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}