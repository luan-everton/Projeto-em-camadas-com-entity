using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_DAO_Entity
{
    public class LoginContext : BaseContext
    {
        private BaseContext baseContext = new BaseContext();
        public UsuarioModel Login(string login, string senha)
        {
          
            var usuario = baseContext.usuarios.Where(a => a.Login.Equals(login) && a.Senha.Equals(senha)).FirstOrDefault();
            return usuario;
        }
    }
}
