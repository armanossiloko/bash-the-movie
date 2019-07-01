using BTM.MobileApp.Models;
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
    public partial class SupportDetailPage : ContentPage
    {
        private TicketPreviewModel model = null;
        public SupportDetailPage(TicketPreviewModel viewModel)
        {
            InitializeComponent();
            BindingContext = model = viewModel;
        }

        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}