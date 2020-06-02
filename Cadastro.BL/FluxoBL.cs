using Cadastro_DAO_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BL
{
    public class FluxoBL
    {
        FluxoContext fluxoContext = new FluxoContext();
        ProcessoContext processoContext = new ProcessoContext();
        // encaminha o processo para o gerente 
        public void EncaminhaGerente(int idProcesso, int idUsuario)
        {
            fluxoContext.EncaminhaGerente(idProcesso);
            var processo = processoContext.GetProcesso(idProcesso);
            fluxoContext.Rastreabilidade(idProcesso, idUsuario, processo.ID_status);
        }
        // aprova o processo
        public void AprovarProcesso(int idProcesso, int idUsuario)
        {
            if (UsuarioNaoPodeCadastrareSalvar(idProcesso, idUsuario))
            {
                fluxoContext.AprovarProcesso(idProcesso);
                var processo = processoContext.GetProcesso(idProcesso);
                fluxoContext.Rastreabilidade(idProcesso, idUsuario, processo.ID_status);
            }
        }
        // reprova um processo
        public void ReprovarProcesso(int idProcesso, int idUsuario)
        {
            fluxoContext.ReprovarProcesso(idProcesso);
            var processo = processoContext.GetProcesso(idProcesso);
            fluxoContext.Rastreabilidade(idProcesso, idUsuario, processo.ID_status);
        }
        // pede a correcao de um processo
        public void CorrecaoProcesso(int idProcesso, int idUsuario)
        {
            fluxoContext.CorrecaoProcesso(idProcesso);
            var processo = processoContext.GetProcesso(idProcesso);
            fluxoContext.Rastreabilidade(idProcesso, idUsuario, processo.ID_status);
        }
        // metodo especifico que tem a aprovacao pelo gerente 
        public void AprovaGerente(int idProcesso, int idUsuario)
        {
            if (UsuarioNaoPodeCadastrareSalvar(idProcesso, idUsuario))
            {
                fluxoContext.AprovaGerente(idProcesso);
                var processo = processoContext.GetProcesso(idProcesso);
                fluxoContext.Rastreabilidade(idProcesso, idUsuario, processo.ID_status);

            }
            
        }

        public bool UsuarioNaoPodeCadastrareSalvar(int idProcesso, int idUsuario)
        {
            var resultado = fluxoContext.UsuarioNaoPodeCadastrareSalvar(idProcesso);
            var status = resultado.ID_STATUS;
            var usuario = resultado.ID_USUARIO;

            if (status==1 && usuario!= idUsuario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
