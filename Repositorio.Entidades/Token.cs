using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades
{
    public class Token
    {
        public string IdentificacaoToken { get; set; }

        public DateTime DataExpiracao { get; set; }
    }
}
