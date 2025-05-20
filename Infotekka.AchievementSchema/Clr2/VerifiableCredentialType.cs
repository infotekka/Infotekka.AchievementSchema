using Infotekka.AchievementSchema.Clr2.Data;
using System;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0#org.1edtech.clr.v2p0.verifiablecredential.class
    /// </summary>
    public class VerifiableCredentialType : IVerifiableCredentialType
    {
        /// <summary>
        /// The value of the @context property MUST be an ordered set where the first item is a URI with the value 'https://www.w3.org/ns/credentials/v2'.
        /// </summary>
        [JsonPropertyName("@context")]
        public string[] Context { get; set; } = { "https://www.w3.org/ns/credentials/v2" };

        /// <summary>
        /// Unambiguous reference to the credential.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the URI 'VerifiableCredential'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "VerifiableCredential" };

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
        /// The subject of the credential.
        /// </summary>
        public ClrSubjectType CredentialSubject { get; set; }
        ISubjectType IVerifiableCredentialType.CredentialSubject { get => CredentialSubject; set => CredentialSubject = value as ClrSubjectType; }

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

        public static class AchievementCredentialTypeNames
        {
            public const string VerifiableCredential = "VerifiableCredential";
            public const string AchievementCredential = "AchievementCredential";
            public const string OpenBadgeCredential = "OpenBadgeCredential";
        }
    }
}