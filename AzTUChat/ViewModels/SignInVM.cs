using System.ComponentModel.DataAnnotations;

namespace AzTUChat.ViewModels
{
    public class SignInVM
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
