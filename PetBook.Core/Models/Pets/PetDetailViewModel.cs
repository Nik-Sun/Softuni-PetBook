namespace PetBook.Core.Models.Pets
{
    public class PetDetailViewModel : PetViewModel
    {
        public string Description { get; set; }
        public string Breed { get; set; }
        public string  Size { get; set; }
        public string OwnerId { get; set; }
    }
}
