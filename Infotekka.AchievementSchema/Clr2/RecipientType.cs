using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class RecipientType
    {
        [JsonPropertyName("type")]
        public string TypeName { get; set; }

        public string Identity { get; set; }

        public bool Hashed { get; set; }
    }
}
