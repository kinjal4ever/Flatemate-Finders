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
    //Login Page
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        LoginViewModel loginViewModel;
		public LoginPage ()
		{
			InitializeComponent ();

            // Binding login Model to View
            BindingContext = loginViewModel = new LoginViewModel(Navigation);
        }

        // Redirect to Login Fb Page
        private async void BtnLoginFB_Clicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new FacebookProfilePage());
            await FFNavigation.PushAsync(Parent, Navigation, new FacebookProfilePage(), TransitionType.SlideFromBottom);

        }

        // Redirect to Sign Up Page
        private async void BtnRegister_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new SignUpPage());
            await FFNavigation.PushAsync(Parent, Navigation, new SelectTypePage(), TransitionType.SlideFromRight);

        }

        // Redirect to Blank Page
        private async Task Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new FAQsPage());
            await FFNavigation.PushAsync(Parent, Navigation, new FAQsPage(), TransitionType.SlideFromBottom);
        }

        // Redirect to Previous Page
        private async Task Back_Tapped(object sender, EventArgs e)
        {
            //await Navigation.PopAsync(true);
            await FFNavigation.PopAsync(Parent, Navigation,  TransitionType.SlideFromRight);
        }

        private async Task BtnForgot_Tapped(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new ResetPage());
            await FFNavigation.PushAsync(Parent, Navigation, new ResetPage(), TransitionType.SlideFromBottom);

        }
    }
}