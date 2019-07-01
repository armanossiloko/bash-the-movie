using BTM.MobileApp.Models;
using BTM.MobileApp.ViewModels;
using BTM.Models;
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
    public partial class NewsPage : ContentPage
    {
        private NewsListViewModel model = null;

        public NewsPage()
        {
            InitializeComponent();
            BindingContext = model = new NewsListViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as ListItem;
            if (item == null)
                return;

            var news = await $"{APIService._apiUrl}/News/{item.Id}".GetJsonAsync<News>();
            string submitter = await $"{APIService._apiUrl}/Submitters/news/{news.Id}".GetStringAsync();
            //$"{APIService._apiUrl}/news/image/{item.Id}"

            NewsPreviewModel model = new NewsPreviewModel
            {
                Image = $"{APIService._apiUrl}/news/image/{news.Id}",
                Name = news.Title,
                DateAdded = news.DateAdded,
                Description = news.Content,
                Submitter = submitter
            };

            await Navigation.PushModalAsync(new NavigationPage(new NewsDetailsPage(model)));
        }
    }
}