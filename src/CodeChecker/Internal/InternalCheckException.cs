// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// Internal exception used the <see cref="Assume"/> checker.
    /// </summary>
    [Serializable]
    internal sealed class InternalCheckException : Exception
    {
        [DebuggerStepThrough]
        public InternalCheckException()
        {
        }

        [DebuggerStepThrough]
        public InternalCheckException(string message)
            : base(message)
        {
        }

        [DebuggerStepThrough]
        public InternalCheckException(string message, Exception inner)
            : base(message, inner)
        {
        }

        [DebuggerStepThrough]
        private InternalCheckException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
