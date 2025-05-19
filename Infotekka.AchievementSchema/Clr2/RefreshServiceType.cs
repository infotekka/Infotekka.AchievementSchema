using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class RefreshServiceType
    {
        /// <summary>
        /// The value MUST be the URL of the issuer's refresh service.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The name of the refresh service method.
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; }
    }
}
