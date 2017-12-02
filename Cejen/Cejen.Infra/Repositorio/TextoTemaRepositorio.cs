using Cejen.Dominio.TextoTema;
using Cejen.Infra.Data;

namespace Cejen.Infra.Repositorio
{
    public class TextoTemaRepositorio : RepositorioBase<TextoTema>, ITextoTemaRepositorio
    {
        public TextoTemaRepositorio(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
