using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Data.Models.DTOs
{
    public class CityDTO
    {
        
        public int Id { get; set; }
        [JsonProperty("city")]
        public string Name  { get; set; }

        [JsonProperty("lat")]
        public double Lattitude { get; set; }
        [JsonProperty("lng")]
        public double  Longitude { get; set; }
    }
}
