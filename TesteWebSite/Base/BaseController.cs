using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositorio.Entidades;
using Repositorio.Entidades.Excecoes;

namespace TesteWebSite.Base
{
    public class BaseController : Controller
    {
        public bool ValidarToken(Token token)
        {
            if (token == null || DateTime.Now > token.DataExpiracao)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
