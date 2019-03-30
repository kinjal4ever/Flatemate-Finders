using FlatmateFinders.Models;
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
	public partial class FAQsPage : ContentPage
	{
       

        public FAQsPage ()
		{
            InitializeComponent();
        }

        // Redirect to Previous Page
        async Task Back_Tapped(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();
            await FFNavigation.PopAsync(Parent, Navigation, TransitionType.SlideFromBottom);
        }

        private async Task Contact_Tapped(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new ContactUsPage());
            await FFNavigation.PushAsync(Parent, Navigation, new ContactUsPage(), TransitionType.SlideFromRight);
        }

        private void ListViewItem_Tabbed(object sender, ItemTappedEventArgs e)
        {
            var product = e.Item as FAQ;
            var vm = BindingContext as FAQViewModel;
            vm?.ShoworHiddenProducts(product);
        }

    }
}