using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    public class EvidenceType
    {
        public string ID { get; set; }

        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "Evidence" };

        public string Name { get; set; }

        public string Description { get; set; }

        public string Narrative { get; set; }
    }
}
