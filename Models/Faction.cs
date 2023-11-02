using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EntityFramework7Relationships.Models
{
    public class Faction
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<Character> Characters { get; set; }
    }
}
