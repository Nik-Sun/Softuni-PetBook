using PetBook.Core.Models.Common;

namespace PetBook.Core.Models.Pets
{
    public class PetViewModel
    {
        public PetViewModel()
        {
            Images = new List<ImageViewModel>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public List<ImageViewModel> Images { get; set; }
        public bool IsMale { get; set; }

        public string Owner { get; set; } = null!;
        public string OwnerId { get; set; }
        public int Likes { get; set; }
        public bool CanLike { get; set; }
    }
}
