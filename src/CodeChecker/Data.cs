// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker
{
    using System;

    /// <summary>
    /// Checker class for data or variable.
    /// </summary>
    public sealed partial class Data
    {
        [ThreadStatic]
        private const CheckLevel LEVEL = CheckLevel.Data;
    }
}
