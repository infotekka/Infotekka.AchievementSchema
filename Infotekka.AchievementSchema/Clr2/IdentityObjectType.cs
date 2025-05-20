using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// A collection of information about the recipient of an achievement.<br />
    /// https://www.imsglobal.org/spec/clr/v2p0#org.1edtech.clr.v2p0.identityobject.class
    /// </summary>
    public class IdentityObjectType
    {
        /// <summary>
        /// MUST be the IRI 'IdentityObject'.
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; } = "IdentityObject";

        /// <summary>
        /// Whether or not the identityHash value is hashed.
        /// </summary>
        [JsonPropertyName("hashed")]
        public bool Hashed { get; set; }

        /// <summary>
        /// Either the IdentityHash of the identity or the plaintext value. If it's possible that the plaintext transmission and storage of the identity value would leak personally identifiable information where there is an expectation of privacy, it is strongly recommended that an IdentityHash be used.
        /// </summary>
        [JsonPropertyName("identityHash")]
        public string IdentityHash { get; set; } = "{{EMAIL}}";

        /// <summary>
        /// The identity type.
        /// </summary>
        [JsonPropertyName("identityType")]
        public string IdentityType { get; set; } = "emailAddress"; //https://www.imsglobal.org/spec/clr/v2p0#identifiertypeenum-enumeration

        /// <summary>
        /// If the identityHash is hashed, this should contain the string used to salt the hash. If this value is not provided, it should be assumed that the hash was not salted.
        /// </summary>
        [JsonPropertyName("salt")]
        public string Salt { get; set; }
    }
}
