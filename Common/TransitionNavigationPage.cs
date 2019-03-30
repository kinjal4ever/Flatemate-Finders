
using FlatmateFinders;
using Xamarin.Forms;

namespace FlatmateFinders
{
    //Extended Navigation Page to Maintain Paging inside Application with Transition Animation
    public class TransitionNavigationPage : NavigationPage
    {
        public static readonly BindableProperty TransitionTypeProperty =
             BindableProperty.Create("TransitionType", typeof(TransitionType), typeof(TransitionNavigationPage), TransitionType.SlideFromLeft);

        public TransitionType TransitionType
        {
            get { return (TransitionType)GetValue(TransitionTypeProperty); }
            set { SetValue(TransitionTypeProperty, value); }
        }

        public TransitionNavigationPage() : base()
        {
        }

        public TransitionNavigationPage(Page root) : base(root)
        {
        }
    }
}
