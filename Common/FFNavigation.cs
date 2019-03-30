using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FlatmateFinders;
using Xamarin.Forms;

namespace FlatmateFinders
{
    //Custom Navigation for Transition of Pages with Animation from Bottom/Top etc.
    public class FFNavigation
    {

        //Navigation to Other Page
        public static async Task PushAsync(Element Parent, INavigation Navigation, Page page, TransitionType transitionType)
        {
            var transitionNavigationPage = Parent as TransitionNavigationPage;

            if (transitionNavigationPage != null)
            {
                transitionNavigationPage.TransitionType = transitionType;
                await Navigation.PushAsync(page);
            }
        }

        //Navigation to Previous Page
        public static async Task PopAsync(Element Parent, INavigation Navigation, TransitionType transitionType)
        {
            var transitionNavigationPage = Parent as TransitionNavigationPage;

            if (transitionNavigationPage != null)
            {
                transitionNavigationPage.TransitionType = transitionType;
                await Navigation.PopAsync();
            }
        }

    }
}
