using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.Pets
{
    public class PetBrowseModel
    {

        public int Page { get; set; }
        public IEnumerable<PetViewModel> Pets { get; set; }
    }
}
