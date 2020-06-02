using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Model
{
    [Table("usuarios")]
    public class UsuarioModel
    {
        public UsuarioModel()
        {
            usuario_perfil = new HashSet<Usuario_PerfilModel>();
            usuario_processo = new HashSet<Usuario_ProcessoModel>();
        }
        [Key]
        public int ID_Usuario { get; set; }
     
        public String Nome  { get; set; }
        public String  Login { get; set; }

        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public String  Senha { get; set; }
        public virtual ICollection<Usuario_PerfilModel> usuario_perfil { get; set; }

        public virtual ICollection<Usuario_ProcessoModel> usuario_processo { get; set; }


    }


}
