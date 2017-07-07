using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;
using Exemplo.Domain.Interfaces.Services;

namespace Exemplo.Domain.Services
{
    public class ProductService : BaseService<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
