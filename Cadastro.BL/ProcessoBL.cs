
using Cadastro.Model;
using Cadastro.Util;
using Cadastro_DAO_Entity;
using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BL
{
    public class ProcessoBL
    {
      public ProcessoContext processoContext = new ProcessoContext();
      public CidadeContext cidadeContext = new CidadeContext();

        // metodo que lista os processos na pagina home
        public List<ProcessoModel> ExibePaginaHome(List<StatusEnum>status)
        {
            List<ProcessoModel> lista = processoContext.ListaProcessos(status);
            return lista;

        }
         // salva o processo
        public int SalvarProcesso(ProcessoModel processo)
        {

            return processoContext.SalvarProcesso(processo);

        }
        // busca o processo 
        public ProcessoModel GetProcesso(int id)
        {
           
            return processoContext.GetProcesso(id);
        }
         // edita um processo
        public bool PostEditarProcesso(ProcessoModel processo)
        {
           if(processo!= null)
            {
                processoContext.PostProcesso(processo);
                return true;
            }
            else
            {
                return false;
            }

        }
        // exclui um processo
        public bool ExcluirProcesso(int id)
        {
           
            return processoContext.ExcluirProcesso(id);
        }
      // lista os paises 
        public List<PaisModel> GetPais()
        {

            return cidadeContext.GetPais();
        }
        // lista os estados do pais selecionado
        public List<EstadoModel> GetEstado(int IdPais)
        {
            
            return cidadeContext.GetEstado(IdPais);
        }
        // lista as cidades do estado selecionado

        public List<CidadeModel> GetCidade(int IdEstado)
        {
            return cidadeContext.GetCidade(IdEstado);
        }
       
    }

}
