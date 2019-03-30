using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlatmateFinders.Views
{
    //Create Account Page
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccount : ContentPage
	{
		public CreateAccount ()
		{
			InitializeComponent ();

        }

        //Redirect to Facebook Login Page
        private async void BtnSignupFacebook_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new FacebookProfilePage());
            await FFNavigation.PushAsync(Parent, Navigation, new FacebookProfilePage(), TransitionType.SlideFromRight);
        }

        //Redirect to Signup Email Page
        private async void BtnSignupEmail_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new SignUpPage());
            await FFNavigation.PushAsync(Parent, Navigation, new SignUpPage(false), TransitionType.SlideFromRight);
        }

        //Redirect to Blank Page
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new PricingPage());
            await FFNavigation.PushAsync(Parent, Navigation, new PricingPage(), TransitionType.SlideFromBottom);
        }

        //Redirect to Previous Page
        private async void Back_Tapped(object sender, EventArgs e)
        {
           //await Navigation.PopAsync();
           await FFNavigation.PopAsync(Parent, Navigation, TransitionType.SlideFromRight);
        }
    }
}