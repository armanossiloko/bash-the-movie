using BTM.Models;
using BTM.Models.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace BTM.MobileApp.Models
{
    public class FavoritesItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserID { get; set; }
        public string Creator { get; set; }
        public DateTime DateAdded { get; set; }
        public ICollection<MediaDetailModel> Movies { get; set; }
    }
}
