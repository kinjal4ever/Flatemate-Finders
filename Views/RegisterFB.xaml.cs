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
	public partial class RegisterFB : ContentPage
	{
		public RegisterFB ()
		{
			InitializeComponent ();
		}

        // Redirect to Facebook Login Page
        private async void BtnFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FacebookProfilePage());
        }
    }
}