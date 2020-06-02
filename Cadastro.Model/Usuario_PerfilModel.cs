using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [Table("usuario_perfil")]
    public class Usuario_PerfilModel
    {
        [Key]
        public int ID_Usuario_Perfil { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_PERFIL { get; set; }

        public virtual perfisModel PerfisModel { get; set; }
        public virtual UsuarioModel Usuario { get; set; }

    }
}
