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
    }
}