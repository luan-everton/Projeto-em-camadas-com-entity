using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [Table("pais")]
    public class PaisModel
    {
        public PaisModel()
        {
            estados = new HashSet<EstadoModel>();
        }

        [Key]
        public int ID_Pais { get; set; }
        public String nome { get; set; }

        public virtual ICollection<EstadoModel> estados { get; set; }

    }
}
