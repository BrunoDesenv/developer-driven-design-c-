using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;
using Exemplo.Infra.Data.Context;

namespace Exemplo.Infra.Data.Repositories
{
    public class LogRepositoy : ILogRepositoy
    {
        protected ExemploContext Db = new ExemploContext();

        public void Add(Log log)
        {
            Db.Set<Log>().Add(log);
            Db.SaveChanges();
        }
    }
}
