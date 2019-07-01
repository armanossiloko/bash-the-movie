using BTM.Models;
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
    public partial class FeedbackAddPage : ContentPage
    {
        private APIService _feedbackService = new APIService("Feedback");
        public FeedbackAddPage()
        {
            InitializeComponent();

            BindingContext = this;
            Feedback = new Feedback
            {
                DateAdded = DateTime.Now,
                Addressed = false
            };
        }
        public Feedback Feedback { get; set; }

        async void Save_Clicked(object sender, EventArgs e)
        {
			if (Feedback.Name == null || Feedback.Name == "" || Feedback.Content == null || Feedback.Content == "")
            {
                return;
            }
			
            if (APIService.Username != "" && APIService.Username != null)
            {
                var submitter = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}"
                    .GetJsonAsync<User>();
                Feedback.UserID = submitter.Id;
                await _feedbackService.Insert<Feedback>(Feedback);
            }
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}