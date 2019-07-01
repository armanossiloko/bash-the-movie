using BTM.MobileApp.Models;
using BTM.MobileApp.ViewModels;
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
    public partial class SupportPage : ContentPage
    {
        private SupportListViewModel model = null;

        public SupportPage()
        {
            InitializeComponent();
            BindingContext = model = new SupportListViewModel();
        }

        async void AddTicket_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new SupportAddPage()));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as TicketPreviewModel;
            if (item == null)
                return;

            await Navigation.PushModalAsync(new NavigationPage(new SupportDetailPage(item)));
        }
    }
}