using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuickUp.HomeTaks.Day3.Validation
{
    public class ClassicBookAttribute : ValidationAttribute, IClientModelValidator
        {
            private int _year;

            public ClassicBookAttribute(int Year)
            {
                _year = Year;
            }

        public void AddValidation(ClientModelValidationContext context)
        {
            throw new NotImplementedException();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                Book book= (Book)validationContext.ObjectInstance;

                if (book.Genre == Genre.Classic && book.ReleaseDate.Year > _year)
                {
                    return new ValidationResult("It is not a classic book");
                }

                return ValidationResult.Success;
            }
        }
}
