using System.ComponentModel.DataAnnotations;

namespace PetBook.Core.Data.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
