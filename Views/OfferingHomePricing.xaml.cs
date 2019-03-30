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
	public partial class OfferingHomePricing : ContentPage
	{
		public OfferingHomePricing ()
		{
			InitializeComponent ();
		}

        //Previous Page Event
        private async Task TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await FFNavigation.PopAsync(Parent, Navigation, TransitionType.SlideFromBottom);
            //Navigation.PopModalAsync(true);
        }
    }
}