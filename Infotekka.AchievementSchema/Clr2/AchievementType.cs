using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// OB3
    /// </summary>
    public class AchievementType
    {
        public string ID { get; set; }

        [JsonPropertyName("@context")]
        public string[] Context { get; set; } = new string[] { "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json" };

        [JsonPropertyName("type")]
        public string[] TypeName { get; set; }

        [JsonPropertyName("achievementType")]
        public string AchievementTypeName { get; set; } = "Badge";

        public AlignmentType[] Alignment { get; set; }

        public AssociationType[] Association { get; set; }

        public string Description { get; set; }

        public IdentifierType[] Identifier { get; set; }

        public string Name { get; set; }

        public ProfileType Issuer { get; set; }

        public ResultDescriptionType[] ResultDescription { get; set; }

        public CreatorType Creator { get; set; }

        public CriteriaType Criteria { get; set; }

        public ImageType Image { get; set; }

        public string CredentialType { get; set; } //Primary Tab

        public string FieldOfStudy { get; set; } = "CIP Code Data pulled from Campus Solutions"; //Additional Details Tab
        //pull from Campus Solutions here in C#

        public string Specialization { get; set; } //Additional Details Tab

        public decimal CreditsAvailable { get; set; } //Additional Details Tab

        public string HumanCode { get; set; } //Additional Details Tab

        public string InLanguage { get; set; } //Additional Details Tab

        public string Version { get; set; } //Additional Details Tab

        public string Level { get; set; } // what this does?

        public string[] Tag { get; set; }
    }
}