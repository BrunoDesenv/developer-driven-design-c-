using DomainValidation.Interfaces.Specification;
using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;

namespace Exemplo.Domain.Specifications.Products
{
    public class ProductMustHaveDiscountSpecification : ISpecification<Product>
    {
        private readonly IProductRepository _productRepository;

        public ProductMustHaveDiscountSpecification(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool IsSatisfiedBy(Product product)
        {
            return product.Discount != 0M;
        }
    }
}
