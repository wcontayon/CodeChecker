// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker
{
    using System.Collections.Generic;

    internal interface IChecker
    {
        T NotNull<T>(T? value, string? paramName)
            where T : class;

        T NotNull<T>(T? value, string? paramName)
            where T : struct;

        void NotNullOrEmpty(string? value, string? paramName);

        void NotNullOrEmpty<T>(ICollection<T> values);

        void NotNullOrEmpty<T>(IEnumerable<T> values);

        void Null<T>(T? value, string? paramName)
            where T : class;

        void Null<T>(T? value, string? paramName)
            where T : struct;

        void NullOrEmpty(string? value, string? paramName);

        void NullOrEmpty<T>(ICollection<T> values);

        void NullOrEmpty<T>(IEnumerable<T> values);

        T Is<T>(object? value, string? paramName);

        bool That(bool condition, bool throwException, string? message);
    }
}
