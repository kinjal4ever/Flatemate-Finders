using FlatmateFinders.Common;
using FlatmateFinders.Services;
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
	public partial class AddBedRoom : ContentPage
	{
        BedRoomViewModel bedroomViewModel;

        public AddBedRoom (string features="")
		{
			InitializeComponent ();
            BindingContext = bedroomViewModel = new BedRoomViewModel();
            bedroomViewModel.Features = features;
        }

        //One of List Button Clicked event
        private void ListButton_Clicked(object sender, EventArgs e)
        {
            var button = ((Button)sender);
            var btnText = button.Text;

            if (button.StyleId == "BillList")
                bedroomViewModel.BillList = FFCommon.UpdateButtonList(bedroomViewModel.BillList.ToList(), btnText);
            else if (button.StyleId == "BondList")
                bedroomViewModel.BondList = FFCommon.UpdateButtonList(bedroomViewModel.BondList.ToList(), btnText);
            else if (button.StyleId == "BedroomSizeList")
                bedroomViewModel.BedroomSizeList = FFCommon.UpdateButtonList(bedroomViewModel.BedroomSizeList.ToList(), btnText);
            else if (button.StyleId == "BedroomFurnitureList")
                bedroomViewModel.BedroomFurnitureList = FFCommon.UpdateButtonList(bedroomViewModel.BedroomFurnitureList.ToList(), btnText);
            else if (button.StyleId == "NoOfBedList")
                bedroomViewModel.NoOfBedList = FFCommon.UpdateButtonList(bedroomViewModel.NoOfBedList.ToList(), btnText);
            else if (button.StyleId == "BathroomfaciliteiesList")
                bedroomViewModel.BathroomfaciliteiesList = FFCommon.UpdateButtonList(bedroomViewModel.BathroomfaciliteiesList.ToList(), btnText);
        }


        //Shared Button  Clicked Event
        private void Shared_Clicked(object sender, EventArgs e)
        {
            bedroomViewModel.IsShared = true;
        }


        //Private Button  Clicked Event
        private  void Private_Clicked(object sender, EventArgs e)
        {
            bedroomViewModel.IsShared = false;
        }

        // Done Button/Close Button Event
        private async void BtnDone_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void ListFrame_Tapped(object sender, EventArgs e)
        {
            var frameText = ((Label)((StackLayout)((Frame)sender).Content).Children[0]).Text;
            bedroomViewModel.BedroomSizeList = FFCommon.UpdateButtonList(bedroomViewModel.BedroomSizeList.ToList(), frameText);
        }

        private async void BedroomFeatures_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BedroomFeatures(bedroomViewModel.Features));
        }
    }
}