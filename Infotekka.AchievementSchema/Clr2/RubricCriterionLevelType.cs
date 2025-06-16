using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// Describes a rubric criterion level.
    /// </summary>
    public class RubricCriterionLevelType
    {
        /// <summary>
        /// The unique URI for this rubric criterion level. Required so a result can link to this rubric criterion level.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI 'RubricCriterionLevel'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "RubricCriterionLevel" };

        /// <summary>
        /// Alignments between this rubric criterion level and a rubric criterion levels defined in external frameworks.
        /// </summary>
        public AlignmentType[] Alignment { get; set; }

        /// <summary>
        /// Description of the rubric criterion level.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The rubric performance level in terms of success.
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// The name of the rubric criterion level.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The points associated with this rubric criterion level.
        /// </summary>
        public string Points { get; set; }
    }
}