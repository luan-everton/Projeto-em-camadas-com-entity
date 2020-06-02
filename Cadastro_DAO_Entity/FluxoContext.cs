using Cadastro.Util;
using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_DAO_Entity
{
  public class FluxoContext
    {
        private BaseContext baseContext = new BaseContext();
        // encaminha um processo ao gerente 
        public void EncaminhaGerente(int idProcesso)
        {
            var processo = baseContext.processos.SingleOrDefault(p => p.ID_Processo == idProcesso);
            processo.ID_status =(int)StatusEnum.APRO_GERENTE;
            baseContext.SaveChanges();
        }
        // aprova um processo
        public void AprovarProcesso(int idProcesso)
        {
            var processo = baseContext.processos.SingleOrDefault(p => p.ID_Processo == idProcesso);
            processo.ID_status = (int)StatusEnum.APROVADO;
            baseContext.SaveChanges();
        }
        // reprova um processo

        public void ReprovarProcesso(int idProcesso)
        {
            var processo = baseContext.processos.SingleOrDefault(p => p.ID_Processo == idProcesso);
            processo.ID_status = (int)StatusEnum.REPROVADO;
            baseContext.SaveChanges();
        }
         // pede a correcao de um projeto 
        public void CorrecaoProcesso(int idProcesso)
        {
            var processo = baseContext.processos.SingleOrDefault(p => p.ID_Processo == idProcesso);
            processo.ID_status = (int)StatusEnum.CORRECAO;
            baseContext.SaveChanges();

        }
        // metedo especifico para aprovacao do gerente e faz a verificao se o processo é nacional, se nao for encaminha ao 
        //controle de risco

        public void AprovaGerente(int idProcesso)
        {
            var processo = baseContext.processos.SingleOrDefault(p => p.ID_Processo == idProcesso);
          
            if (processo.Cidade.estado.ID_PAIS !=6)
            {
                processo.ID_status = (int)StatusEnum.APRO_CONT_RISCO;
                baseContext.SaveChanges();
            }
            else
            {
                processo.ID_status = (int)StatusEnum.APROVADO;
                baseContext.SaveChanges();
            }
        }

        // metodo que faz todo o historico de um processo
        public void Rastreabilidade(int idProcesso, int idUsuario, int idStatus)
        {
            var usuarioP = new Usuario_ProcessoModel {ID_PROCESSO = idProcesso, ID_USUARIO = idUsuario, ID_STATUS= idStatus, Data_entrada = DateTime.Now,Data_saida= DateTime.Now};
            baseContext.usuarioprocesso.Add(usuarioP);
            baseContext.SaveChanges();
        }
        // metodo que nao deixa o usuario que cadastrou um processo  aprovar o mesmo 
        public Usuario_ProcessoModel UsuarioNaoPodeCadastrareSalvar(int idProcesso)
        {
            var processo = baseContext.usuarioprocesso.FirstOrDefault(p => p.ID_PROCESSO == idProcesso);

            return processo;

        }


    }
}
