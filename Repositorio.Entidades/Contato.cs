namespace Repositorio.Entidades
{
    public class Contato
    {
        public int ContatoID { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; }
    }
}