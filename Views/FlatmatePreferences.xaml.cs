using FlatmateFinders.Common;
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
	public partial class FlatmatePreferences : ContentPage
	{
        FlatmatePreferencesViewModel flatmatePreferencesViewModel;
        public FlatmatePreferences ()
		{
			InitializeComponent ();
            BindingContext = flatmatePreferencesViewModel = new FlatmatePreferencesViewModel();
        }


        //Previous Page event
        private async Task Back_Tapped(object sender, EventArgs e)
        {
            await FFNavigation.PopAsync(Parent, Navigation, TransitionType.SlideFromRight);
        }

        //One of List Button Clicked event
        private void ListButton_Clicked(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            var btnText = button.Text;

            if (button.StyleId == "GenderList")
                flatmatePreferencesViewModel.GenderList = FFCommon.UpdateButtonList(flatmatePreferencesViewModel.GenderList.ToList(), btnText);
            else if (button.StyleId == "AgeList")
                flatmatePreferencesViewModel.AgeList = FFCommon.UpdateButtonList(flatmatePreferencesViewModel.AgeList.ToList(), btnText);
            else if (button.StyleId == "SmokingList")
                flatmatePreferencesViewModel.SmokingList = FFCommon.UpdateButtonList(flatmatePreferencesViewModel.SmokingList.ToList(), btnText);
            else if (button.StyleId == "PetList")
                flatmatePreferencesViewModel.PetList = FFCommon.UpdateButtonList(flatmatePreferencesViewModel.PetList.ToList(), btnText);
        }
    }
}