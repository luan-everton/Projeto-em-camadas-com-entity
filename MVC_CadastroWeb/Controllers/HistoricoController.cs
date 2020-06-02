using Cadastro.BL;
using Cadastro_DAO_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CadastroWeb.Controllers
{
    public class HistoricoController : Controller
    {
        // GET: Historico
        public ActionResult Historico()
        {
            HistoricoBL historico = new HistoricoBL();

            return View("Historico", historico.GetProcessoModels());
        }
    }
}