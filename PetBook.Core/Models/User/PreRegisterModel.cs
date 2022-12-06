using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.User
{
    public class PreRegisterModel
    {
        public string TempDataKey { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string AddressText { get; set; }
    }
}
