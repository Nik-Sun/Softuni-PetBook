using System.ComponentModel.DataAnnotations;

namespace PetBook.Infrastructure.Data.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
