using BTM.MobileApp.ViewModels;
using BTM.Models;
using BTM.Models.Requests;
using Flurl.Http;
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
    public partial class HomePage : ContentPage
    {
        private HomepageViewModel model = null;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = model = new HomepageViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Media;
            if (item == null)
            {
                return;
            }

            var model = await $"{APIService._apiUrl}/MediaSearch/{item.MediaID}".GetJsonAsync<MediaDetailModel>();
            model.Poster = $"{APIService._apiUrl}/images/covers/{model.Id}";
            model.Rating = int.Parse(await $"{APIService._apiUrl}/MediaRatings?id={item.MediaID}&username={APIService.Username}".GetStringAsync());

            await Navigation.PushModalAsync(new NavigationPage(new MediaDetailPage(model)));
        }
    }
}