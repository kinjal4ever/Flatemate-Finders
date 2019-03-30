using FlatmateFinders;
using FlatmateFinders.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FlatmateFinders.Views
{
    //Landing or Startup page after splash screen
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LandingPage : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public LandingPage()
        {
            InitializeComponent();

            //Set Slider Info to Display
            MyItemsSource = new ObservableCollection<Slide>()
            {
                new Slide() {Title = "" , SubTitle = "We Find Your",Description1="Perfect Flatmates",Description2="",Image="f1Flatmates.png",IsImageInsideText=true,IsImageWithText=false },
                new Slide() {Title = "Personalised Matching" , SubTitle = "Review your perfect match",Description1="Say hello to a personalised shortlist of profiles",Description2="that match with you. Perfectly.",Image="introducting.png" ,IsImageInsideText=false,IsImageWithText=true},
                new Slide() {Title="Informative Profiles",SubTitle="Easily decide who to meet",Description1="Profiles full of relevant details help you find",Description2="the right flatmate. Without the guesswork.",Image="profileDetails.png",IsImageInsideText=false,IsImageWithText=true},
                new Slide() {Title="Instant Contacts",SubTitle="Connect at the speed of light",Description1="Quickly set up interviews with the right",Description2="people. And smash your deadline.",Image="messenger.png",IsImageInsideText=false,IsImageWithText=true}
            };

            // Set Command which slider position is selected
            MyCommand = new Command(() =>
            {
                Debug.WriteLine("Position selected.");
            });

            BindingContext = this;
        }

        //Model for Slider
        ObservableCollection<Slide> _myItemsSource;
        public ObservableCollection<Slide> MyItemsSource
        {
            set
            {
                _myItemsSource = value;
                OnPropertyChanged("MyItemsSource");
            }
            get
            {
                return _myItemsSource;
            }
        }

        //Model for Slider Command/Position
        public Command MyCommand { protected set; get; }

        // Change Value on Slider swipe
        protected override void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Redireect to Login Page
        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new LoginPage());
            await FFNavigation.PushAsync(Parent, Navigation, new LoginPage(), TransitionType.SlideFromRight);
        }

        // Redirect to Select Type Page
        private async void BtnAccount_Clicked(object sender, EventArgs e)
        {
            await FFNavigation.PushAsync(Parent, Navigation, new SelectTypePage(), TransitionType.SlideFromRight);
            //await Navigation.PushModalAsync(new SelectTypePage(), false);
        }
    }

    public class NegateBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }
    }
}