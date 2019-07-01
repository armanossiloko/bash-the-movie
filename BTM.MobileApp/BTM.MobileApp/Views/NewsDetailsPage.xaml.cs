using BTM.MobileApp.Models;
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
    public partial class NewsDetailsPage : ContentPage
    {
        private NewsPreviewModel model;

        public NewsDetailsPage(NewsPreviewModel viewModel)
        {
            InitializeComponent();

            BindingContext = model = viewModel;
        }

        private async void BackClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}