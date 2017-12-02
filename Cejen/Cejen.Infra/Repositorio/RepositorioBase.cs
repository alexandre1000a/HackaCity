using Cejen.Dominio.Comum;
using Cejen.Infra.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Cejen.Infra.Data;

namespace Cejen.Infra.Repositorio
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        protected IDbSet<T> Entities
        {
            get { return _unitOfWork.Contexto().Set<T>(); }
        }

        protected RepositorioBase(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.AsQueryable();
        }

        public T GetById(int id)
        {
            return Entities.Find(id);
        }

        public void Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(entity.ToString());
            Entities.Add(entity);
            //this.Context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(entity.ToString());
            //this.Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(entity.ToString());
            Entities.Remove(entity);
            //this.Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_unitOfWork != null)
                {
                    _unitOfWork.Contexto().Dispose();
                }
            }
        }
    }
}