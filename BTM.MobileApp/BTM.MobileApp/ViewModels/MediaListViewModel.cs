using BTM.MobileApp.Models;
using BTM.Models;
using BTM.Models.Extensions;
using BTM.Models.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTM.MobileApp.ViewModels
{
    public class MediaListViewModel : BaseViewModel
    {
        //private readonly APIService _mediaService = new APIService("Media");
        private readonly APIService _genreService = new APIService("Genres");
        public MediaListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<ListItem> MediaList { get; set; } = new ObservableCollection<ListItem>();
        public ObservableCollection<Genre> MovieGenres { get; set; } = new ObservableCollection<Genre>();

        public string MovieTitle { get; set; } = "";
        public string Year { get; set; } = "";

        Genre genre = null;
        public Genre SelectedGenre
        {
            get
            {
                return genre;
            }
            set
            {
                SetProperty(ref genre, value);
            }
        }

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            try
            {
                if (Year == "")
                {
                    Year = "0";
                }
                int.Parse(Year);
            }
            catch
            {
                await Application.Current.MainPage.DisplayAlert("Error",
                        "The year must be a number!", "OK");
                return;
            }

            if (MovieGenres.Count == 0)
            {
                MovieGenres.Add(new Genre { GenreID = 0, Name = "None" });
                var serviceReturns = await _genreService.Get<List<Genre>>(null);

                foreach (var item in serviceReturns)
                {
                    MovieGenres.Add(item);
                }
            }
            MediaList.Clear();

            int GenreID = 0;
            try
            {
                GenreID = SelectedGenre.GenreID;
            }
            catch
            {
                GenreID = 0;
            }


            MediaSearchRequest request = new MediaSearchRequest
            {
                GenreID = GenreID,
                Title = MovieTitle,
                Year = int.Parse(Year)
            };
            string query = await request.ToQueryString();
            var list = await $"{APIService._apiUrl}/MediaSearch?{query}".GetJsonAsync<IEnumerable<Media>>();
            
            foreach (var item in list)
            {
                if (item.MediaID != 1)
                {
                    MediaList.Add(new ListItem
                    {
                        Id = item.MediaID,
                        Title = item.Title,
                        Description = item.Synopsis,
                        Image = $"{APIService._apiUrl}/images/covers/{item.MediaID}",
                        Rating = int.Parse(await $"{APIService._apiUrl}/MediaRatings?id={item.MediaID}&username={APIService.Username}".GetStringAsync())
                    });
                }
            }
        }
    }
}
