using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class ResultType
    {
        [JsonPropertyName("type")]
        public string TypeName { get; set; }

        public string AchievedLevel { get; set; }

        public AlignmentType Alignment { get; set; }

        public string ResultDescription { get; set; }

        public string Status { get; set; }

        public string Value { get; set; }
    }
}
