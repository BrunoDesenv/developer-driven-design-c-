using DomainValidation.Interfaces.Validation;
using System;
using DomainValidation.Validation;

namespace Exemplo.Domain.Entities
{
    public class Category : ISelfValidator
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Active { get; set; }
        public DateTime DateRegister { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            return ValidationResult.IsValid;
        }
    }
}
