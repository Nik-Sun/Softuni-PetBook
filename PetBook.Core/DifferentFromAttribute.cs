using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core
{
    internal class DifferentFromAttribute : ValidationAttribute
    {
        private readonly string comparisonProperty;
        private string errorMessage;

        public DifferentFromAttribute(string _comparisonProperty, string errorMessage = "The values are the same.")
        {
            comparisonProperty = _comparisonProperty;
            this.errorMessage = errorMessage;
        }
        protected override ValidationResult IsValid(object? value,ValidationContext validationContext)
        {
            var property = validationContext.ObjectType.GetProperty(comparisonProperty);

            if (property == null)
            {
                throw new ArgumentException("Property with this name not found");
            }

            if ((string?)value == (string?)property.GetValue(validationContext.ObjectInstance))
            {
                return new ValidationResult(errorMessage);
            }
            return ValidationResult.Success;
               
        }
      
    }
}
