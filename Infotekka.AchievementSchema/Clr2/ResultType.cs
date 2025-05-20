using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// Describes a result that was achieved.
    /// </summary>
    public class ResultType
    {
        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI 'Result'.
        /// </summary>
        [JsonPropertyName("type")]
        public string TypeName { get; set; }

        /// <summary>
        /// If the result represents an achieved rubric criterion level (e.g. Mastered), the value is the id of the RubricCriterionLevel in linked ResultDescription.
        /// </summary>
        public string AchievedLevel { get; set; }

        /// <summary>
        /// The alignments between this result and nodes in external frameworks. This set of alignments are in addition to the set of alignments defined in the corresponding ResultDescription object.
        /// </summary>
        public AlignmentType Alignment { get; set; }

        /// <summary>
        /// An achievement can have many result descriptions describing possible results. The value of resultDescription is the id of the result description linked to this result. The linked result description must be in the achievement that is being asserted.
        /// </summary>
        public string ResultDescription { get; set; }

        /// <summary>
        /// The status of the achievement. Required if resultType of the linked ResultDescription is Status.<br />
        /// <see cref="Statuses"/>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// A string representing the result of the performance, or demonstration, of the achievement. For example, 'A' if the recipient received an A grade in class.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Defined vocabulary to convey the status of an achievement.
        /// </summary>
        public static class Statuses
        {
            /// <summary>
            /// The learner has successfully completed the achievement. This is the default status if no status result is included.
            /// </summary>
            public const string Completed = "Completed";

            /// <summary>
            /// The learner is enrolled in the activity described by the achievement.
            /// </summary>
            public const string Enrolled = "Enrolled";

            /// <summary>
            /// The learner has unsuccessfully completed the achievement.
            /// </summary>
            public const string Failed = "Failed";

            /// <summary>
            /// The learner has started progress in the activity described by the achievement.
            /// </summary>
            public const string InProgress = "InProgress";

            /// <summary>
            /// The learner has completed the activity described by the achievement, but successful completion has not been awarded, typically for administrative reasons.
            /// </summary>
            public const string OnHold = "OnHold";

            /// <summary>
            /// The learner has completed the activity described by the achievement, but the completed result has not yet been confirmed.
            /// </summary>
            public const string Provisional = "Provisional";

            /// <summary>
            /// The learner withdrew from the activity described by the achievement before completion.
            /// </summary>
            public const string Withdrew = "Withdrew";
        }
    }
}
