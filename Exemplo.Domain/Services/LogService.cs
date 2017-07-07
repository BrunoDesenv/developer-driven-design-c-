using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Repositories;
using Exemplo.Domain.Interfaces.Services;

namespace Exemplo.Domain.Services
{
    public class LogService : ILogService
    {
        private ILogRepositoy _logRepository;

        public LogService(ILogRepositoy logRepository)
        {
            _logRepository = logRepository;
        }

        public void Cadastrar(Log log)
        {
            _logRepository.Add(log);
        }
    }
}
