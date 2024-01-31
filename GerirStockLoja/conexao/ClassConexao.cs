using MySql.Data.MySqlClient;
using System;

namespace GerirStockLoja.conexao
{
    internal class ClassConexao
    {
        private MySqlConnection conexao;
        private string strConexao;

        public ClassConexao()
        {
            //definir conexao
            strConexao = "server=127.0.0.1;uid=root;database=loja";
            conexao = new MySqlConnection(strConexao);
        }

        public bool TestarConexao()
        {
            try
            {
                conexao.Open();
                conexao.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public MySqlConnection ObterConexao()
        {
            return conexao;
        }
    }
}

