using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.DAL.Repositorios;
using Repositorio.Entidades;

namespace Repositorio.ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Adicionar();

        }

        private static void Adicionar()
        {
            using (var contato = new ContatoRepositorio())
            {
                new List<Contato>
                {
                    new Contato { Nome="Joao", Ativo=true,  SobreNome = "Munarim", Telefone = "123456789"},
                    new Contato { Nome="Maria", Ativo=true,  SobreNome = "Munarim", Telefone = "89456123"}
                }.ForEach(contato.Adicionar);

                contato.SalvarTodos();

                System.Console.WriteLine("Contatos adicionadas com sucesso.");

                System.Console.WriteLine("=======  contatos cadastrados ===========");
                foreach (var c in contato.GetAll())
                {
                    System.Console.WriteLine("{0} - {1}", c.ContatoID, c.Nome);
                }

                System.Console.ReadKey();
            }
        }
    }
}

