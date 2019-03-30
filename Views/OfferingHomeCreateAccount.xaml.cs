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
    public partial class OfferingHomeCreateAccount : ContentPage
    {
        public OfferingHomeCreateAccount()
        {
            InitializeComponent();

        }

        //Redirect to Facebook Login Page
        private async Task BtnSignupFacebook_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new FacebookProfilePage());
            await FFNavigation.PushAsync(Parent, Navigation, new FacebookProfilePage(), TransitionType.SlideFromRight);
        }

        //Redirect to Signup Email Page
        private async Task BtnSignupEmail_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new SignUpPage());
            await FFNavigation.PushAsync(Parent, Navigation, new SignUpPage(true), TransitionType.SlideFromRight);
        }

        //Redirect to Blank Page
        private async Task Button_Clicked(object sender, EventArgs e)
        {
            await FFNavigation.PushAsync(Parent, Navigation, new OfferingHomePricing(), TransitionType.SlideFromBottom);
            //await Navigation.PushAsync(new OfferingHomePricing());
        }

        //Redirect to Previous Page
        private async Task Back_Tapped(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();
            await FFNavigation.PopAsync(Parent, Navigation,TransitionType.SlideFromRight);
        }

        // Redirect to Login Page
        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            await FFNavigation.PushAsync(Parent, Navigation, new LoginPage(), TransitionType.SlideFromRight);
        }
    }
}