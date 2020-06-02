using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [NotMapped]
   public class ViewProcessoEditarModel:ProcessoModel
    {
        public int ID_ESTADO { get; set; }
        public int ID_PAIS { get; set; }

        public string Cidade { get; set; }

        public string DescricaoStatus { get; set; }
    }
}
