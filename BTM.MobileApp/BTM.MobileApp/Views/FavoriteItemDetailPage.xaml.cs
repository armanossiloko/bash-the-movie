using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTM.MobileApp.Models;
using BTM.Models;
using BTM.Models.Requests;
using Flurl.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTM.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoriteItemDetailPage : ContentPage
    {
        private FavoritesItem model = null;

        public FavoriteItemDetailPage(FavoritesItem viewModel)
        {
            InitializeComponent();
            BindingContext = model = viewModel;
        }

        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as MediaDetailModel;
            if (item == null)
            {
                return;
            }

            await Navigation.PushModalAsync(new NavigationPage(new MediaDetailPage(item)));
        }
    }
}