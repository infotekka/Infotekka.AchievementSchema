using System;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// A JSON-LD Linked Data proof.
    /// </summary>
    public class ProofType
    {
        /// <summary>
        /// Signature suite used to produce proof.
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; }

        /// <summary>
        /// Date the proof was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// The suite used to create the proof.
        /// </summary>
        public string CryptoSuite { get; set; }

        /// <summary>
        /// A value chosen by the verifier to mitigate authentication proof replay attacks.
        /// </summary>
        public string Challenge { get; set; }

        /// <summary>
        /// The domain of the proof to restrict its use to a particular target.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// A value chosen by the creator of proof to randomize proof values for privacy purposes.
        /// </summary>
        public string Nonce { get; set; }

        /// <summary>
        /// The purpose of the proof to be used with verificationMethod. MUST be 'assertionMethod'.
        /// </summary>
        public string ProofPurpose { get; set; }

        /// <summary>
        /// Value of the proof.
        /// </summary>
        public string ProofValue { get; set; }

        /// <summary>
        /// The URL of the public key that can verify the signature.
        /// </summary>
        public string VerificationMethod { get; set; }
    }
}
