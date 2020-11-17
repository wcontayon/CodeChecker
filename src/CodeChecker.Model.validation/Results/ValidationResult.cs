// Copyright (c) HADEM. All rights reserved.

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("CodeChecker")]

namespace CodeChecker.Model.validation.Results
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Result class of <see cref="Validator.Validate"/> method.
    /// </summary>
    public class ValidationResult
    {
        private List<FailedValidation> failedValidations;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> class.
        /// </summary>
        public ValidationResult()
        {
            this.failedValidations = new List<FailedValidation>();
        }

        /// <summary>
        /// Gets the list of failed validations.
        /// </summary>
        public IReadOnlyList<FailedValidation>? Errors { get => this.failedValidations; }

        /// <summary>
        /// Gets a value that indicates if the result is failed or not.
        /// </summary>
        public bool? IsValid { get => this.Errors?.Count == 0; }

        /// <summary>
        /// Gets the messages errors.
        /// </summary>
        public string? Messages
        {
            get
            {
                if (this.Errors != null && this.Errors.Any())
                {
                    StringBuilder builder = new StringBuilder();
                    foreach (FailedValidation failed in this.Errors!)
                    {
                        builder.Append(failed.ToString());
                    }

                    return builder.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        /// <summary>
        /// Add a <see cref="FailedValidation"/>.
        /// </summary>
        /// <param name="error"><see cref="FailedValidation"/> item.</param>
        internal void AddError(FailedValidation error) => this.failedValidations.Add(error);
    }
}
