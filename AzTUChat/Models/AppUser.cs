using Microsoft.AspNetCore.Identity;

namespace AzTUChat.Models
{

    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public UserImage UserImage { get; set; }
        public string  ConnectionId { get; set; }
    }
}
