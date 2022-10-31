using System.ComponentModel.DataAnnotations;

namespace PetBook.Models.User
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false,ErrorMessage = "You can't login without Email")]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "You can't login without Password")]
        public string Password { get; set; }
    }
}
