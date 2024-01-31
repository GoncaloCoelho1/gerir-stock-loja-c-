using GerirStockLoja.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerirStockLoja.classes
{
    internal class Fornecedores
    {
        public static string FornecedorID { get; set; } //variavel global para receber o valor do fornecedor id que estiver selecionado na tabela
        public ComboBox CbFornecedores { get; set; }

        private string Query_fornecedores = "SELECT fornecedor_nome FROM fornecedores";
        private string DB_CAMPO_FORNECEDOR_NOME = "fornecedor_nome";

        private string Query_fornecedor_nome = "SELECT fornecedor_nome FROM fornecedores WHERE fornecedor_id = @fornecedor_id";
        private string PARAMETRO_FORNECEDOR_ID = "@fornecedor_id";

        private string Query_tabela_fornecedor = "SELECT * FROM fornecedores";

        private string Query_inserir_fornecedor = "INSERT INTO fornecedores (fornecedor_nome, fornecedor_morada) VALUES(@fornecedor_nome, @fornecedor_morada)";
        private string PARAMETRO_FORNECEDOR_NOME = "@fornecedor_nome";
        private string PARAMETRO_FORNECEDOR_MORADA = "@fornecedor_morada";

        private string Query_atualizar_fornecedor = "UPDATE fornecedores SET fornecedor_nome = @fornecedor_nome, fornecedor_morada = @fornecedor_morada WHERE fornecedor_id = @fornecedor_id";

        private string Query_eliminar_fornecedor = "DELETE FROM fornecedores WHERE fornecedor_id = @fornecedor_id";


        // Método para carregar os fornecedores na combo box
        public void CarregarFornecedores()
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_fornecedores, conexaoDB);

                    conexaoDB.Open();

                    MySqlDataReader dados = executacmdsql.ExecuteReader();

                    while (dados.Read())
                    {
                        CbFornecedores.Items.Add(dados[DB_CAMPO_FORNECEDOR_NOME].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
            finally
            {
                //fechar a conexão 
                if (conexaoDB != null )
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para ir buscar o nome do fornecedor a partir do id
        public string FornecedorIdParaNome(string fornecedor_id)
        {

            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_fornecedor_nome, conexaoDB);

                    executacmdsql.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_ID, fornecedor_id);

                    conexaoDB.Open();

                    MySqlDataReader dados_fornecedor_nome = executacmdsql.ExecuteReader();

                    // Verificar se existe resultados da query efetuada
                    if (dados_fornecedor_nome.Read())
                    {
                        string fornecedor_nome = dados_fornecedor_nome[DB_CAMPO_FORNECEDOR_NOME].ToString();

                        // Feche o leitor de dados
                        dados_fornecedor_nome.Close();

                        // Retorne o nome da categoria
                        return fornecedor_nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão 
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            // Retorna null ou uma string vazia se não houver resultado
            return null;
        }

        //metodo data table para carregar as informaçoes dos fornecedores na tabela
        public DataTable CarregarTabelaFornecedores()
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                    conexaoDB.Open();

                    MySqlCommand executacmdsql_tabela = new MySqlCommand(Query_tabela_fornecedor, conexaoDB);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(executacmdsql_tabela);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados da tabela: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            return null;
        }

        //metodo para adicionar novos fornecedores
        public void AdicionarFornecedor(string nome, string morada)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                if (VerificarTextBox(nome, morada))
                {

                    ClassConexao conexao = new ClassConexao();

                    if (conexao.TestarConexao())
                    {
                        conexaoDB = conexao.ObterConexao();

                        conexaoDB.Open();

                        MySqlCommand executacmdsql_InserirFornecedor = new MySqlCommand(Query_inserir_fornecedor, conexaoDB);

                        // Passar os parâmetros
                        executacmdsql_InserirFornecedor.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, nome);
                        executacmdsql_InserirFornecedor.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_MORADA, morada);

                        // Executar a query
                        executacmdsql_InserirFornecedor.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor adicionado com sucesso!");
                    }
                }  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar Fornecedor: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para atualizar fornecedores existentes
        public void AtualizarFornecedor(string fornecedor_id, string nome, string morada)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                if(VerificarTextBox(nome, morada))
                {
                    ClassConexao conexao = new ClassConexao();

                    if (conexao.TestarConexao())
                    {
                        conexaoDB = conexao.ObterConexao();

                        conexaoDB.Open();

                        MySqlCommand executacmdsql_AtualizarFornecedor = new MySqlCommand(Query_atualizar_fornecedor, conexaoDB);

                        // Passar os parâmetros
                        executacmdsql_AtualizarFornecedor.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_ID, fornecedor_id);
                        executacmdsql_AtualizarFornecedor.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, nome);
                        executacmdsql_AtualizarFornecedor.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_MORADA, morada);

                        // Executar a query
                        executacmdsql_AtualizarFornecedor.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor atualizado com sucesso!");
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Fornecedor: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para eliminar fornecedores a partir do id da linha que esta selecionada na tabela
        public void EliminarFornecedor(string fornecedor_id, string nome, string morada)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                if (string.IsNullOrEmpty(fornecedor_id))
                {
                    MessageBox.Show("Por favor, selecione uma linha da tabela");
                    return;
                }

                if (VerificarTextBox(nome, morada))
                {
                    ClassConexao conexao = new ClassConexao();

                    if (conexao.TestarConexao())
                    {
                        conexaoDB = conexao.ObterConexao();

                        conexaoDB.Open();

                        MySqlCommand executacmdsql_AtualizarFornecedor = new MySqlCommand(Query_eliminar_fornecedor, conexaoDB);

                        // Passar os parâmetros
                        executacmdsql_AtualizarFornecedor.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_ID, fornecedor_id);

                        // Executar a query
                        executacmdsql_AtualizarFornecedor.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor eliminado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar Fornecedor: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para verificar se as txt box têm a informaçao correta
        public bool VerificarTextBox(string nome, string morada)
        {
            // Verificar se a categoria está selecionada
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Insira o nome do fornecedor.");
                return false;
            }

            // Verificar se o fornecedor está selecionado
            if (string.IsNullOrWhiteSpace(morada))
            {
                MessageBox.Show("Insira a morada do fornecedor.");
                return false;
            }
            return true;
        }
    }
}
