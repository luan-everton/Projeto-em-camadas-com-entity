using Cadastro.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Usuarios_Forms
{
    public partial class frm_cadastro_processo : Form
    {
        int indexRow;
        int ID;
        string StringDeConexao = @"Data Source=BRPC003848;Initial Catalog=UBS 1;Integrated Security=True";

        private ProcessoDao processoDao = new ProcessoDao();
        SqlDataAdapter sqlDataAdapter;

        public SqlCommand SqlCommand { get; private set; }

        private void atualizar()
        {

            SqlDataAdapter sda = new SqlDataAdapter(processoDao.GetProcesso());
                DataTable data = new DataTable();
                sda.Fill(data);
               tabela_cliente.DataSource = data;
            UsuarioDao usuarioDao = new UsuarioDao();
          
          
        }

        public frm_cadastro_processo()
        {
            InitializeComponent();
        }

        private void frm_cadastro_processo_Load(object sender, EventArgs e)
        {
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM processos", "server=BRPC003848;Initial Catalog=UBS 1;Integrated Security=True");
            DataSet ds = new DataSet();
            db.Fill(ds, "processos");

            UsuarioDao usuarioDao = new UsuarioDao();
            var usuario = usuarioDao.GetUsuarios();
            tabela_cliente.DataSource = ds.Tables["processos"].DefaultView;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
           
            string StringDeConexao = @"Data Source=BRPC003848;Initial Catalog=UBS 1;Integrated Security=True";
           

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                if (msk_cpf.Text != "" && txt_nome.Text != "" && txt_endereco.Text != "" && txt_bairro.Text != "" && msk_cep.Text != "" && txt_idade.Text != "" && cbx_sexo.Text != "" && txt_email.Text != "" && msk_celular.Text != "" && msk_nascimento.Text != ""  && cbx_cidade.Text != "")
                {
                    try
                    {
                        msk_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        msk_cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        msk_celular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                        SqlCommand cmd = new SqlCommand("INSERT INTO processos(CPF,NOME,ENDERECO,BAIRRO,CEP,IDADE,SEXO,EMAIL,CELULAR,DATA_NASCIMENTO,ID_STATUS,ID_CIDADE) VALUES(@CPF,@NOME,@ENDERECO,@BAIRRO,@CEP,@IDADE,@SEXO,@EMAIL,@CELULAR,@DATA_NASCIMENTO,@ID_STATUS,@ID_CIDADE)", cn);
                        cn.Open();
                        cmd.Parameters.AddWithValue("@CPF", msk_cpf.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@NOME", txt_nome.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@ENDERECO", txt_endereco.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@BAIRRO", txt_bairro.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@CEP", msk_cep.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@IDADE", txt_idade.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@SEXO", cbx_sexo.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@email", txt_email.Text.ToLower());
                        cmd.Parameters.AddWithValue("@CELULAR", msk_celular.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@DATA_NASCIMENTO",msk_nascimento.Text);
                        cmd.Parameters.AddWithValue("@ID_CIDADE", cbx_cidade.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@ID_STATUS", 1);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cadastro realizado com sucesso...");
                        atualizar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                    }
                    finally
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Informe todos os dados requeridos");
                }
            }

        }



        private void tabela_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = tabela_cliente.Rows[indexRow];
            ID = Convert.ToInt32(row.Cells[10].Value.ToString());
            msk_cpf.Text = row.Cells[0].Value.ToString();
            txt_nome.Text = row.Cells[1].Value.ToString();
            txt_endereco.Text = row.Cells[2].Value.ToString();
            txt_bairro.Text = row.Cells[3].Value.ToString();
            msk_cep.Text = row.Cells[4].Value.ToString();
            txt_idade.Text = row.Cells[5].Value.ToString();
            cbx_sexo.Text = row.Cells[6].Value.ToString();
            txt_email.Text = row.Cells[7].Value.ToString();
            msk_celular.Text = row.Cells[8].Value.ToString();
            msk_nascimento.Text = row.Cells[9].Value.ToString();
            cbx_cidade.Text = row.Cells[12].Value.ToString();

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            string StringDeConexao = @"Data Source=BRPC003848;Initial Catalog=UBS 1;Integrated Security=True";

           
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                if (txt_nome.Text != "" && msk_cpf.Text != "")
                {
                    msk_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    msk_cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    msk_celular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    SqlCommand cmd = new SqlCommand(@"update processos set CPF = @CPF,NOME=@NOME,ENDERECO=@ENDERECO,
                        BAIRRO=@BAIRRO,CEP=@CEP,IDADE=@IDADE,SEXO=@SEXO,EMAIL=@EMAIL,CELULAR=@CELULAR,
                        DATA_NASCIMENTO=@DATA_NASCIMENTO,ID_STATUS=@ID_STATUS,ID_CIDADE=@ID_CIDADE where ID_PROCESSO=@id", cn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@ID_STATUS",3);
                    cmd.Parameters.AddWithValue("@CPF", msk_cpf.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@NOME", txt_nome.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@ENDERECO", txt_endereco.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@BAIRRO", txt_bairro.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@CEP", msk_cep.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@IDADE", txt_idade.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@SEXO", cbx_sexo.Text);
                    cmd.Parameters.AddWithValue("@email", txt_email.Text.ToLower());
                    cmd.Parameters.AddWithValue("@CELULAR", msk_celular.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@DATA_NASCIMENTO", msk_nascimento.Text);
                    cmd.Parameters.AddWithValue("@ID_CIDADE", cbx_cidade.SelectedValue.ToString());
                    cn.Open();
                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        MessageBox.Show("Atualização concluida");
                        atualizar();
                        cn.Close();
                    }
                    else 
                    {
                        MessageBox.Show("atualizão não concluida");
                    }

                }
                else
                {
                    MessageBox.Show("seleciona um projeto para fazer a atualização");
                }
            }
        }

       

        private void btm_novo_Click(object sender, EventArgs e)
        {
            frm_cadastro_processo novo = new frm_cadastro_processo();
            msk_cpf.Text = "";
            txt_nome.Text = "";
            txt_endereco.Text="";
            txt_bairro.Text = "";
            msk_cep.Text = "";
            txt_idade.Text = "";
            cbx_sexo.Text = "";
            txt_email.Text = "";
            msk_celular.Text = "";
            cbx_cidade.Text = "";
            msk_nascimento.Text = "";
        }
        private void cbx_pais_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                try
                {
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM PAIS", cn);
                    cn.Open();
                    sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable data = new DataTable();
                    sqlDataAdapter.Fill(data);
                    cbx_pais.ValueMember = "ID_PAIS";
                    cbx_pais.DisplayMember = "NOME";
                    cbx_pais.DataSource = data;
                    cbx_estado.Enabled = false;
                    cbx_cidade.Enabled = false;
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro : " + exc);
                }
                finally
                {
                    cn.Close();
                }
            }

        }
        private void cbx_pais_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                try
                {
                    if (cbx_pais.SelectedValue != null)
                    {
                        SqlCommand cmd = new SqlCommand(@"SELECT * FROM ESTADO WHERE ID_PAIS = @ID_PAIS", cn);
                        cmd.Parameters.AddWithValue("@ID_PAIS", cbx_pais.SelectedValue.ToString());
                        sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataTable data = new DataTable();
                        sqlDataAdapter.Fill(data);
                        cbx_estado.ValueMember = ("ID_ESTADO");
                        cbx_estado.DisplayMember = ("NOME");
                        cbx_estado.DataSource = data;
                        cbx_estado.Enabled = true;
                        cbx_cidade.Enabled = false;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro : " + exc);
                }
                finally
                {
                    cn.Close();
                }
            }

        }

        private void cbx_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;
                try
                {
                    if (cbx_estado.SelectedValue != null)
                    {
                        SqlCommand cmd = new SqlCommand(@"SELECT * FROM CIDADE WHERE ID_ESTADO = @ID_ESTADO", cn);
                        cmd.Parameters.AddWithValue("@ID_ESTADO", cbx_estado.SelectedValue.ToString());
                        sqlDataAdapter = new SqlDataAdapter(cmd);
                        DataTable data = new DataTable();
                        sqlDataAdapter.Fill(data);
                        cbx_cidade.ValueMember = ("ID_CIDADE");
                        cbx_cidade.DisplayMember = ("NOME");
                        cbx_cidade.DataSource = data;
                        cbx_cidade.Enabled = true;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Erro : " + exc);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

       
    }
}
      









