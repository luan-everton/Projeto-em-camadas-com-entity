using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Model
{
    [Table("usuario_processo")]
    public class Usuario_ProcessoModel
    {
        [Key]
        public int ID_usuario_processo { get; set; }
        public DateTime Data_entrada { get; set; }
        public DateTime Data_saida { get; set; }
        public int  ID_PROCESSO { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_STATUS { get; set; }
        public virtual StatusModel Status { get; set; }
        public virtual UsuarioModel Usuario { get; set; }
        public virtual ProcessoModel Processo { get; set; }





    }
}
