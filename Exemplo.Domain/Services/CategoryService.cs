using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;
using Exemplo.Domain.Interfaces.Services;

namespace Exemplo.Domain.Services
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

    }
}
