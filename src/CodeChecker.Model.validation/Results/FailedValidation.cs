// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker.Model.validation.Results
{
    /// <summary>
    /// Failed validation class.
    /// </summary>
    public class FailedValidation
    {
        /// <summary>
        /// Gets or Sets the message of the error.
        /// </summary>
        public string? Message { get; set; }

        /// <summary>
        /// Gets or Sets the property concerned.
        /// </summary>
        public string? Property { get; set; }

        /// <summary>
        /// Gets or Sets the current value.
        /// </summary>
        public object? CurrentValue { get; set; }

        /// <inheritdoc />
        public override string ToString() => $"{this.Property} : Failed validation, {this.Message}";
    }
}
