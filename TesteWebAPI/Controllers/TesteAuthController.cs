using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Microsoft.Owin.Security;

namespace TesteWebAPI.Controllers
{
    public class TesteAuthController : ApiController
    {
        private IAuthenticationManager Authentication
        {
            get { return HttpContext.Current.GetOwinContext().Authentication; }
        }

        // GET api/testauth
        [Authorize]
        public string Get()
        {
            return this.Authentication.User.Identity.Name;
        }
    }
}
