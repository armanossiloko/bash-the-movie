using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.MobileApp.Models
{
    public enum MenuItemType
    {
        Home,
        Profile,
        Favorites,
        Movies,
        News,
        Feedback,
        Support,
        Bugs,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
