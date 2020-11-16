// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    internal static class ThrowHelper
    {
        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowException(string? message) => throw new Exception(message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowException(string? message, Exception innerException) => throw new Exception(message, innerException);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowNullArgumentException(string? message) => throw new ArgumentNullException(message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowNullArgumentException(string? message, string? nameofArgument)
            => throw new ArgumentNullException(nameofArgument, message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowNullArgumentException(string? message, Exception innerException) => throw new ArgumentNullException(message, innerException);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowArgumentException(string? message) => throw new ArgumentException(message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowArgumentException(string? message, string? nameofArgument) => throw new ArgumentException(nameofArgument, message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowArgumentException(string? message, Exception innerException) => throw new ArgumentNullException(message, innerException);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowInvalidOperationException(string? message) => throw new InvalidOperationException(message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowInvalidCastException(string? message) => throw new InvalidCastException(message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowNullReferenceException(string? message) => throw new NullReferenceException(message);

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Exception ThrowInternalException(string? message) => throw new InternalCheckException(message!);
    }
}
