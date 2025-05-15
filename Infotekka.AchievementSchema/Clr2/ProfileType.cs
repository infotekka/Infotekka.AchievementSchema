using System;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// https://www.imsglobal.org/spec/clr/v2p0#org.1edtech.clr.v2p0.profile.class
    /// </summary>
    public class ProfileType
    {
        public string ID { get; set; }

        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "Profile" };

        public string Name { get; set; }

        public string Url { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public ImageType Image { get; set; }

        public string Email { get; set; }

        public AddressType Address { get; set; }

        /// <summary>
        /// An authorized official of the organization
        /// </summary>
        public string Official { get; set; }

        public ProfileType ParentOrg { get; set; }

        public string FamilyName { get; set; }

        public string GivenName { get; set; }

        public string AdditionalName { get; set; }

        public string PatronymicName { get; set; }

        public string HonorificPrefix { get; set; }

        public string HonorificSuffix { get; set; }

        public string FamilyNamePrefix { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
