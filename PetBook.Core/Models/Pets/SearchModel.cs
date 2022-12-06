using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.Pets
{
    public class SearchModel
    {
        [Required]
        public string Criteria { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Search { get; set; }
    }
}
