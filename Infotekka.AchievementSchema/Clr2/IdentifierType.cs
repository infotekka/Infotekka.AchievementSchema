using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class IdentifierType
    {
        [JsonPropertyName("type")]
        public string TypeName { get; set; } = "IdentityObject";

        [JsonPropertyName("hashed")]
        public bool Hashed { get; set; }

        [JsonPropertyName("identityHash")]
        public string IdentityHash { get; set; } = "{{EMAIL}}";

        [JsonPropertyName("identityType")]
        public string IdentityType { get; set; } = "emailAddress"; //https://www.imsglobal.org/spec/clr/v2p0#identifiertypeenum-enumeration

        [JsonPropertyName("salt")]
        public string Salt { get; set; }
    }
}
