using BTM.MobileApp.Models;
using BTM.MobileApp.ViewModels;
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
    public partial class FavoritesPage : ContentPage
    {
        private FavoritesListViewModel model = null;

        public FavoritesPage()
        {
            InitializeComponent();

            BindingContext = model = new FavoritesListViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as FavoritesItem;
            if (item == null)
            {
                return;
            }

            await Navigation.PushModalAsync(new NavigationPage(new FavoriteItemDetailPage(item)));
        }

        private async void AddClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AddListPage()));
        }
    }
}