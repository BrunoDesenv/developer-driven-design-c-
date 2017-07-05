using DomainValidation.Interfaces.Validation;
using DomainValidation.Validation;
using System;

namespace Exemplo.Domain.Entities
{
    public class Product : ISelfValidator
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int IdCategory { get; set; }
        public virtual Category Category { get; set; }
        public int Active { get; set; }
        public DateTime DateRegister { get; set; }

        public ValidationResult ValidationResult { get; set; }

        public bool IsValid()
        {
            return ValidationResult.IsValid;
        }
    }
}
