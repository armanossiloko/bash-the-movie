using BTM.MobileApp.Models;
using BTM.MobileApp.ViewModels;
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
    public partial class MediaPage : ContentPage
    {
        private MediaListViewModel model = null;

        public MediaPage()
        {
            InitializeComponent();
            BindingContext = model = new MediaListViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Search_Clicked(object sender, EventArgs e)
        {
            await model.Init();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as ListItem;
            if (item == null)
            {
                return;
            }
            
            var model = await $"{APIService._apiUrl}/MediaSearch/{item.Id}".GetJsonAsync<MediaDetailModel>();
            model.Poster = $"{APIService._apiUrl}/images/covers/{model.Id}";
            model.Rating = item.Rating;

            await Navigation.PushModalAsync(new NavigationPage(new MediaDetailPage(model)));
        }
    }
}