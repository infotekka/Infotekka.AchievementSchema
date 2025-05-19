using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class TermsOfUseType
    {
        /// <summary>
        /// The value MUST be a URI identifying the term of use.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value MUST identify the type of the terms of use.
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; }
    }
}
