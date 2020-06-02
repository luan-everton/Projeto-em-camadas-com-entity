using Cadastro.BL;
using Cadastro.Model;
using Cadastro_DAO_Entity;
using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_CadastroWeb.Controllers
{
    public class ProcessoController : Controller
    {
        public ProcessoBL Processo = new ProcessoBL();
       
        public FluxoContext fluxo = new FluxoContext();


        public ActionResult Index()
        {
            GetPais();
            return View();
        }
        // METODO PARA SALVAR UM PROCESSO
        [HttpPost]
        public ActionResult SalvarProcesso(ProcessoModel processo)
        {

            var idUsuario = Convert.ToInt32(Session["ID_USUARIO"]);
            var idProcesso = Processo.SalvarProcesso(processo);
            var novo = Processo.GetProcesso(idProcesso);
            fluxo.Rastreabilidade(idProcesso, idUsuario, novo.ID_status);
            return RedirectToAction("PaginaHome", "Home");


        }

        // EXCLUIR O PROCESSO
        public ActionResult ExcluirProcesso(int id)
        {

            if (Processo.ExcluirProcesso(id))
            {
                return RedirectToAction("PaginaHome", "Home");
            }
            else
            {
                return Content("Erro, Erro ao tentar excluir ");
            }

        }
        // BUSCA O PROCESSO METODO GET PARA EDITAR
        [HttpGet]
        public ActionResult EditarProcesso(int id)
        {
            ProcessoModel model = Processo.GetProcesso(id);


            GetPais();
            GetListaEstado(model.Cidade.estado.ID_PAIS);
            GetListaCidade(model.Cidade.ID_ESTADO);

            return View("EditarProcesso", model);
        }
        // METODO POST EDITAR O PROCESSO
        [HttpPost]
        public ActionResult EditarProcesso(ProcessoModel model)
        {
            model.ID_Cidade = model.Cidade.ID_CIDADE;
            if (Processo.PostEditarProcesso(model))
                return RedirectToAction("PaginaHome", "home");
            else
                return Content("ERRO, Processo não concluido");
        }
        // METODO PARA BUSCAR OS PAISES
        public void GetPais()
        {
            ViewBag.GetPais = Processo.GetPais();
        }
        // METODO PARA LISTAR OS ESTADOS 
        public void GetListaEstado(int ID_PAIS)
        {
            ViewBag.GetEstado = Processo.GetEstado(ID_PAIS);

        }

        // METODO PARA LISTAR AS CIDADES 

        public void GetListaCidade(int ID_ESTADO)
        {
            ViewBag.GetCidade = Processo.GetCidade(ID_ESTADO);
        }
        public ActionResult GetEstado(int Id_pais)
        {

            return Json(new SelectList(Processo.GetEstado(Id_pais), "ID_ESTADO", "NOME"), JsonRequestBehavior.AllowGet);

        }
        public ActionResult GetCidade(int Id_Estado)
        {

            return Json(new SelectList(Processo.GetCidade(Id_Estado), "ID_CIDADE", "NOME"), JsonRequestBehavior.AllowGet);
        }
    }
}
