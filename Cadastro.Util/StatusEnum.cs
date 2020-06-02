using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Util
{
   public enum StatusEnum :int
    {
         EM_COLOCACAO = 1,
         APROVADO = 2,
         REPROVADO = 3,
         CORRECAO = 4,
         APRO_GERENTE = 6,
         APRO_CONT_RISCO = 7


    }
}
