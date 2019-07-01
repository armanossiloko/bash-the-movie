using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BTM.MobileApp.Services;
using BTM.MobileApp.Views;

namespace BTM.MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense("yourapikey");


            InitializeComponent();

            DependencyService.Register<MockDataStore>();

            MainPage = new LoginPage();
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
