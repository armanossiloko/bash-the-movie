using BTM.MobileApp.Models;
using BTM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace BTM.MobileApp.ViewModels
{
    public class NewsListViewModel
    {
        private readonly APIService _newsService = new APIService("News");
        public NewsListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<ListItem> NewsList { get; set; } = new ObservableCollection<ListItem>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _newsService.Get<IEnumerable<News>>(null);
            NewsList.Clear();

            foreach (var item in list)
            {
                NewsList.Add(new ListItem
                {
                    Id = item.Id,
                    Title = item.Title,
                    Description = item.Description,
                    Image = $"{APIService._apiUrl}/news/image/{item.Id}"
                });
            }
        }
    }
}
