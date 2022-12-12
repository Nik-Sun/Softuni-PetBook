using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.User
{
    public class UserNearbyModel
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string Username { get; set; }
    }
}
