using System;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0#org.1edtech.clr.v2p0.verifiablecredential.class
    /// </summary>
    public class VerifiableCredentialType
    {
        [JsonPropertyName("@context")]
        public string[] Context { get; set; } = new[] { "https://www.w3.org/ns/credentials/v2", "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json", "https://purl.imsglobal.org/spec/ob/v3p0/extensions.json" };

        public string ID { get; set; }

        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = new[] { "VerifiableCredential", "AchievementCredential" };

        public ProfileType Issuer { get; set; }

        public DateTime ValidFrom { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public CredentialSubjectType CredentialSubject { get; set; }

        public CredentialSchemaType CredentialSchema { get; set; }
    }
}