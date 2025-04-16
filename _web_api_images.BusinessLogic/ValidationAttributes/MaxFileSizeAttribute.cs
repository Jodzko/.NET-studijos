using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace _web_api_images.ValidationAttributes
{
    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;

        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is IFormFile file)
            {
                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult($"Max file size is {_maxFileSize}");
                }
            }

            return ValidationResult.Success;
        }
    }
}
