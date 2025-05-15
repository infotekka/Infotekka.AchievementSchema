using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0#clrsubject
    /// </summary>
    public class CredentialSubjectType
    {
        public string ID { get; set; }

        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "ClrSubject" };

        public IdentifierType[] Identifier { get; set; }

        public VerifiableCredentialType[] VerifiableCredential { get; set; }

        public AchievementType Achievement { get; set; }

        public AssociationType[] Association { get; set; }
    }
}
