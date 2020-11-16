// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker
{
    using System;

    /// <summary>
    /// Checker class used for operation.
    /// </summary>
    public sealed partial class Operation
    {
        [ThreadStatic]
        private const CheckLevel LEVEL = CheckLevel.Operation;

        /// <summary>
        /// Throw an <see cref="Exception"/> if the condition is false.
        /// </summary>
        /// <param name="condition">Condition to evaluate.</param>
        /// <param name="throwException">Exception if true..</param>
        /// <param name="message">Message to show on the exception.</param>
        /// <exception cref="Exception">.</exception>
        public static bool That(bool condition, bool throwException, string? message) => InternalChecker.True(condition, message, throwException, CheckType.Required, LEVEL);

        /// <summary>
        /// Check if the condition is true.
        /// </summary>
        /// <param name="condition">Condition to check.</param>
        /// <param name="message">The message to show if the exception is throwned.</param>
        /// <param name="throwException">Throw an <see cref="Exception"/> if true.</param>
        /// <returns>True or False.</returns>
        public static bool True(bool condition, string? message, bool throwException = true) => InternalChecker.True(condition, message, throwException, CheckType.Required, LEVEL);

        /// <summary>
        /// Check if the condition is false.
        /// </summary>
        /// <param name="condition">Condition to check.</param>
        /// <param name="message">The message to show if the exception is throwned.</param>
        /// <param name="throwException">Throw an <see cref="Exception"/> if true.</param>
        /// <returns>True or False.</returns>
        public static bool False(bool condition, string? message, bool throwException = true) => InternalChecker.False(condition, message, throwException, CheckType.Required, LEVEL);

        /// <summary>
        /// Throw an <see cref="Exception"/> if the condition is false.
        /// </summary>
        /// <param name="function">Function to evaluate.</param>
        /// <param name="throwException">Exception if true..</param>
        /// <param name="message">Message to show on the exception.</param>
        /// <exception cref="Exception">.</exception>
        public static bool That(Func<bool> function, bool throwException, string? message) => InternalChecker.True(function(), message, throwException, CheckType.Required, LEVEL);

        /// <summary>
        /// Check if the condition is true.
        /// </summary>
        /// <param name="function">Function to evaluate.</param>
        /// <param name="message">The message to show if the exception is throwned.</param>
        /// <param name="throwException">Throw an <see cref="Exception"/> if true.</param>
        /// <returns>True or False.</returns>
        public static bool True(Func<bool> function, string? message, bool throwException = true) => InternalChecker.True(function(), message, throwException, CheckType.Required, LEVEL);

        /// <summary>
        /// Check if the condition is false.
        /// </summary>
        /// <param name="function">Function to evaluate.</param>
        /// <param name="message">The message to show if the exception is throwned.</param>
        /// <param name="throwException">Throw an <see cref="Exception"/> if true.</param>
        /// <returns>True or False.</returns>
        public static bool False(Func<bool> function, string? message, bool throwException = true) => InternalChecker.False(function(), message, throwException, CheckType.Required, LEVEL);
    }
}
