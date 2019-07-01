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
    public partial class SupportAddPage : ContentPage
    {
        private APIService _supportService = new APIService("Support");
        public SupportAddPage()
        {
            InitializeComponent();

            Ticket = new Ticket
            {
                DateAdded = DateTime.Now,
                Resolved = false
            };
            BindingContext = this;
        }
        public Ticket Ticket { get; set; }

        async void Save_Clicked(object sender, EventArgs e)
        {
			if (Ticket.Title == null || Ticket.Title == "" || Ticket.Content == null || Ticket.Content == "")
            {
                return;
            }
			
            if (APIService.Username != "" && APIService.Username != null)
            {
                var submitter = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}"
                    .GetJsonAsync<User>();
                Ticket.UserID = submitter.Id;
                await _supportService.Insert<Ticket>(Ticket);
            }
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}