// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker
{
    using System;

    /// <summary>
    /// Checker class for argument.
    /// </summary>
    public sealed partial class Argument
    {
        [ThreadStatic]
        private const CheckLevel LEVEL = CheckLevel.Argument;
    }
}
