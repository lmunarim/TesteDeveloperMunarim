using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositorio.DAL.Contexto;
using Repositorio.DAL.Repositorios;
using Repositorio.Entidades;
using TesteWebSite.Base;

namespace TesteWebSite.Controllers
{
    public class ContatoController : BaseController
    {
        
        private readonly ContatoRepositorio contato = new ContatoRepositorio();

        // GET: Contato
        public ActionResult Index()
        {
            // Validamos o token
            if (!ValidarToken((Token)Session["token"]))
                return Redirect("Login/Login");

            return View(contato.GetAll().ToList());
        }

        protected override void Dispose(bool disposing)
        {
            contato.Dispose();
            base.Dispose(disposing);
        }
    }
}