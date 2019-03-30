using System;
using System.IO;
using FlatmateFinders.Data;
using FlatmateFinders.Services;
using FlatmateFinders.Views;
using Xamarin.Forms;

namespace FlatmateFinders
{
    //This class called first when app executes
    public partial class App : Application
    {
        static FlatmateFindersDatabase database;

        public static FlatmateFindersDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new FlatmateFindersDatabase(
                      Path.Combine(DependencyService.Get<IFileHelper>().GetLocalFilePath("DBDemo.db3")));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            // Set Page you want to load after Splash Screen
            //Testing/Development
            //MainPage = new OfferingHomePage();

            //Uncomment this and comment previous line for Start App from begining
            MainPage = new TransitionNavigationPage(new LandingPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
