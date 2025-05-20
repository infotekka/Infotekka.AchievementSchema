using System;

namespace Infotekka.AchievementSchema.Clr2.Data
{
    public interface IVerifiableCredentialType
    {
        string[] Context { get; set; }

        string ID { get; set; }

        string[] TypeName { get; set; }

        ProfileType Issuer { get; set; }

        DateTime ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        ISubjectType CredentialSubject { get; set; }

        ProofType Proof { get; set; }

        CredentialSchemaType CredentialSchema { get; set; }

        CredentialStatusType CredentialStatus { get; set; }

        RefreshServiceType RefreshService { get; set; }

        TermsOfUseType TermsOfUse { get; set; }
    }
}