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
    public class FeedbackListViewModel
    {
        APIService _feedbackService = new APIService("Feedback");
        public FeedbackListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<FeedbackPreviewModel> IdeaList { get; set; } = new ObservableCollection<FeedbackPreviewModel>();
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            var list = await _feedbackService.Get<IEnumerable<Feedback>>(null);
            IdeaList.Clear();

            foreach (var item in list)
            {
                string submitter = await $"{APIService._apiUrl}/submitters/ideas/{item.Id}"
                    .GetStringAsync();

                var model = new FeedbackPreviewModel
                {
                    Addressed = item.Addressed,
                    Content = item.Content,
                    DateAdded = item.DateAdded,
                    Id = item.Id,
                    Name = item.Name,
                    User = submitter,
                    UserID = item.UserID
                };

                IdeaList.Add(model);
            }
        }
    }
}
