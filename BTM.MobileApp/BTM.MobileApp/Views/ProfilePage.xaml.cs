using BTM.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTM.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {
        private UserPreviewViewModel model = null;

        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = model = new UserPreviewViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            APIService.Username = APIService.Password = "";

            //switch (Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            
            //        break;
            //    case Device.Android:

            //        break;
            //    case Device.UWP:

            //        break;
            //    default:
            //        break;
            //}
        }
    }
}