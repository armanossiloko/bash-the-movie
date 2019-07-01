using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BTM.MobileApp.Models;

namespace BTM.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Home:
                        MenuPages.Add(id, new NavigationPage(new HomePage()));
                        break;
                    case (int)MenuItemType.Profile:
                        MenuPages.Add(id, new NavigationPage(new ProfilePage()));
                        break;
                    case (int)MenuItemType.Favorites:
                        MenuPages.Add(id, new NavigationPage(new FavoritesPage()));
                        break;
                    case (int)MenuItemType.Movies:
                        MenuPages.Add(id, new NavigationPage(new MediaPage()));
                        break;
                    case (int)MenuItemType.News:
                        MenuPages.Add(id, new NavigationPage(new NewsPage()));
                        break;
                    case (int)MenuItemType.Feedback:
                        MenuPages.Add(id, new NavigationPage(new FeedbackPage()));
                        break;
                    case (int)MenuItemType.Bugs:
                        MenuPages.Add(id, new NavigationPage(new BugListPage()));
                        break;
                    case (int)MenuItemType.Support:
                        MenuPages.Add(id, new NavigationPage(new SupportPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}