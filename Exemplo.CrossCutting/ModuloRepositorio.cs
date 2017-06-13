using Ninject.Modules;

namespace Exemplo.CrossCutting
{
    public class ModuloRepositorio : NinjectModule
    {
        public override void Load()
        {
            //Bind<IProdutoServico>().To<ProdutoServico>();
        }
    }
}
