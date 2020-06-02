
using Cadastro.Model;
using Cadastro_DAO_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BL
{
    public class LoginBL
    {
       
        private LoginContext db = new LoginContext();
        public UsuarioModel isCorrectPassWord(String Login, String Senha)
        {
            return db.Login(Login, Senha);
        }
    }
}
