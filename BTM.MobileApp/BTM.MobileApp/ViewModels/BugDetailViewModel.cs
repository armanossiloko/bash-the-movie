using BTM.MobileApp.Models;
using BTM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.MobileApp.ViewModels
{
    public class BugDetailViewModel : BaseViewModel
    {
        public BugPreviewModel Item { get; set; }
        public BugDetailViewModel(Bug bug = null)
        {
            Title = bug?.Title;

            if (bug != null)
            {
                Item = new BugPreviewModel
                {
                    Id = bug.Id,
                    DateAdded = bug.DateAdded,
                    Description = bug.Description,
                    //Priority = Enum.GetName(typeof(BTM.Models.Priority), 0),
                    Title = bug.Title
                    //Submitter = bug.User.Username
                };
            }
        }
    }
}
