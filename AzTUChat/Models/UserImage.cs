using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzTUChat.Models
{
    public class UserImage
    {
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public AppUser AppUser { get; set; }
    }
}
