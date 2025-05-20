using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// Identifies a related achievement.
    /// </summary>
    public class RelatedType
    {
        /// <summary>
        /// The related achievement.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI 'Related'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "Related" };

        /// <summary>
        /// The language of the related achievement.
        /// </summary>
        public string InLanguage { get; set; }

        /// <summary>
        /// The version of the related achievement.
        /// </summary>
        public string Version { get; set; }
    }
}
