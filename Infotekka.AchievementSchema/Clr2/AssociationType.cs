using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class AssociationType
    {
        [JsonPropertyName("type")]
        public string TypeName { get; set; } = "Association";

        [JsonPropertyName("associationType")]
        public string AssociationTypeName { get; set; } = "isParentOf";

        public string SourceId { get; set; }

        public string TargetId { get; set; }
    }
}
