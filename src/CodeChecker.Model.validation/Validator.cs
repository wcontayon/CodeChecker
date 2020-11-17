// Copyright (c) HADEM. All rights reserved.

namespace CodeChecker.Model.validation
{
    using System.Linq;
    using System.Reflection;
    using CodeChecker.Model.validation.Attributes;
    using CodeChecker.Model.validation.Results;

    /// <summary>
    /// Validator class used to validate model rules.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validate any <see cref="BaseRuleAttribute"/> applied on properties of the current object instance object.
        /// </summary>
        /// <typeparam name="T"><typeparamref name="T"/>.</typeparam>
        /// <param name="item">Object to validate.</param>
        /// <returns><see cref="ValidationResult"/>.</returns>
        public static ValidationResult Validate<T>(T item)
            where T : class
        {
            Argument.Assume.NotNull(item, nameof(item));

            ValidationResult result = new ValidationResult();

            var properties = item.GetType().GetProperties(BindingFlags.GetField | BindingFlags.Instance);

            foreach (PropertyInfo property in properties)
            {
                var ruleAttributes = property.GetCustomAttributes<BaseRuleAttribute>();

                if (ruleAttributes.Any())
                {
                    foreach (BaseRuleAttribute attribute in ruleAttributes)
                    {
                        var value = attribute.IsValid(property.GetValue(item, null));
                        var validation = attribute.IsValid(value);
                        if (!validation)
                        {
                            result.AddError(new FailedValidation()
                            {
                                CurrentValue = value,
                                Message = attribute.Message,
                                Property = property.Name,
                            });
                        }
                    }
                }
            }

            return result;
        }
    }
}
