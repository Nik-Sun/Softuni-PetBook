using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Infrastructure.Data.Models
{
    public class Like
    {
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public Guid PetId { get; set; }
        public Pet Pet { get; set; }
    }
}
