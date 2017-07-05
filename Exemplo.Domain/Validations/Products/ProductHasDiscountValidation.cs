using DomainValidation.Validation;
using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;
using Exemplo.Domain.Specifications.Products;

namespace Exemplo.Domain.Validations.Products
{
    public class ProductHasDiscountValidation : Validator<Product>
    {
        public ProductHasDiscountValidation(IProductRepository productyRepository)
        {
            var discount = new ProductMustHaveDiscountSpecification(productyRepository);

            base.Add("Erro no Desconto", new Rule<Product>(discount, "Não foi possível aplicar o desconto."));
        }
    }
}
