using BTM.MobileApp.Models;
using BTM.MobileApp.ViewModels;
using BTM.Models;
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
    public partial class FeedbackPage : ContentPage
    {
        private FeedbackListViewModel model = null;
        public FeedbackPage()
        {
            InitializeComponent();
            BindingContext = model = new FeedbackListViewModel();
        }

        async void AddIdea_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new FeedbackAddPage()));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as FeedbackPreviewModel;
            if (item == null)
                return;

            await Navigation.PushModalAsync(new NavigationPage(new FeedbackDetailPage(item)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }
    }
}