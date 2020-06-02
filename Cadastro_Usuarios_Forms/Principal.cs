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
    public partial class frm_principal : Form
    {
        int indexRow;
        int ID;
        string StringDeConexao = @"Data Source=BRPC003848;Initial Catalog=UBS 1;Integrated Security=True";
        private ProcessoDao processoDao = new ProcessoDao();

        private void atualizar()
        {

            SqlDataAdapter sda = new SqlDataAdapter(processoDao.GetProcesso());
            DataTable data = new DataTable();
            sda.Fill(data);
            tabela_precesso.DataSource = data;

        }

        public frm_principal()
        {
            InitializeComponent();

        }
   
        private void frm_principal_Load(object sender, EventArgs e)
        {
            SqlDataAdapter db = new SqlDataAdapter("SELECT * FROM processos", "server=BRPC003848;Initial Catalog=UBS 1;Integrated Security=True");
            DataSet ds = new DataSet();
            db.Fill(ds, "processos");
            tabela_precesso.DataSource = ds.Tables["processos"].DefaultView;
            
        }
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_processo form1 = new frm_cadastro_processo();
            form1.ShowDialog();
        }

        private void alteraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_processo form2 = new frm_cadastro_processo();
            form2.ShowDialog();
        }

        private void btn_id_deletar_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;

                if (txt_deletar.Text != "")
                {
                    try
                    {


                        SqlCommand cmd = new SqlCommand(@"DELETE processos where ID_PROCESSO =@ID", cn);

                        cmd.Parameters.AddWithValue("@ID", txt_deletar.Text);
                        cn.Open();
                        int x = cmd.ExecuteNonQuery();
                        if (x > 0)
                        {
                            MessageBox.Show("  PROCESSO Excluido com sucesso...");
                            atualizar();
                            cn.Close();
                        }
                        else
                        {
                            MessageBox.Show("erro ! falha ao deletar o proceso");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro  falha ao deletar o proceso: " + erro);
                    }
                    finally
                    {
                        cn.Close();
                    }

                }

            }
        
    }
    }
}
