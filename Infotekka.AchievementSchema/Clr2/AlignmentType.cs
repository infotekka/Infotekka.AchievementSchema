using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class AlignmentType
    {
        public string TargetName { get; set; }

        public string TargetUrl { get; set; }

        public string TargetFramework { get; set; }

        //public string TargetDescription { get; set; }
        public string Description { get; set; }

        public string TargetCode { get; set; }

        [JsonPropertyName("targetType")]
        public string TargetTypeName { get; set; }
    }
}
