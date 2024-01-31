using GerirStockLoja.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerirStockLoja.classes
{
    internal class NiveisAcesso
    {
        //combo box onde vai ser adicionado os valores
        public ComboBox CbNiveis { get; set; }

        private string Query_niveis = "SELECT nivel_nome FROM niveis_acesso";
        private string DB_CAMPO_NIVEL_NOME = "nivel_nome";

        string Query_nivel_nome = "SELECT nivel_nome FROM niveis_acesso WHERE nivel_id = @trabalhador_nivel";
        private string PARAMETRO_TRABALHADOR_NIVEL = "@trabalhador_nivel";

        string Query_nivel_id = "SELECT nivel_id FROM niveis_acesso WHERE nivel_nome = @trabalhador_nome";
        private string DB_CAMPO_NIVEL_ID = "nivel_id";
        private string PARAMETRO_TRABALHADOR_NOME = "@trabalhador_nome";

        //metodo para carregar a combo box niveis
        public void CarregarNiveis()
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_niveis, conexaoDB);

                    conexaoDB.Open();

                    MySqlDataReader dados = executacmdsql.ExecuteReader();

                    while (dados.Read())
                    {
                        // Adicionar itens à ComboBox 
                        CbNiveis.Items.Add(dados[DB_CAMPO_NIVEL_NOME].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar niveis: " + ex.Message);
            }
            finally
            {
                // fechar a conexão 
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para converter o id do funcionario para o nome
        public string FuncionarioNivelIdParaNome(string trabalhador_nivel)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_nivel_nome, conexaoDB);

                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_NIVEL, trabalhador_nivel);

                    conexaoDB.Open();

                    MySqlDataReader dados_nivel_nome = executacmdsql.ExecuteReader();

                    //se tiver lido os dados passa o nome do trabalhador para uma variavel
                    if (dados_nivel_nome.Read())
                    {
                        string nivel_nome = dados_nivel_nome[DB_CAMPO_NIVEL_NOME].ToString();

                        // Fechar o leitor de dados
                        dados_nivel_nome.Close();

                        // Retorna a string do nome do trabalhador
                        return nivel_nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionarios: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            // Retorna null ou uma string vazia se nao houver resultado
            return null;
        }

        //metodo para converter o nome do funcionario para o id
        public string FuncionarioNomeParaNivelID(string trabalhador_nome)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_nivel_id, conexaoDB);

                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_NOME, trabalhador_nome);

                    conexaoDB.Open();

                    MySqlDataReader dados_nivel_id = executacmdsql.ExecuteReader();

                    //se tiver lido os dados passa o nome do trabalhador para uma variavel
                    if (dados_nivel_id.Read())
                    {
                        string nivel_id = dados_nivel_id[DB_CAMPO_NIVEL_ID].ToString();

                        // Fechar o leitor de dados
                        dados_nivel_id.Close();

                        // Retorna a string do nome do trabalhador
                        return nivel_id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionarios: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            // Retorna null ou uma string vazia se nao houver resultado
            return null;
        }
    }
}
