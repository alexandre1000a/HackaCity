using System;
using System.Data.Common;
using System.Data.Entity.Validation;

namespace Cejen.Infra.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public static IDbContext Context { get; set; }

        public DbTransaction Transaction { get; set; }

        public UnitOfWork(IDbContext context)
        {
            Context = context;
        }

        public IDbContext Contexto()
        {
            return Context;
        }

        public void Commit()
        {
            if (Context != null)
            {

                try
                {
                    // Your code...
                    // Could also be before try if you know the exception occurs in SaveChanges
                    Context.SaveChanges();

                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                                ve.PropertyName,
                                eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                                ve.ErrorMessage);
                        }
                    }
                    throw;
                }
            }
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
        }
    }
}