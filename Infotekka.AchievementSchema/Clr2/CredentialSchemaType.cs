using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class CredentialSchemaType
    {
        public string ID { get; set; } = "https://purl.imsglobal.org/spec/clr/v2p0/schema/json/clr_v2p0_clrcredential_schema.json";

        [JsonPropertyName("type")]
        public string TypeName { get; set; }
    }
}
