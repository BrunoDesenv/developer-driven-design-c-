using Exemplo.Domain.Interfaces.Services;
using Exemplo.Domain.Services;
using Ninject.Modules;

namespace Exemplo.CrossCutting
{
    public class ModuloRepositorio : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductService>();
        }
    }
}
