using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [Table("status")]
    public class StatusModel
    {
        public StatusModel()
        {
            processos = new HashSet<ProcessoModel>();
            usuario_processo = new HashSet<Usuario_ProcessoModel>();
        }
       
        [Key]
        public int ID_STATUS { get; set; }
        public string Status_Atual { get; set; }


        public virtual ICollection<ProcessoModel> processos { get; set; }

        public virtual ICollection<Usuario_ProcessoModel> usuario_processo { get; set; }

      
    }

    
}
