using Ninject.Modules;

namespace Exemplo.CrossCutting
{
    public class ModuloServico : NinjectModule
    {
        public override void Load()
        {
            //Bind<IProdutoServico>().To<ProdutoServico>();
        }
    }
}
