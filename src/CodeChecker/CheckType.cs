// Copyright (c) HADEM. All rights reserved.
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("CodeChecker.Model.validation")]

namespace CodeChecker
{
    internal enum CheckType
    {
        /// <summary>
        /// Required that throw the exception if the check is failed.
        /// </summary>
        Required,

        /// <summary>
        /// Assume that the check will not faile, otherwise throw internal exception.
        /// </summary>
        Assume,

        /// <summary>
        /// Not throwing an exception if the check fail.
        /// </summary>
        NotRequired,

        /// <summary>
        /// Validation check (for model validation).
        /// </summary>
        Validation,
    }

    internal enum CheckLevel
    {
        /// <summary>
        /// Check has been done for argument (or data input).
        /// </summary>
        Argument,

        /// <summary>
        /// Check has been done in a method.
        /// </summary>
        Operation,

        /// <summary>
        /// Check has been done for validate data.
        /// </summary>
        Data,
    }
}
