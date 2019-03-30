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
	public partial class ContactUsPage : ContentPage
	{
		public ContactUsPage ()
		{
			InitializeComponent ();
		}

        //Previous Page Event
        private async void Back_Tapped(object sender, EventArgs e)
        {
            //Navigation.PopModalAsync(true);
            await FFNavigation.PopAsync(Parent, Navigation, TransitionType.SlideFromRight);
        }
    }
}