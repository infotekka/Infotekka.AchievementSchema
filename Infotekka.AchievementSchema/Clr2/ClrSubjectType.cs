using Infotekka.AchievementSchema.Clr2.Data;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// A collection of information about the learner that is the subject of this CLR credential.<br />
    /// https://www.imsglobal.org/spec/clr/v2p0#clrsubject
    /// </summary>
    public class ClrSubjectType : ISubjectType
    {
        /// <summary>
        /// An identifier for the recipient of the CLR credential. Either id or at least one identifier is required.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The property MUST contain the IRI ClrSubject.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "ClrSubject" };

        /// <summary>
        /// Other identifiers for the recipient of the CLR credential. Either id or at least one identifieris required.
        /// </summary>
        public IdentityObjectType[] Identifier { get; set; }

        /// <summary>
        /// The set of achievements the CLR issuer expects the learner to achieve.
        /// </summary>
        public AchievementType Achievement { get; set; }

        /// <summary>
        /// A set of AchievementCredentials, OpenBadgeCredentials, and other VerifiableCredentials the learner has been awarded. The credential issuers may not be the same entity as the ClrCredential issuer, but the ClrCredential's credential subject is guaranteed to be the same person as the credential subject of each included credential, even if they use different identifiers.
        /// </summary>
        public IVerifiableCredentialType[] VerifiableCredential { get; set; }

        /// <summary>
        /// Associations describe the semantic relationship between source and target achievements and their assertions.
        /// </summary>
        public AssociationType[] Association { get; set; }
    }
}
