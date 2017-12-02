using Cejen.Dominio.Tema;
using Cejen.Infra.Data;

namespace Cejen.Infra.Repositorio
{
    public class TemaRepositorio : RepositorioBase<Tema>, ITemaRepositorio
    {
        public TemaRepositorio(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
