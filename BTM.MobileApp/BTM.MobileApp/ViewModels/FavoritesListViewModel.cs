using BTM.MobileApp.Models;
using BTM.Models;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTM.MobileApp.ViewModels
{
    public class FavoritesListViewModel
    {
        private APIService _listService = new APIService("Lists");
        public FavoritesListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<FavoritesItem> FavoritesList { get; set; } = new ObservableCollection<FavoritesItem>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _listService.Get<IEnumerable<BTM.Models.List>>(null);
            FavoritesList.Clear();

            foreach (var item in list)
            {
                User creator = await $"{APIService._apiUrl}/Users/{item.UserID}".GetJsonAsync<User>();

                IEnumerable<Media> moviesToAdd = await $"{APIService._apiUrl}/Lists/media/{item.ListID}"
                    //.WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<IEnumerable<Media>>();

                List<BTM.Models.Requests.MediaDetailModel> lst = new List<BTM.Models.Requests.MediaDetailModel>();
                foreach (var movie in moviesToAdd)
                {
                    var model = await $"{APIService._apiUrl}/MediaSearch/{movie.MediaID}".GetJsonAsync<BTM.Models.Requests.MediaDetailModel>();
                    model.Poster = $"{APIService._apiUrl}/images/covers/{model.Id}";
                    model.Rating = int.Parse(await $"{APIService._apiUrl}/MediaRatings?id={movie.MediaID}&username={APIService.Username}".GetStringAsync());


                    lst.Add(model);
                }
                

                FavoritesList.Add(new FavoritesItem
                {
                    Id = item.ListID,
                    Description = item.Description,
                    Name = item.Name,
                    UserID = item.UserID,
                    DateAdded = item.DateCreated,
                    Creator = creator.Username,
                    Movies = lst
                });

            }
        }
    }
}
