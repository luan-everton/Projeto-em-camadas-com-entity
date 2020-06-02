using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_DAO_Entity
{
    public class HistoricoContext
    {
        private BaseContext baseContext = new BaseContext();
        // lista o historico de um processo
        public List<Usuario_ProcessoModel> GetUsuarioProcessos()
        {
          return baseContext.usuarioprocesso.ToList();
        }

    }
}
