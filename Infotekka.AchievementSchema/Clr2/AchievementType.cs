using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// A collection of information about the accomplishment recognized by the Assertion. Many assertions may be created corresponding to one Achievement.<br />
    /// https://www.imsglobal.org/spec/clr/v2p0#achievement
    /// </summary>
    public class AchievementType
    {
        /// <summary>
        /// Unique URI for the Achievement. 
        /// </summary>
        public string ID { get; set; } //(This gets turned in to a clickable link in the OCP wallet.)

        /// <summary>
        /// The type MUST include the IRI 'Achievement'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "Achievement" };

        /// <summary>
        /// An object describing which objectives or educational standards this achievement aligns to, if any.
        /// </summary>
        public AlignmentType[] Alignment { get; set; }

        /// <summary>
        /// The type of achievement. This is an extensible vocabulary.<br />
        /// <see cref="AchievementTypes"/>
        /// </summary>
        [JsonPropertyName("achievementType")]
        public string AchievementTypeName { get; set; }

        /// <summary>
        /// The person or organization that created the achievement definition.
        /// </summary>
        public ProfileType Creator { get; set; }

        /// <summary>
        /// Credit hours associated with this entity, or credit hours possible. For example 3.0.	
        /// </summary>
        public decimal? CreditsAvailable { get; set; }

        /// <summary>
        /// Criteria describing how to earn the achievement.
        /// </summary>
        public CriteriaType Criteria { get; set; }

        /// <summary>
        /// A short description of the achievement.
        /// </summary>
        public string Description { get; set; }

        //endorsement

        //endorsementjwt

        /// <summary>
        /// Category, subject, area of study, discipline, or general branch of knowledge. Examples include Business, Education, Psychology, and Technology.
        /// </summary>
        public string FieldOfStudy { get; set; }

        /// <summary>
        /// The code, generally human readable, associated with an achievement.
        /// </summary>
        public string HumanCode { get; set; }

        /// <summary>
        /// An image representing the achievement.
        /// </summary>
        public ImageType Image { get; set; }

        /// <summary>
        /// The language of the achievement.
        /// </summary>
        public string InLanguage { get; set; }

        /// <summary>
        /// The name of the achievement.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of identifiers for the described entity.
        /// </summary>
        public IdentifierEntryType[] OtherIdentifier { get; set; }

        /// <summary>
        /// The related property identifies another Achievement that should be considered the same for most purposes. It is primarily intended to identify alternate language editions or previous versions of Achievements.
        /// </summary>
        public RelatedType[] Related { get; set; }

        /// <summary>
        /// The set of result descriptions that may be asserted as results with this achievement.
        /// </summary>
        public ResultDescriptionType[] ResultDescription { get; set; }

        /// <summary>
        /// Name given to the focus, concentration, or specific area of study defined in the achievement. Examples include 'Entrepreneurship', 'Technical Communication', and 'Finance'.
        /// </summary>
        public string Specialization { get; set; }

        /// <summary>
        /// One or more short, human-friendly, searchable, keywords that describe the type of achievement.
        /// </summary>
        public string[] Tag { get; set; }

        /// <summary>
        /// The version property allows issuers to set a version string for an Achievement. This is particularly useful when replacing a previous version with an update.
        /// </summary>
        public string Version { get; set; }

        public static class AchievementTypes
        {
            public const string Achievement = "Achievement";
            public const string ApprenticeshipCertificate = "ApprenticeshipCertificate";
            public const string Assignment = "Assignment";
            public const string AssociateDegree = "AssociateDegree";
            public const string Award = "Award";
            public const string Badge = "Badge";
            public const string BachelorDegree = "BachelorDegree";
            public const string Certificate = "Certificate";
            public const string CertificateOfCompletion = "CertificateOfCompletion";
            public const string Certification = "Certification";
            public const string CommunityService = "CommunityService";
            public const string Competency = "Competency";
            public const string Course = "Course";
            public const string CoCurricular = "CoCurricular";
            public const string Degree = "Degree";
            public const string Diploma = "Diploma";
            public const string DoctoralDegree = "DoctoralDegree";
            public const string Fieldwork = "Fieldwork";
            public const string GeneralEducationDevelopment = "GeneralEducationDevelopment";
            public const string JourneymanCertificate = "JourneymanCertificate";
            public const string LearningProgram = "LearningProgram";
            public const string License = "License";
            public const string Membership = "Membership";
            public const string ProfessionalDoctorate = "ProfessionalDoctorate";
            public const string QualityAssuranceCredential = "QualityAssuranceCredential";
            public const string MasterCertificate = "MasterCertificate";
            public const string MasterDegree = "MasterDegree";
            public const string MicroCredential = "MicroCredential";
            public const string ResearchDoctorate = "ResearchDoctorate";
            public const string SecondarySchoolDiploma = "SecondarySchoolDiploma";
        }
    }
}