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
    public partial class MediaDetailPage : ContentPage
    {
        private MediaDetailModel model = null;
        private APIService _ratingsService = new APIService("MediaRatings");

        public MediaDetailPage(MediaDetailModel viewModel)
        {
            InitializeComponent();

            BindingContext = model = viewModel;

            rating.Value = model.Rating;
        }

        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Rating_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {
            try
            {
                var user = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}".GetJsonAsync<User>();

                MediaRatingInputModel obj = new MediaRatingInputModel
                {
                    MediaID = model.Id,
                    Rating = int.Parse(rating.Value.ToString()),
                    UserID = user.Id
                };

                if (model.Rating == 0) // Needs adding
                {
                    await _ratingsService.Insert<MediaUser>(obj);
                }
                else // Needs updating
                {
                    await $"{APIService._apiUrl}/MediaRatings"
                        .WithBasicAuth(APIService.Username, APIService.Password)
                        .PutJsonAsync(obj);
                }
            }
            catch
            {
                return;
            }
            
        }

        private async void AddToFavoritesClicked(object sender, EventArgs e)
        {
            User user = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}".GetJsonAsync<User>();
            List<BTM.Models.List> Lists  = new List<BTM.Models.List>();
            IEnumerable<List> lists = await $"{APIService._apiUrl}/Lists/users/{user.Id}".GetJsonAsync<IEnumerable<List>>();

            foreach (var item in lists)
            {
                Lists.Add(item);
            }

            await Navigation.PushModalAsync(new NavigationPage(new AddMovieToList(model, Lists)));
        }
    }
}