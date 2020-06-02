using Cadastro.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Xml;
using Cadastro_Model;
using System.Security.Cryptography.X509Certificates;

namespace Cadastro.Dao
{
    public class ProcessoDao : BaseDao
    {
        public SqlCommand GetProcesso()
        {
            var cn = new SqlConnection();

            cn.ConnectionString = StringDeConexao;
            SqlCommand cmd = new SqlCommand("Select * from processos", cn);
            return cmd;
        }



        public List<ProcessoModel> ExibePaginaHome()
        { 

            using (SqlConnection connection = new SqlConnection(StringDeConexao))
            {
                List<ProcessoModel>  listaProcessos = new List<ProcessoModel>();
                SqlCommand command = new SqlCommand("Select * from processos", connection);
                command.CommandType = CommandType.Text;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var processo = new ProcessoModel();
                    processo.ID_Processo = Convert.ToInt32(reader["ID_PROCESSO"]);
                    processo.ID_status = Convert.ToInt32(reader["ID_STATUS"]);
                    processo.ID_Cidade = Convert.ToInt32(reader["ID_CIDADE"]);
                    processo.nome = reader["NOME"].ToString();
                    processo.cpf = reader["CPF"].ToString();
                    processo.Data_nascimento = Convert.ToDateTime(reader["Data_NASCIMENTO"]);
                    processo.email = reader["EMAIL"].ToString();
                    processo.cep = reader["CEP"].ToString();
                    processo.endereco = reader["ENDERECO"].ToString();
                    processo.bairro = reader["BAIRRO"].ToString();
                    processo.celular = reader["CELULAR"].ToString();
                    processo.sexo = reader["SEXO"].ToString();
                    listaProcessos.Add(processo);
                }

            return listaProcessos;
            }
        }
      
        public bool Salvar(ProcessoModel processo)
        {

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                SqlCommand cmd = new SqlCommand(@"INSERT INTO processos
                (CPF,NOME,ENDERECO,BAIRRO,CEP,SEXO,EMAIL,CELULAR,DATA_NASCIMENTO,ID_STATUS,ID_CIDADE) 
                VALUES(@CPF,@NOME,@ENDERECO,@BAIRRO,@CEP,@SEXO,@EMAIL,@CELULAR,
                @DATA_NASCIMENTO,@ID_STATUS,@ID_CIDADE)", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@CPF", processo.cpf.ToString());
                cmd.Parameters.AddWithValue("@NOME", processo.nome.ToString());
                cmd.Parameters.AddWithValue("@ENDERECO", processo.endereco.ToString());
                cmd.Parameters.AddWithValue("@BAIRRO", processo.bairro.ToString());
                cmd.Parameters.AddWithValue("@CEP", processo.cep.ToString());
                cmd.Parameters.AddWithValue("@SEXO", processo.sexo.ToString());
                cmd.Parameters.AddWithValue("@email", processo.email.ToString());
                cmd.Parameters.AddWithValue("@CELULAR", Convert.ToInt32(processo.celular));
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", Convert.ToDateTime(processo.Data_nascimento));
                cmd.Parameters.AddWithValue("@ID_CIDADE", Convert.ToInt32(processo.ID_Cidade));
                cmd.Parameters.AddWithValue("@ID_STATUS", 1);
                int xi = cmd.ExecuteNonQuery();
                if (xi > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
        public ProcessoModel GetProcesso(int ID)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                ProcessoModel processoModel = new ProcessoModel();
                cn.Open();
                SqlCommand sql = new SqlCommand(@"Select * from processos where ID_PROCESSO = @ID", cn);
                sql.Parameters.AddWithValue("@ID", ID);
                SqlDataAdapter sda = new SqlDataAdapter(sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {

                    processoModel.cpf = dt.Rows[0][0].ToString();
                    processoModel.nome = dt.Rows[0][1].ToString();
                    processoModel.endereco = dt.Rows[0][2].ToString();
                    processoModel.bairro = dt.Rows[0][3].ToString();
                    processoModel.cep = dt.Rows[0][4].ToString();
                    processoModel.sexo = dt.Rows[0][5].ToString();
                    processoModel.email = dt.Rows[0][6].ToString();
                    processoModel.celular = dt.Rows[0][7].ToString();
                    processoModel.Data_nascimento = Convert.ToDateTime(dt.Rows[0][8]);
                    processoModel.ID_Processo = Convert.ToInt32(dt.Rows[0][9].ToString());
                    processoModel.ID_status = Convert.ToInt32(dt.Rows[0][10].ToString());
                    processoModel.ID_Cidade = Convert.ToInt32(dt.Rows[0][11].ToString());


                }
                return processoModel;

            }
        }
        public bool EditarProcesso(ProcessoModel processo)
        {

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                SqlCommand cmd = new SqlCommand(@"UPDATE processos SET
                CPF = @CPF ,NOME =@NOME,ENDERECO = @ENDERECO ,BAIRRO = @BAIRRO,CEP = @CEP,
                SEXO = @SEXO ,EMAIL =  @EMAIL,CELULAR = @CELULAR,DATA_NASCIMENTO =  @DATA_NASCIMENTO,
                ID_STATUS =@ID_STATUS,ID_CIDADE = @ID_CIDADE where ID_PROCESSO = @id", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@CPF", processo.cpf.ToString());
                cmd.Parameters.AddWithValue("@NOME", processo.nome.ToString());
                cmd.Parameters.AddWithValue("@ENDERECO", processo.endereco.ToString());
                cmd.Parameters.AddWithValue("@BAIRRO", processo.bairro.ToString());
                cmd.Parameters.AddWithValue("@CEP", processo.cep.ToString());
                cmd.Parameters.AddWithValue("@SEXO", processo.sexo.ToString());
                cmd.Parameters.AddWithValue("@email", processo.email.ToString());
                cmd.Parameters.AddWithValue("@CELULAR", Convert.ToInt64(processo.celular));
                cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", Convert.ToDateTime(processo.Data_nascimento));
                cmd.Parameters.AddWithValue("@ID_CIDADE", Convert.ToInt32(processo.ID_Cidade));
                cmd.Parameters.AddWithValue("@ID_STATUS",1);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(processo.ID_Processo));
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public bool ExcluirProcesso(int id)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                SqlCommand sql = new SqlCommand(@"DELETE processos where ID_PROCESSO = @id", cn);
                cn.Open();
                sql.Parameters.AddWithValue("@id", id);
                int a = sql.ExecuteNonQuery();

                if (a > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public List<PaisModel> GetPais()
        {

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                List<PaisModel> paises = new List<PaisModel>();
                SqlCommand sql = new SqlCommand(@"Select * from pais", cn);
                sql.CommandType = CommandType.Text;
                cn.Open();
                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    var pais = new PaisModel();
                    pais.ID_Pais = Convert.ToInt32(reader["ID_PAIS"]);
                    pais.nome = reader["NOME"].ToString();
                    paises.Add(pais);
                }
                return paises;
            }
        }
        public List<EstadoModel> GetEstado(int id)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                List<EstadoModel> estados = new List<EstadoModel>();
                SqlCommand sql = new SqlCommand(@"Select * from estado where ID_PAIS = @id", cn);
                sql.Parameters.AddWithValue("@id", id);
                sql.CommandType = CommandType.Text;
                cn.Open();

                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    var estado = new EstadoModel();
                    estado.ID_PAIS = Convert.ToInt32(reader["ID_PAIS"]);
                    estado.ID_ESTADO = Convert.ToInt32(reader["ID_ESTADO"]);
                    estado.NOME = reader["NOME"].ToString();
                    estados.Add(estado);
                }
                return estados;
            }

        }

        public List<CidadeModel> GetCidade(int ID_ESTADO)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                List<CidadeModel> cidades = new List<CidadeModel>();
                SqlCommand sql = new SqlCommand(@"Select * from cidade where ID_ESTADO = @id", cn);
                sql.Parameters.AddWithValue("@id", ID_ESTADO);
                sql.CommandType = CommandType.Text;
                cn.Open();

                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    var cidade = new CidadeModel();
                    cidade.ID_CIDADE = Convert.ToInt32(reader["ID_Cidade"]);
                    cidade.ID_ESTADO = Convert.ToInt32(reader["ID_ESTADO"]);
                    cidade.Nome = reader["NOME"].ToString();
                    cidades.Add(cidade);
                }
                return cidades;
            }
            
        }
        public int GetIdEstado(int id)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                ProcessoModel model = new ProcessoModel();
                cn.Open();
              
                SqlCommand sql = new SqlCommand(@"Select * from estado ES
                INNER JOIN cidade CI ON CI.ID_ESTADO = ES.ID_ESTADO
                WHERE CI.ID_CIDADE = @id", cn);

                sql.Parameters.AddWithValue("@id",id);
                sql.CommandType = CommandType.Text;
                var ID_ESTADO = 0;

                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    ID_ESTADO = Convert.ToInt32(reader["ID_ESTADO"]);
                }
                cn.Close();
                return ID_ESTADO;
            }
           
        }
        public int GetIDPais(int id)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                ProcessoModel model = new ProcessoModel();
                cn.Open();

                SqlCommand sql = new SqlCommand(@"Select * from estado ES
                INNER JOIN cidade CI ON CI.ID_ESTADO = ES.ID_ESTADO
                WHERE CI.ID_CIDADE = @id", cn);

                sql.Parameters.AddWithValue("@id", id);
                sql.CommandType = CommandType.Text;
                var ID_PAIS = 0;

                SqlDataReader reader = sql.ExecuteReader();
                while (reader.Read())
                {
                    ID_PAIS = Convert.ToInt32(reader["ID_PAIS"]);
                }
                cn.Close();
                return ID_PAIS;
            }
            
            }
        public string GetNomeCidade(int id_cidade)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                cn.Open();
                SqlCommand command = new SqlCommand(@"SELECT C.NOME FROM processos P
                  INNER JOIN cidade C ON  C.ID_CIDADE = P.ID_CIDADE
                WHERE C.ID_CIDADE = @id",cn);



                command.Parameters.AddWithValue("@id", id_cidade);
                command.CommandType = CommandType.Text;
                string nome = null;



                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nome = reader["NOME"].ToString();
                }
                cn.Close();
                return nome;
            }

            
        }
        public int  VereficaNacionalidade(ProcessoModel model)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                cn.Open();
                SqlCommand command = new SqlCommand(@"SELECT ID_EStado FROM cidade C
                  INNER JOIN estado E ON  C.ID_ESTADO = E.ID_ESTADO
                WHERE C.ID_CIDADE = @id",cn);

                command.Parameters.AddWithValue("@id", model.ID_Cidade);
                command.CommandType = CommandType.Text;
                int id = 0;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = (int)reader["ID_ESTADO"];
                }
                cn.Close(); 

                return id;
            }


        }
        public bool EncaminhaGerente(int id)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                SqlCommand command = new SqlCommand(@"update processos set ID_STATUS = @Status
                where ID_PROCESSO = @id",cn);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@Status", 2);
                cn.Open();
                int cont = command.ExecuteNonQuery();
                cn.Close();



                if (cont > 0)
                    return true;
                else
                    return false;
            }
        }

        public bool StatusAprovado(ProcessoModel model)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                SqlCommand cmd = new SqlCommand(@"UPDATE processos SET
                ID_STATUS =@ID_STATUS where ID_PROCESSO = @id", cn);
                cn.Open();
                cmd.Parameters.AddWithValue("@ID_STATUS", 1);
                int a = cmd.ExecuteNonQuery();

                if (a > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public string DescricaoStatus(int id_status)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM status where
                ID_Status = @id", cn);
               
                cmd.Parameters.AddWithValue("@id", id_status);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                string descriçao = null;


                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    descriçao = reader["status_atual"].ToString();
                }
                cn.Close();
                return descriçao;

              
            }
        }   


    }
}