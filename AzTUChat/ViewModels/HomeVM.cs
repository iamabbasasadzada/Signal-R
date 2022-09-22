using AzTUChat.Models;
using System.Collections.Generic;

namespace AzTUChat.ViewModels
{
    public class HomeVM
    {
        public List<AppUser> Users { get; set; }
        public AppUser CurrentUser { get; set; }
    }
}
