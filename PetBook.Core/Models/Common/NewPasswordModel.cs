using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.Common
{
    public class NewPasswordModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        [Required(AllowEmptyStrings = false)]
        public string ConfirmPassword { get; set; }
    }
}
