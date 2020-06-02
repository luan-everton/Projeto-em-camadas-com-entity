using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace Cadastro_Usuarios_Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        
        public bool Frm_Login_Load(string login, string senha)
        { 
            bool result = false;
            string StringDeConexao = @"Data Source=BRPC003848;Initial Catalog=UBS 1;Integrated Security=True";
         

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = StringDeConexao;

                try
                {
                    SqlCommand cmd = new SqlCommand("select * from usuarios inner join usuario_perfil on usuario_perfil.ID_USUARIO = usuarios.ID_Usuario where ID_PERFIL = 3 and login = @login AND senha = @senha", cn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    cn.Open();
                    SqlDataReader dados = cmd.ExecuteReader();

                    result = dados.HasRows;
                }
                catch (SqlException e)
                {
                    MessageBox.Show(this, "" + e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    cn.Close();
                }
            }
            return result;
           
        }

        public bool Logado = false;

        private void btn_entrar_Click_1(object sender, EventArgs e)
        {
            bool result = Frm_Login_Load(txt_login.Text,txt_senha.Text);

            Logado = result;

            if (result)
            {
                this.Hide();
                new frm_principal().Show();

            }
            else
            {
                MessageBox.Show(this, "Usuário não permido e /ou login e senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
