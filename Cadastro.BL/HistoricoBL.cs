using Cadastro_DAO_Entity;
using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BL
{
    public class HistoricoBL
    {
        private HistoricoContext historicoContext = new HistoricoContext();
        //lista o historico de um processo
        public List<Usuario_ProcessoModel> GetProcessoModels()
        {
           return historicoContext.GetUsuarioProcessos().ToList();
            
        }
    }
}
