// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    public sealed partial class Argument
    {
        /// <summary>
        /// Assume check class.
        /// </summary>
        public sealed class Assume
        {
            [ThreadStatic]
            private const CheckType TYPE = CheckType.Assume;

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the value is null.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="value">Value to be tested.</param>
            /// <param name="paramName">Name of the parameter.</param>
            /// <returns><typeparamref name="T"/> value.</returns>
            /// <exception cref="InternalCheckException">.</exception>
            public static T NotNull<T>(T? value, string? paramName)
                where T : class
                => InternalChecker.NotNull<T>(value, paramName, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the value is null.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="value">Value to be tested.</param>
            /// <param name="paramName">Name of the parameter.</param>
            /// <returns><typeparamref name="T"/> value.</returns>
            /// <exception cref="InternalCheckException">.</exception>
            public static T NotNull<T>(T? value, string? paramName)
                where T : struct
                => InternalChecker.NotNull<T>(value, paramName, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the value (<see cref="string"/>) is null or empty.
            /// </summary>
            /// <param name="value">Value to be tested.</param>
            /// <param name="paramName">Name of the parameter.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void NotNullOrEmpty(string? value, string? paramName) => InternalChecker.NotNullOrEmpty(value, paramName, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the values (<see cref="ICollection{T}"/>) is null.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="values">Value to be tested.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void NotNullOrEmpty<T>(ICollection<T> values) => InternalChecker.NotNullOrEmpty<T>(values, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the values (<see cref="IEnumerable{T}"/>) is null.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="values">Value to be tested.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void NotNullOrEmpty<T>(IEnumerable<T> values) => InternalChecker.NotNullOrEmpty<T>(values, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the value is not type of <typeparamref name="T"/>.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="value">Value to be tested.</param>
            /// <param name="paramName">Name of the parameter.</param>
            /// <returns><typeparamref name="T"/> value.</returns>
            /// <exception cref="InternalCheckException">.</exception>
            public static T Is<T>(object? value, string? paramName)
                where T : class => InternalChecker.Is<T>(value, paramName, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the value is not null.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="value">Value to be tested.</param>
            /// <param name="paramName">Name of the parameter.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void Null<T>(T? value, string? paramName)
                where T : class => InternalChecker.Null<T>(value, paramName, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the value is not null.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="value">Value to be tested.</param>
            /// <param name="paramName">Name of the parameter.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void Null<T>(T? value, string? paramName)
                where T : struct => InternalChecker.Null<T>(value, paramName, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the value is not null.
            /// </summary>
            /// <param name="value">Value to be tested.</param>
            /// <param name="paramName">Name of the parameter.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void NullOrEmpty(string? value, string? paramName) => InternalChecker.NullOrEmpty(value, paramName, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the values (<see cref="ICollection{T}"/>) is not null or empty.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="values">Value to be tested.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void NullOrEmpty<T>(ICollection<T> values) => InternalChecker.NullOrEmpty<T>(values, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the values (<see cref="IEnumerable{T}"/>) is not null or empty.
            /// </summary>
            /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
            /// <param name="values">Value to be tested.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static void NullOrEmpty<T>(IEnumerable<T> values) => InternalChecker.NullOrEmpty<T>(values, TYPE, LEVEL);

            /// <summary>
            /// Throw an <see cref="InternalCheckException"/> if the condition is false.
            /// </summary>
            /// <param name="condition">Condition to evaluate.</param>
            /// <param name="throwException">Exception if true..</param>
            /// <param name="message">Message to show on the exception.</param>
            /// <exception cref="InternalCheckException">.</exception>
            public static bool That(bool condition, [DoesNotReturnIf(true)] bool throwException, string? message) => InternalChecker.True(condition, message, throwException, TYPE, LEVEL);
        }
    }
}
