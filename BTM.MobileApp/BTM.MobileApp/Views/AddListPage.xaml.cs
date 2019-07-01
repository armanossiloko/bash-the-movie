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
    public partial class AddListPage : ContentPage
    {
        private APIService _listService = new APIService("Lists");
        public List List { get; set; }
        public AddListPage()
        {
            InitializeComponent();

            List = new List
            {
                DateCreated = DateTime.Now
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            if (List.Name == "" || List.Description == "" || List.Name == null || List.Description == null)
            {
                return;
            }

            if (APIService.Username != "" && APIService.Username != null)
            {
                var submitter = await $"{APIService._apiUrl}/Users/userid/{APIService.Username}"
                    //.WithBasicAuth(APIService.Username, APIService.Password)
                    .GetJsonAsync<User>();
                List.UserID = submitter.Id;
                await _listService.Insert<List>(List);
            }
            await Navigation.PopModalAsync();
        }


        async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}