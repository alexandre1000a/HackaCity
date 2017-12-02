using System.Collections.Generic;

namespace Cejen.Dominio.Comum
{
    public interface IRepositorioBase<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}