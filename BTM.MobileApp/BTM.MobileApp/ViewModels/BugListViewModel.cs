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
    public class BugListViewModel
    {
        APIService _bugsService = new APIService("Bugs");
        public BugListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Bug> BugList { get; set; } = new ObservableCollection<Bug>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _bugsService.Get<IEnumerable<Bug>>(null);
            //User loggedInUser = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}"
            //    .GetJsonAsync<User>();
            BugList.Clear();

            foreach (var item in list)
            {
                BugList.Add(item);
            }
        }
    }
}
