using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace AzTUChat.ViewModels
{
    public class RegisterVM
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
        public IFormFile Image { get; set; }
    }
}
