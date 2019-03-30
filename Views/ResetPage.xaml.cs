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
	public partial class ResetPage : ContentPage
	{
		public ResetPage ()
		{
			InitializeComponent ();
		}

        // Redirect to Previous Page
        private async void Back_Tapped(object sender, EventArgs e)
        {
            //Navigation.PopModalAsync(true);
            await FFNavigation.PopAsync(Parent, Navigation, TransitionType.SlideFromBottom);
        }
    }
}