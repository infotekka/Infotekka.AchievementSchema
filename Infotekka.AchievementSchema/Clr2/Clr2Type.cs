using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0
    /// </summary>
    public class Clr2Type
    {
        [JsonPropertyName("@context")]
        public string[] Context { get; set; } = {
            "https://www.w3.org/ns/credentials/v2",
            "https://purl.imsglobal.org/spec/clr/v2p0/context-2.0.1.json",
            "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json",
        };

        public string ID { get; set; } = "https://clr.edportal.nd.gov/credentials/{{CREDENTIAL_UUID}}";

        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = {
            "VerifiableCredential",
            "ClrCredential"
        };

        public ProfileType Issuer { get; set; }

        //public DateTime ValidFrom { get; set; } = DateTime.UtcNow.Date;
        public DateTime ValidFrom { get; set; }

        public string Name { get; set; } = "New Credential";

        public ClrSubjectType CredentialSubject { get; set; }

        public CredentialSchemaType[] CredentialSchema { get; set; }

        public Clr2Type() {
            this.Issuer = new ProfileType();
            this.CredentialSubject = new ClrSubjectType() {
                Identifier = new IdentityObjectType[] { new IdentityObjectType() },
                Achievement = new AchievementType()
            };
        }
    }
}
