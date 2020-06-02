
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cadastro.BL;

using Cadastro.Model;
using Cadastro.Util;
using Cadastro_Model;

namespace MVC_CadastroWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult PaginaHome()
        {

            ProcessoBL processo = new ProcessoBL();
            List<StatusEnum> perfis = Session["StatusPermitido"] as List<StatusEnum>;

            
            return View("PaginaHome", processo.ExibePaginaHome(perfis));

        }

       
    }

}