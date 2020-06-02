using Cadastro.Model;
using Cadastro.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.ModelBinding;

namespace Cadastro_DAO_Entity
{
    public class ProcessoContext
    {
        private BaseContext baseContext = new BaseContext();


        // lista os processos
        public List<ProcessoModel> ListaProcessos(List<StatusEnum> status)
        {
            return baseContext.processos.Where(p => status.Contains((StatusEnum)p.ID_status)).ToList();
        }
        // salva o processo 
        public int SalvarProcesso(ProcessoModel processo)
        {
            var novoProcesso = processo;
            novoProcesso.ID_status =(int)StatusEnum.EM_COLOCACAO;

            baseContext.processos.Add(novoProcesso);
            baseContext.SaveChanges();
            var id_processo = novoProcesso.ID_Processo;

            return id_processo;

        }
        // exclui o processo
        public bool ExcluirProcesso(int id)
        {
            if (id > 0)
            {
                ProcessoModel processos = baseContext.processos.Find(id);
                baseContext.processos.Remove(processos);
                baseContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }
        // busca o processo para editar
        public ProcessoModel GetProcesso(int id)
        {
            return baseContext.processos.Find(id);

        }
        // salva os dados do processo editado
        public void PostProcesso(ProcessoModel processo)
        {
            baseContext.Entry(processo).State = EntityState.Modified;
            baseContext.SaveChanges();

        }















        //public bool PostEditarProcesso(ProcessoModel processo)
        //{
        //    if (processo != null)
        //    {
        //        db.Entry(processo).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }}

    }
}







