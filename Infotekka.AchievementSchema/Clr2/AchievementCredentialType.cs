using Infotekka.AchievementSchema.Clr2.Data;
using System;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// AchievementCredentials are representations of an awarded achievement, used to share information about a achievement belonging to one earner. Maps to a Verifiable Credential as defined in the [VC-DATA-MODEL-2.0]. As described in § 7. Proofs (Signatures), at least one proof mechanism, and the details necessary to evaluate that proof, MUST be expressed for a credential to be a verifiable credential. In the case of an embedded proof, the credential MUST append the proof in the proof property.
    /// </summary>
    public class AchievementCredentialType : IVerifiableCredentialType
    {
        /// <summary>
        /// The value of the @context property MUST be an ordered set where the first item is a URI with the value 'https://www.w3.org/ns/credentials/v2', and the second item is a URI with the value 'https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json'.
        /// </summary>
        [JsonPropertyName("@context")]
        public string[] Context { get; set; } = { "https://www.w3.org/ns/credentials/v2", "https://purl.imsglobal.org/spec/ob/v3p0/context-3.0.3.json" }; //, "https://purl.imsglobal.org/spec/ob/v3p0/extensions.json"

        /// <summary>
        /// Unambiguous reference to the credential.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the URI 'VerifiableCredential', and one of the items MUST be the URI 'AchievementCredential' or the URI 'OpenBadgeCredential'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "VerifiableCredential", "AchievementCredential" };

        /// <summary>
        /// The name of the credential for display purposes in wallets. For example, in a list of credentials and in detail views.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The short description of the credential for display purposes in wallets.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The image representing the credential for display purposes in wallets.
        /// </summary>
        public ImageType Image { get; set; }

        /// <summary>
        /// Timestamp of when the credential was awarded. validFrom is used to determine the most recent version of a Credential in conjunction with issuer and id. Consequently, the only way to update a Credental is to update the validFrom, losing the date when the Credential was originally awarded. awardedDate is meant to keep this original date.
        /// </summary>
        public DateTime AwardedDate { get; set; }

        /// <summary>
        /// The recipient of the achievement.
        /// </summary>
        public AchievementSubjectType CredentialSubject { get; set; }
        ISubjectType IVerifiableCredentialType.CredentialSubject { get => CredentialSubject; set => CredentialSubject = value as AchievementSubjectType; }

        ///// <summary>
        ///// Allows endorsers to make specific claims about the credential, and the achievement and profiles in the credential. These endorsements are signed with a Data Integrity proof format.
        ///// </summary>
        //public EndorsementType Endorsement { get; set; }

        ///// <summary>
        ///// Allows endorsers to make specific claims about the credential, and the achievement and profiles in the credential. These endorsements are signed with the VC-JWT proof format.
        ///// </summary>
        //public EndorsementJwtType EndorsementJwt { get; set; }

        /// <summary>
        /// A description of the work that the recipient did to earn the achievement. This can be a page that links out to other pages if linking directly to the work is infeasible.
        /// </summary>
        public EvidenceType[] Evidence { get; set; }

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
        public DateTime ValidUntil { get; set; }

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
