using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace aplicacao_teste_mysql
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=chat; password=''");
            MySqlCommand comando = new MySqlCommand("SELECT * FROM mensagens", conexao);
            DataTable tabela = new DataTable();
            try
            {
                conexao.Open();
                gdvDados.DataSource = comando.ExecuteReader();
                gdvDados.DataBind();
            }
            finally
            {
                conexao.Close();
            }
        }
        protected void logar(object sender, EventArgs e)
        {
            MySqlConnection conexao = new MySqlConnection("server=localhost;User Id=root;database=chat; password=''");

            string login = this.tb_login.Text;
            string senha = this.tb_senha.Text;

            string query = "SELECT * FROM usuarios WHERE login='" + login + "' AND senha='" + senha + "'";
            MySqlCommand comando = new MySqlCommand(query, conexao);

            {
                conexao.Open();

                if (comando.ExecuteReader().HasRows)
                {
                    //Usuario logado com sucesso"coloque a qui o codigo para quando for logado
                }
                else
                {
                    //Usuario ou senha errada"
                }


                conexao.Close();

            }
        }
    }
}