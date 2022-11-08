using Newtonsoft.Json;

namespace PetBook.Core.Data.Models.DTOs
{
    public class BreedDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
