using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class ImageType
    {
        public string ID { get; set; }

        [JsonPropertyName("type")]
        public string TypeName { get; set; } = "Image";

        public string Caption { get; set; }
    }
}
