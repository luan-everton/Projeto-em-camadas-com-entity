using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Dao
{
   public  class UsuarioDao : BaseDao
    {
        /// <summary>
        /// retorna usuarios 
        /// </summary>
        /// <returns></returns>
        public List<UsuarioModel> GetUsuarios()
        {
            List<UsuarioModel> list = new List<UsuarioModel>();
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                SqlCommand cmd = new SqlCommand("SELECT * FROM usuarios", cn);
                cn.Open();
                var r = cmd.ExecuteReader();
                while(r.Read())
                {
                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.ID_Usuario = int.Parse(r["ID_Usuario"].ToString());
                    usuarioModel.Login = r["login"].ToString();
                    usuarioModel.Nome = r["nome"].ToString();
                    usuarioModel.Senha = r["senha"].ToString();


                    list.Add(usuarioModel);

                    
                }

                return list;
            }
        }
        public UsuarioModel Login(string login, string senha)
        {

            SqlCommand command;
            UsuarioModel usuario = new UsuarioModel();



            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = StringDeConexao;
                command = new SqlCommand(@"Select * from usuarios U
                    INNER JOIN USUARIO_PERFIL UP ON UP.ID_Usuario = U.ID_Usuario
                    INNER JOIN perfis P on P.ID_PERFIL = UP.ID_PERFIL
                WHERE LOGIN = @login AND SENHA = @senha", connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@senha", senha);



                command.CommandType = CommandType.Text;
                connection.Open();



                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    usuario.ID_Usuario = Convert.ToInt32(reader["ID_USUARIO"]);
                    usuario.Nome = reader["NOME"].ToString();
                  //  usuario.ID_Perfil = int.Parse(reader["ID_PERFIL"].ToString());
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
