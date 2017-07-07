using Exemplo.Domain.Interfaces.Repositories;
using Exemplo.Infra.Data.Repositories;
using Ninject.Modules;

namespace Exemplo.CrossCutting
{
    public class ModuloRepositorio : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductRepository>().To<ProductRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
            Bind<ILogRepositoy>().To<LogRepository>();
        }
    }
}
