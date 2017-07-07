using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;

namespace Exemplo.Infra.Data.Repositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {

    }

}
