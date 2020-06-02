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
    [Table("processos")]
    public class ProcessoModel
    {
        public ProcessoModel()
        {
           usuario_processo = new HashSet<Usuario_ProcessoModel>();
        }
        [Key]
        public int ID_Processo { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public string celular { get; set; }
        public int ID_status { get; set; }
        public int ID_Cidade { get; set; }
        public DateTime Data_nascimento { get; set; }

        [ForeignKey("ID_Cidade")]
        public virtual CidadeModel Cidade { get; set; }
        public virtual StatusModel StatusModel { get; set; }

       public virtual ICollection<Usuario_ProcessoModel> usuario_processo { get; set; }

    }
}
