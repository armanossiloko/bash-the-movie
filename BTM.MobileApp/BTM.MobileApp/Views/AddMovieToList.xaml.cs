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
    public partial class AddMovieToList : ContentPage
    {
        private MediaDetailModel model = null;
        public List<BTM.Models.List> Lists { get; set; } = new List<BTM.Models.List>();
        private List ChosenFavorites = null;
        public AddMovieToList(MediaDetailModel viewModel, List<BTM.Models.List> lists)
        {
            InitializeComponent();

            model = viewModel;
            Lists = lists;
            BindingContext = this;
        }

        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Add_Clicked(object sender, EventArgs e)
        {
            if (ListPicker.SelectedIndex != -1) // We got something selected
            {
                var selectedList = ListPicker.SelectedItem as List;
                MediaList entity = new MediaList
                {
                    ListID = selectedList.ListID,
                    MediaID = model.Id
                };

                try
                {
                    await $"{APIService._apiUrl}/Lists/AddMovie"
                        .WithBasicAuth(APIService.Username, APIService.Password)
                        .PostJsonAsync(entity);
                    await Navigation.PopModalAsync();
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                }

            }
        }
    }
}