using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [Table("perfis")]
   public class perfisModel
    {

        public perfisModel()
        {
            usuario_perfil = new HashSet<Usuario_PerfilModel>();
        }
        [Key]
        public int ID_perfil { get; set; }
        public string tipo_perfil { get; set; }

        public virtual ICollection<Usuario_PerfilModel> usuario_perfil { get; set; }


    }
}
