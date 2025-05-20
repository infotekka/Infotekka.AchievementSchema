using System.Text.Json.Serialization;
using System;
using Infotekka.AchievementSchema.Clr2.Data;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// A ClrCredential is a CLR with all the properties needed to conform with a Verifiable Credential as defined in the [VC-DATA-MODEL-2.0].
    /// <br />https://www.imsglobal.org/spec/clr/v2p0#clrcredential
    /// </summary>
    public class ClrCredentialType : IVerifiableCredentialType
    {
        /// <summary>
        /// The value of the @context property MUST be an ordered set where the first three items are the URLs https://www.w3.org/ns/credentials/v2, https://purl.imsglobal.org/spec/clr/v2p0/context-2.0.1.json, https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json.
        /// </summary>
        [JsonPropertyName("@context")]
        public string[] Context { get; set; } = { "https://www.w3.org/ns/credentials/v2", "https://purl.imsglobal.org/spec/clr/v2p0/context-2.0.1.json", "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json" };

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI VerifiableCredential, and one of the items MUST be the IRI ClrCredential.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "VerifiableCredential", "ClrCredential" };

        /// <summary>
        /// Unambiguous reference to the credential.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The name of the CLR. May be displayed by wallet user interfaces.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Optional description of the CLR. May be displayed by wallet user interfaces.
        /// </summary>
        public string Description { get; set; }

        ///// <summary>
        ///// Allows endorsers to make specific claims about the credential, and the achievement and profiles in the credential. These endorsements are signed with a Data Integrity proof format.
        ///// </summary>
        //public EndorsementType Endorsement { get; set; }

        ///// <summary>
        ///// Allows endorsers to make specific claims about the credential, and the achievement and profiles in the credential. These endorsements are signed with the VC-JWT proof format.
        ///// </summary>
        //public EndorsementJwtType EndorsementJwt { get; set; }

        /// <summary>
        /// Optional image representing the CLR. May be displayed by wallet user interfaces. If present, MUST represent a PNG or SVG image. MAY be a 'baked' image.
        /// </summary>
        public ImageType Image { get; set; }

        /// <summary>
        /// True if CLR does not contain all the assertions known by the publisher for the learner at the time the CLR is issued. Useful if you are sending a small set of achievements in real time when they are achieved. If False or omitted, the CLR SHOULD be interpreted as containing all the assertions for the learner known by the publisher at the time of issue.
        /// </summary>
        public bool? Partial { get; set; }

        /// <summary>
        /// The learner that is the subject of this CLR credential.
        /// </summary>
        public ClrSubjectType CredentialSubject { get; set; }
        ISubjectType IVerifiableCredentialType.CredentialSubject { get => CredentialSubject; set => CredentialSubject = value as ClrSubjectType; }

        /// <summary>
        /// Timestamp of when the credential was awarded. validFrom is used to determine the most recent version of a Credential in conjunction with issuer and id. Consequently, the only way to update a Credental is to update the validFrom, losing the date when the Credential was originally awarded. awardedDate is meant to keep this original date.
        /// </summary>
        public DateTime? AwardedDate { get; set; }

        /// <summary>
        /// A description of the individual, entity, or organization that issued the credential.
        /// </summary>
        public ProfileType Issuer { get; set; }

        /// <summary>
        /// Timestamp of when the credential becomes valid.
        /// </summary>
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// If the credential has some notion of validity period, this indicates a timestamp when a credential should no longer be considered valid. After this time, the credential should be considered invalid.
        /// </summary>
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// If present, one or more embedded cryptographic proofs that can be used to detect tampering and verify the authorship of the credential.
        /// </summary>
        public ProofType Proof { get; set; }

        /// <summary>
        /// The value of the credentialSchema property MUST be one or more data schemas that provide verifiers with enough information to determine if the provided data conforms to the provided schema.
        /// </summary>
        public CredentialSchemaType CredentialSchema { get; set; }

        /// <summary>
        /// The information in CredentialStatus is used to discover information about the current status of a verifiable credential, such as whether it is suspended or revoked.
        /// </summary>
        public CredentialStatusType CredentialStatus { get; set; }

        /// <summary>
        /// The information in RefreshService is used to refresh the verifiable credential.
        /// </summary>
        public RefreshServiceType RefreshService { get; set; }

        /// <summary>
        /// The value of the termsOfUse property tells the verifier what actions it is required to perform (an obligation), not allowed to perform (a prohibition), or allowed to perform (a permission) if it is to accept the verifiable credential.
        /// </summary>
        public TermsOfUseType TermsOfUse { get; set; }
    }
}
