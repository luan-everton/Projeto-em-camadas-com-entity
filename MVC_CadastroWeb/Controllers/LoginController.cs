using Cadastro.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cadastro.Model;
using System.Web.Security;
using Cadastro.Util;

namespace MVC_CadastroWeb.Controllers
{
    public class LoginController : Controller
    {
        
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(String Login, String Senha)
        {
            if (ModelState.IsValid)
            {
                LoginBL login = new LoginBL();
                UsuarioBL usuarioBL = new UsuarioBL();
                 UsuarioModel  usuario = login.isCorrectPassWord(Login,Senha);
                if (usuario != null)
                { 

                    Session["ID_USUARIO"] = usuario.ID_Usuario.ToString();
                    Session["NOME"] = usuario.Nome.ToString();
                    Session["Usuario"] = usuario;
                    Session["StatusPermitido"] = usuarioBL.ListaStatus(usuario.usuario_perfil.Select(u=>(PerfilEnum)u.ID_PERFIL).ToList());
                    return RedirectToAction("PaginaHome", "Home");
                }
                else
                {
                    return RedirectToAction("Login");
                }

            }
            else
            {
                return RedirectToAction("Login");
            }
         
        }
        public ActionResult UserDashBoard()
        {
            if (Session["ID_USUARIO"] != null)
            {
                return RedirectToAction("PaginaHome", "Home");
            }
            else
            {
                return RedirectToAction("Login", "Login");
            }
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            return RedirectToAction("Login", "Login");
        }



    }
}