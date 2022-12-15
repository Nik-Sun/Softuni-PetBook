using System.ComponentModel.DataAnnotations;

namespace PetBook.Core.Models.Pets
{
    public class PetBrowseModel
    {
        public PetBrowseModel()
        {
            Pets = new List<PetViewModel>();
        }

        public bool IsSearch { get; set; }
        [Required]
        public string Criteria { get; set; }
        [Required]
        [StringLength(100,MinimumLength = 2)]
        public string Search { get; set; }
        public int Page { get; set; }
        public IEnumerable<PetViewModel> Pets { get; set; }
    }
}
