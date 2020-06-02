using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [Table("cidade")]
    public  class CidadeModel
    {
        public CidadeModel()
        {
            processos = new HashSet<ProcessoModel>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_CIDADE { get; set; }
        public int ID_ESTADO { get; set; }
        public String Nome { get; set; }
        public virtual EstadoModel estado { get; set; }


        public virtual ICollection<ProcessoModel> processos { get; set; }



    }
}
