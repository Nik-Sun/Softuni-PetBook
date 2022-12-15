using Microsoft.AspNetCore.Http;
using PetBook.Core.CustomValidation;
using PetBook.Core.Models.Common;
using System.ComponentModel.DataAnnotations;

using static PetBook.Infrastructure.Data.DataConstants.PetConstants;
namespace PetBook.Core.Models.Pets
{
    public class PetEditModel : PetModel
    {
        public PetEditModel()
        {
            ImageViewModels = new List<ImageViewModel>();
         
        }
        public string Id { get; set; }
       
        public ICollection<ImageViewModel> ImageViewModels { get; set; }
      
        public string Breed { get; set; }
        public string Size { get; set; }
        public int Likes { get; set; }
    }
}
