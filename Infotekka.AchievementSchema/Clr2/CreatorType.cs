using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class CreatorType
    {
        public string ID { get; set; }

        [JsonPropertyName("type")]
        public string[] TypeName { get; set; }
    }
}
