using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// Describes an alignment between an achievement and a node in an educational framework.
    /// </summary>
    public class AlignmentType
    {
        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI 'Alignment'.
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; }

        /// <summary>
        /// If applicable, a locally unique string identifier that identifies the alignment target within its framework and/or targetUrl.
        /// </summary>
        public string TargetCode { get; set; }

        /// <summary>
        /// Short description of the alignment target.
        /// </summary>
        public string TargetDescription { get; set; }

        /// <summary>
        /// Name of the alignment.
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Name of the framework the alignment target.
        /// </summary>
        public string TargetFramework { get; set; }

        /// <summary>
        /// The type of the alignment target node.<br />
        /// <see cref="AlignmentTargetTypes"/>
        /// </summary>
        public string TargetType { get; set; }

        /// <summary>
        /// URL linking to the official description of the alignment target, for example an individual standard within an educational framework.	
        /// </summary>
        public string TargetUrl { get; set; }

        /// <summary>
        /// The type of the alignment target node in the target framework.
        /// </summary>
        public static class AlignmentTargetTypes
        {
            /// <summary>
            /// An alignment to a CTDL-ASN/CTDL competency published by Credential Engine.
            /// </summary>
            public const string Competency = "ceasn:Competency";

            /// <summary>
            /// An alignment to a CTDL Credential published by Credential Engine.
            /// </summary>
            public const string Credential = "ceterms:Credential";

            /// <summary>
            /// An alignment to a CASE Framework Item.
            /// </summary>
            public const string CFItem = "CFItem";

            /// <summary>
            /// An alignment to a CASE Framework Rubric.
            /// </summary>
            public const string CFRubric = "CFRubric";

            /// <summary>
            /// An alignment to a CASE Framework Rubric Criterion.
            /// </summary>
            public const string CFRubricCriterion = "CFRubricCriterion";

            /// <summary>
            /// An alignment to a CASE Framework Rubric Criterion Level.
            /// </summary>
            public const string CFRubricCriterionLevel = "CFRubricCriterionLevel";

            /// <summary>
            /// An alignment to a Credential Engine Item.
            /// </summary>
            public const string CTDL = "CTDL";
        }
    }
}