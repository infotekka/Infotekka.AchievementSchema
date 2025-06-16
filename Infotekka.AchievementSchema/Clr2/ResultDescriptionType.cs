using System.Text.Json.Serialization;

namespace Infotekka.AchievementSchema.Clr2
{
    /// <summary>
    /// Describes a possible achievement result.
    /// </summary>
    public class ResultDescriptionType
    {
        /// <summary>
        /// The unique URI for this result description. Required so a result can link to this result description.
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// The value of the type property MUST be an unordered set. One of the items MUST be the IRI 'ResultDescription'.
        /// </summary>
        [JsonPropertyName("type")]
        public string[] TypeName { get; set; } = { "ResultDescription" };

        /// <summary>
        /// Alignments between this result description and nodes in external frameworks.
        /// </summary>
        public string[] Alignment { get; set; }

        /// <summary>
        /// An ordered list of allowed values. The values should be ordered from low to high as determined by the achievement creator.
        /// </summary>
        public string[] AllowedValue { get; set; }

        /// <summary>
        /// The name of the result.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The id of the rubric criterion level required to pass as determined by the achievement creator.
        /// </summary>
        public string RequiredLevel { get; set; }

        /// <summary>
        /// A value from allowedValue or within the range of valueMin to valueMax required to pass as determined by the achievement creator.
        /// </summary>
        public string RequiredValue { get; set; }

        /// <summary>
        /// The type of result this description represents. This is an extensible enumerated vocabulary.<br />
        /// <see cref="ResultTypes"/>
        /// </summary>
        public string ResultType { get; set; }

        /// <summary>
        /// An ordered array of rubric criterion levels that may be asserted in the linked result. The levels should be ordered from low to high as determined by the achievement creator.
        /// </summary>
        public string[] RubricCriterionLevel { get; set; }

        /// <summary>
        /// The maximum possible value that may be asserted in a linked result.
        /// </summary>
        public string ValueMax { get; set; }

        /// <summary>
        /// The minimum possible value that may be asserted in a linked result.
        /// </summary>
        public string ValueMin { get; set; }

        /// <summary>
        /// The type of result. This is an extensible enumerated vocabulary. Extending the vocabulary makes use of a naming convention.
        /// </summary>
        public static class ResultTypes
        {
            /// <summary>
            /// The result is a grade point average.
            /// </summary>
            public const string GradePointAverage = "GradePointAverage";

            /// <summary>
            /// The result is a letter grade.
            /// </summary>
            public const string LetterGrade = "LetterGrade";

            /// <summary>
            /// The result is a percent score.
            /// </summary>
            public const string Percent = "Percent";

            /// <summary>
            /// The result is a performance level.
            /// </summary>
            public const string PerformanceLevel = "PerformanceLevel";

            /// <summary>
            /// The result is a predicted score.
            /// </summary>
            public const string PredictedScore = "PredictedScore";

            /// <summary>
            /// The result is a raw score.
            /// </summary>
            public const string RawScore = "RawScore";

            /// <summary>
            /// A generic result.
            /// </summary>
            public const string Result = "Result";

            /// <summary>
            /// The result is from a rubric criterion.
            /// </summary>
            public const string RubricCriterion = "RubricCriterion";

            /// <summary>
            /// The result is a rubric criterion level.
            /// </summary>
            public const string RubricCriterionLevel = "RubricCriterionLevel";

            /// <summary>
            /// The result represents a rubric score with both a name and a numeric value.
            /// </summary>
            public const string RubricScore = "RubricScore";

            /// <summary>
            /// The result is a scaled score.
            /// </summary>
            public const string ScaledScore = "ScaledScore";

            /// <summary>
            /// The result conveys the status of the achievement.
            /// </summary>
            public const string Status = "Status";
        }
    }
}