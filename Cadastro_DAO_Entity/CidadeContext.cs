using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_DAO_Entity
{
    public class CidadeContext
    {
        BaseContext baseContext = new BaseContext();
        // lista os paises
        public List<PaisModel> GetPais()
        {
            return baseContext.pais.ToList();
        }
        // lista os estados 
        public List<EstadoModel> GetEstado(int id_pais)
        {
            return (from EstadoModel in baseContext.estados
                    where EstadoModel.ID_PAIS == id_pais
                    select EstadoModel).ToList();
        }
        // lista as cidades
        public List<CidadeModel> GetCidade(int ID_ESTADO)
        {
            return (from CidadeModel in baseContext.cidade
                    where CidadeModel.ID_ESTADO == ID_ESTADO
                    select CidadeModel).ToList();
        } 


       
    }
}
