namespace Repositorio.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Entidades;
    internal sealed class Configuration : DbMigrationsConfiguration<Repositorio.DAL.Contexto.BancoContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Repositorio.DAL.Contexto.BancoContexto context)
        {
            //context.Contato.AddOrUpdate(
            //  p => p.Nome,
            //  new Contato { Nome = "Joao", Ativo = true, SobreNome = "Munarim", Telefone = "123456789" },
            //  new Contato { Nome = "Maria", Ativo = true, SobreNome = "Munarim", Telefone = "89456123" }
            //);
        }
    }
}
