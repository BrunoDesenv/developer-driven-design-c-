using DomainValidation.Interfaces.Specification;
using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;

namespace Exemplo.Domain.Specifications.Products
{
    public class ProductMustHaveDiscountSpecification : ISpecification<Product>
    {
        private readonly IProductRepository _productRepository;
        private int categoryVip = 2;


        public ProductMustHaveDiscountSpecification(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool IsSatisfiedBy(Product product)
        {
            if (product.IdCategory == categoryVip)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
