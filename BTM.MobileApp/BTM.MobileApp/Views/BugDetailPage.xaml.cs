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
    public partial class BugDetailPage : ContentPage
    {
        private BugDetailViewModel model = null;
        public BugDetailPage(BugDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = model = viewModel;
        }

        private async void BackCLicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}