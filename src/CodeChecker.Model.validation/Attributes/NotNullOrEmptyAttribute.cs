// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker.Model.validation.Attributes
{
    using System.Collections;
    using System.Linq;

    /// <summary>
    /// Attribute used to check that the property is not null or empty.
    /// </summary>
    public class NotNullOrEmptyAttribute : BaseRuleAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotNullOrEmptyAttribute"/> class.
        /// </summary>
        /// <param name="message">Message of the attribute.</param>
        public NotNullOrEmptyAttribute(string message) => this.Message = message;

        /// <inheritdoc/>
        public override bool IsValid(object? item)
        {
            bool isNull = Data.Require.That(!(item is null), false, "Should be null");

            if (!isNull)
            {
                isNull = item switch
                {
                    System.Guid g => g != System.Guid.Empty,
                    string s => !string.IsNullOrWhiteSpace(s) && !string.IsNullOrEmpty(s),
                    ICollection col => InternalCheckerExtension.NotNullOrEmpty(col, CheckType.Validation, CheckLevel.Data),
                    IEnumerable enumerable => InternalCheckerExtension.NotNullOrEmpty<object>(enumerable.Cast<object>().ToArray(), CheckType.Validation, CheckLevel.Data),
                    _ => InternalCheckerExtension.NotNull(item, nameof(item), CheckType.Validation, CheckLevel.Data),
                };
            }

            return isNull;
        }
    }
}
