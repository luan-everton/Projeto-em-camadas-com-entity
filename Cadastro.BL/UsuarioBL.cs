using Cadastro.Util;
using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.BL
{
    public class UsuarioBL
    {

        public List<StatusEnum> ListaStatus(List<PerfilEnum> perfis)
        {
            List<StatusEnum> status = new List<StatusEnum>();
            foreach (var item in perfis)
            {
                switch (item)
                {
                    case PerfilEnum.Administracao:
                        // ADMINISTRACAO
                        List<StatusEnum> listaADM = new List<StatusEnum>()
                        { StatusEnum.APROVADO,StatusEnum.REPROVADO,StatusEnum.CORRECAO,
                          StatusEnum.APRO_GERENTE,StatusEnum.EM_COLOCACAO,StatusEnum.APRO_CONT_RISCO };
                        status = status.Concat(listaADM).ToList();
                        break;
                    case PerfilEnum.Gerencia:
                        //   GERENCIA
                        List<StatusEnum> listaGerente = new List<StatusEnum>() { StatusEnum.APRO_GERENTE, StatusEnum.REPROVADO, StatusEnum.CORRECAO,StatusEnum.APROVADO};
                        status = status.Concat(listaGerente).ToList();
                        break;
                    case PerfilEnum.Operecao:
                        // OPERACAO
                        List<StatusEnum> listaOPERACAO = new List<StatusEnum>() { StatusEnum.EM_COLOCACAO, StatusEnum.CORRECAO, StatusEnum.REPROVADO , StatusEnum.APROVADO};
                        status = status.Concat(listaOPERACAO).ToList();
                        break;
                    case PerfilEnum.ControleRisco:
                        // CONTROLE DE RISCO
                        List<StatusEnum> listaCONT_RISCO = new List<StatusEnum>() { StatusEnum.APROVADO, StatusEnum.REPROVADO, StatusEnum.APRO_CONT_RISCO };
                        status = status.Concat(listaCONT_RISCO).ToList();
                        break;
                    default:
                        break;
                }
            }

            return status;

        }


    }
}
