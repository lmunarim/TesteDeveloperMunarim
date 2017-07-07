using System.Data.Entity;
using Repositorio.Entidades;

namespace Repositorio.DAL.Contexto
{
    public class BancoContexto : DbContext
    {
        public BancoContexto() : base("ConnDB") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>().ToTable("Contato");
        }
    }
}