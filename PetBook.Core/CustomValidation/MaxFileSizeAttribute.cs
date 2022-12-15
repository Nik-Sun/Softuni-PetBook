using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Core.CustomValidation
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid(
        object? value, ValidationContext validationContext)
        {
            var collection = value as ICollection<IFormFile>;
            if (collection != null)
            {
                foreach (var file in collection)
                {
                    long size = file.Length;
                    if ( size > _maxFileSize)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }
                
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Maximum allowed file size is {_maxFileSize} megabytes.";
        }
    }
}
