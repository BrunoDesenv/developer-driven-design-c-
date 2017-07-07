using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;

namespace Exemplo.Infra.Data.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
    }
}
