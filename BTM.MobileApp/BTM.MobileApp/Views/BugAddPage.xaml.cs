using BTM.Models;
using BTM.Models.Requests;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTM.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BugAddPage : ContentPage
    {
        private APIService _bugsService = new APIService("Bugs");
        public Bug Bug { get; set; }
        public BugAddPage()
        {
            InitializeComponent();
            Bug = new Bug
            {
                DateAdded = DateTime.Now,
                Resolved = false
            };

            BindingContext = this;
        }
        public ObservableCollection<string> Priorities { get; set; } = new ObservableCollection<string>
        {
            "Low", "Medium", "High"
        };

        async void Save_Clicked(object sender, EventArgs e)
        {
            int priority = (int)Bug.Priority;
            if (priority == 0)
            {
                return;
            }

            if (Bug.Title == "" || Bug.Description == "" || Bug.Title == null || Bug.Description == null)
            {
                return;
            }

            if (APIService.Username != "" && APIService.Username != null)
            {
                var submitter = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}"
                    //.WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<User>();
                Bug.UserID = submitter.Id;
                await _bugsService.Insert<Bug>(Bug);
            }
            await Navigation.PopModalAsync();
        }


        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void SelectPriority(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int priority = picker.SelectedIndex + 1;

            Bug.Priority = (Priority)priority;
        }
    }
}