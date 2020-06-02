using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [Table("estado")]
   public class EstadoModel
    {

        public EstadoModel()
        {
            cidade = new HashSet<CidadeModel>();
        }
        [Key]
        public int ID_ESTADO { get; set; }
        public int ID_PAIS { get; set; }
        public String NOME { get; set; }
        public virtual ICollection<CidadeModel> cidade { get; set; }
        public virtual PaisModel pais { get; set; }
    }
}
