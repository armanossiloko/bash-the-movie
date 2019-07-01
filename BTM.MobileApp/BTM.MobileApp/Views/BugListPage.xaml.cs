using BTM.MobileApp.ViewModels;
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
    public partial class BugListPage : ContentPage
    {
        private BugListViewModel model = null;
        public BugListPage()
        {
            InitializeComponent();
            BindingContext = model = new BugListViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        async void AddBug_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new BugAddPage()));
        }

        private async void OnitemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Bug;
            if (item == null)
                return;

            BugDetailViewModel model = new BugDetailViewModel(item);
            model.Item.Priority = await $"{APIService._apiUrl}/bugs/priority/{item.Id}".GetStringAsync();
            model.Item.Submitter = await $"{APIService._apiUrl}/bugs/submitter/{item.Id}".GetStringAsync();

            await Navigation.PushModalAsync(new NavigationPage(new BugDetailPage(model)));

            // Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }
    }
}