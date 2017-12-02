using Cejen.Infra.Data;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using Cejen.Infra.Data;

namespace Cejen.Infra
{
    public class CejenDbContext : DbContext, IDbContext
    {
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        public CejenDbContext()
            : base(nameOrConnectionString: "Cejen")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CejenDbContext, Cejen.Infra.Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !String.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }

        //DbSet<Bairro> Bairros { get; set; }
        //DbSet<Cidade> Cidades { get; set; }
        //DbSet<Preco> Combustiveis { get; set; }
        //DbSet<Endereco> Enderecos { get; set; }
        //DbSet<Posto> Postos { get; set; }
        //DbSet<TipoLogradouro> TipoLogradouros { get; set; }
    }
}