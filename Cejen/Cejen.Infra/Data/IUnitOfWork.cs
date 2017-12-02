using Cejen.Infra.Data;
namespace Cejen.Infra.Data
{
    public interface IUnitOfWork
    {
        void Commit();

        void Dispose();

        IDbContext Contexto();
    }
}