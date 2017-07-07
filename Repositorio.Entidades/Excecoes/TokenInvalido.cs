using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Entidades.Excecoes
{
    [Serializable()]
    public class TokenInvalido: Exception
    {
        public TokenInvalido()
        {
        }
        public TokenInvalido(string message)
        {
        }
        public TokenInvalido(string message, Exception inner)
        {
        }
        protected TokenInvalido(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
