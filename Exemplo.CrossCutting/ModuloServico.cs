using Exemplo.Domain.Interfaces.Services;
using Exemplo.Domain.Services;
using Ninject.Modules;

namespace Exemplo.CrossCutting
{
    public class ModuloServico : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductService>();
            Bind<ICategoryService>().To<CategoryService>();
            Bind<ILogService>().To<LogService>();
        }
    }
}
