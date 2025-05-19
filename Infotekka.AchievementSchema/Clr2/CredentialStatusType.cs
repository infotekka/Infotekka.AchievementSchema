using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class CredentialStatusType
    {
        /// <summary>
        /// The value MUST be the URL of the issuer's credential status method.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The name of the credential status method.
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; }
    }
}
