using Cadastro.BL;
using Cadastro_DAO_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CadastroWeb.Controllers
{
    public class FluxoController : Controller
    {
       
        private FluxoBL fluxo = new FluxoBL();
        // acao que envia o processo ao gerente 
        public ActionResult EncaminhaGerente(int id)
        {
           
            var idUsuario = Convert.ToInt32(Session["ID_USUARIO"]);
            fluxo.EncaminhaGerente(id, idUsuario);
            
            return RedirectToAction("PaginaHome","Home");
        }
         // acao que aprova o processo
        public ActionResult AprovaProcesso(int id)
        {
            var idUsuario = Convert.ToInt32(Session["ID_USUARIO"]);
            fluxo.AprovarProcesso(id, idUsuario);
            return RedirectToAction("PaginaHome", "Home");
        }
        // acao que reprova o processo 
        public ActionResult ReprovarProcesso(int id)
        {
            
            var idUsuario = Convert.ToInt32(Session["ID_USUARIO"]);
            fluxo.ReprovarProcesso(id, idUsuario);
            return RedirectToAction("PaginaHome","Home");
        }
        // acao que pede a correcao do processo
        public ActionResult CorrecaoProcesso(int id)
        {
            var idUsuario = Convert.ToInt32(Session["ID_USUARIO"]);
            fluxo.CorrecaoProcesso(id, idUsuario);
            return RedirectToAction("PaginaHome", "Home");
        }
        // acao especifica aprovacao do gerente 
        public ActionResult AprovaGerente(int id)
        {
            var idUsuario = Convert.ToInt32(Session["ID_USUARIO"]);
            fluxo.AprovaGerente(id, idUsuario);
            return RedirectToAction("PaginaHome", "Home");
        }
    }
}