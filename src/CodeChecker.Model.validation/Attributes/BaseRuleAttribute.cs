// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker.Model.validation.Attributes
{
    using System;

    /// <summary>
    /// Rule base attribute used to validate any check rules.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public abstract class BaseRuleAttribute : Attribute
    {
        /// <summary>
        /// Gets or Sets the message of the rule.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Validate the rule.
        /// </summary>
        /// <param name="item">Item to validate.</param>
        /// <returns>True or false.</returns>
        public abstract bool IsValid(object? item);
    }
}
