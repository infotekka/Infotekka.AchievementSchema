using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// Descriptive metadata about evidence related to the achievement assertion. Each instance of the evidence class present in an assertion corresponds to one entity, though a single entry can describe a set of items collectively. There may be multiple evidence entries referenced from an assertion. The narrative property is also in scope of the assertion class to provide an overall description of the achievement related to the assertion in rich text. It is used here to provide a narrative of achievement of the specific entity described. If both the description and narrative properties are present, displayers can assume the narrative value goes into more detail and is not simply a recapitulation of description.
    /// </summary>
    public class EvidenceType
    {
        /// <summary>
        /// The URL of a webpage presenting evidence of achievement or the evidence encoded as a Data URI. The schema of the webpage is undefined.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI 'Evidence'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "Evidence" };

        /// <summary>
        /// A narrative that describes the evidence and process of achievement that led to an assertion.
        /// </summary>
        public string Narrative { get; set; }

        /// <summary>
        /// A descriptive title of the evidence.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A longer description of the evidence.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A string that describes the type of evidence. For example, Poetry, Prose, Film.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// A description of the intended audience for a piece of evidence.
        /// </summary>
        public string Audience { get; set; }
    }
}
