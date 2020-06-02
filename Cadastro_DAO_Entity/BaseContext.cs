using Cadastro.Model;
using Cadastro_Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_DAO_Entity
{
    public class BaseContext : DbContext 
    {
        public BaseContext (): base("DBUBS") { }
        public DbSet<CidadeModel> cidade { get; set; }
        public DbSet<EstadoModel> estados { get; set; }
        public DbSet<PaisModel> pais { get; set; }
        public DbSet<perfisModel> perfis { get; set; }
        public DbSet<ProcessoModel> processos { get; set; }
        public DbSet<StatusModel> status { get; set; }
        public DbSet<Usuario_PerfilModel> usuarioperfil { get; set; }
        public DbSet<Usuario_ProcessoModel> usuarioprocesso { get; set; }
        public DbSet<UsuarioModel> usuarios { get; set; }


        
    }

    
}
