using Microsoft.AspNetCore.Http;

namespace PetBook.Core.Models.Pets
{
    public class PetDetailViewModel : PetViewModel
    {
       
        public string Description { get; set; }
        public string Breed { get; set; }
        public string  Size { get; set; }

        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
    }
}
