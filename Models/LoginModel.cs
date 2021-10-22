using System.ComponentModel.DataAnnotations;

namespace BayernData.Models
{
    public class LoginModel
    {
        [Required]
        [UIHint("email")]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }
}
