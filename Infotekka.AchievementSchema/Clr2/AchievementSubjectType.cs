using Infotekka.AchievementSchema.Clr2.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0#achievementcredential
    /// </summary>
    public class AchievementSubjectType : ISubjectType
    {
        /// <summary>
        /// An identifier for the Credential Subject. Either id or at least one identifier MUST be supplied.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI 'AchievementSubject'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; }

        /// <summary>
        /// The datetime the activity ended.
        /// </summary>
        public DateTime ActivityEndDate { get; set; }

        /// <summary>
        /// The datetime the activity started.
        /// </summary>
        public DateTime ActivityStartDate { get; set; }

        /// <summary>
        /// The number of credits earned, generally in semester or quarter credit hours. This field correlates with the Achievement creditsAvailable field.
        /// </summary>
        public float CreditsEarned { get; set; }

        /// <summary>
        /// The achievement being awarded.
        /// </summary>
        public AchievementType Achievement { get; set; }

        /// <summary>
        /// Other identifiers for the recipient of the achievement. Either id or at least one identifier MUST be supplied.
        /// </summary>
        public IdentityObjectType[] Identifier { get; set; }

        /// <summary>
        /// An image representing this user's achievement. If present, this must be a PNG or SVG image, and should be prepared via the 'baking' instructions. An 'unbaked' image for the achievement is defined in the Achievement class and should not be duplicated here.
        /// </summary>
        public ImageType Image { get; set; }

        /// <summary>
        /// The license number that was issued with this credential.
        /// </summary>
        public string LicenseNumber { get; set; }

        /// <summary>
        /// A narrative that connects multiple pieces of evidence. Likely only present at this location if evidence is a multi-value array.
        /// </summary>
        public string Narrative { get; set; }

        /// <summary>
        /// The set of results being asserted.
        /// </summary>
        public ResultType[] Result { get; set; }

        /// <summary>
        /// Role, position, or title of the learner when demonstrating or performing the achievement or evidence of learning being asserted. Examples include 'Student President', 'Intern', 'Captain', etc.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// The person, organization, or system that assessed the achievement on behalf of the issuer. For example, a school may assess the achievement, while the school district issues the credential.
        /// </summary>
        public ProfileType Source { get; set; }

        /// <summary>
        /// The academic term in which this assertion was achieved.
        /// </summary>
        public string Term { get; set; }
    }
}
