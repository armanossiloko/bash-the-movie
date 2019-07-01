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
    public class SupportListViewModel
    {
        APIService _ticketService = new APIService("Support");
        APIService _userService = new APIService("Users");
        public SupportListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<TicketPreviewModel> TicketList { get; set; } = new ObservableCollection<TicketPreviewModel>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            User loggedInUser = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}"
                .GetJsonAsync<User>();

            var list = await $"{APIService._apiUrl}/Support/users/{loggedInUser.Id}"
                .WithBasicAuth(APIService.Username, APIService.Password)
                .GetJsonAsync<IEnumerable<Ticket>>();
            TicketList.Clear();

            foreach (var item in list)
            {
                if (item.UserID == loggedInUser.Id)
                {
                    string submitter = await $"{APIService._apiUrl}/submitters/support/{item.Id}"
                        .GetStringAsync();

                    var model = new TicketPreviewModel
                    {
                        Content = item.Content,
                        DateAdded = item.DateAdded,
                        Id = item.Id,
                        Resolved = item.Resolved,
                        Title = item.Title,
                        User = submitter,
                        UserID = item.UserID
                    };

                    TicketList.Add(model);
                }
            }
        }
    }
}
