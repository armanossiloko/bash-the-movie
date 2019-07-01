using BTM.MobileApp.Models;
using BTM.Models;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTM.MobileApp.ViewModels
{
    public class HomepageViewModel : INotifyPropertyChanged
    {
        APIService _mediaService = new APIService("Media");

        public HomepageViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<ListItem> RecommendedMovies { get; set; } = new ObservableCollection<ListItem>();

        public ObservableCollection<Media> BudgetMovies { get; set; } = new ObservableCollection<Media>();

        private string _TopBudgetMovie;
        public string TopBudgetMovie
        {
            get
            {
                return _TopBudgetMovie;
            }
            set
            {
                if (_TopBudgetMovie != value)
                {
                    _TopBudgetMovie = value;
                    OnPropertyChanged("TopBudgetMovie");
                }
            }
        }

        public ObservableCollection<Media> BoxOfficeMovies { get; set; } = new ObservableCollection<Media>();

        private string _TopBoxOfficeMovie;
        public string TopBoxOfficeMovie
        {
            get
            {
                return _TopBoxOfficeMovie;
            }
            set
            {
                if (_TopBoxOfficeMovie != value)
                {
                    _TopBoxOfficeMovie = value;
                    OnPropertyChanged("TopBoxOfficeMovie");
                }
            }
        }

        public ICommand InitCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async Task Init()
        {
            User loggedInUser = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}".GetJsonAsync<User>();

            var recommendedMovies = await $"{APIService._apiUrl}/Recommendations/{loggedInUser.Id}".GetJsonAsync<IEnumerable<Media>>();

            var budgetMovies = await _mediaService.Get<IEnumerable<Media>>(null);
            var boxOfficeMovies = await _mediaService.Get<IEnumerable<Media>>(null);
            budgetMovies = budgetMovies.OrderByDescending(x => x.Budget).Take(10);
            boxOfficeMovies = boxOfficeMovies.OrderByDescending(x => x.WorldwideGross).Take(10);

            BoxOfficeMovies.Clear();
            foreach (var item in boxOfficeMovies)
            {
                BoxOfficeMovies.Add(item);
            }
            TopBoxOfficeMovie = $"{APIService._apiUrl}/images/covers/{boxOfficeMovies.ElementAt(0).MediaID}";

            BudgetMovies.Clear();
            foreach (var item in budgetMovies)
            {
                BudgetMovies.Add(item);
            }
            TopBudgetMovie = $"{APIService._apiUrl}/images/covers/{budgetMovies.ElementAt(0).MediaID}";


            RecommendedMovies.Clear();
            foreach (var item in recommendedMovies)
            {
                RecommendedMovies.Add(new ListItem
                {
                    Id = item.MediaID,
                    Title = item.Title,
                    Description = item.Synopsis,
                    Image = $"{APIService._apiUrl}/images/covers/{item.MediaID}"
                });
            }
        }
    }
}
