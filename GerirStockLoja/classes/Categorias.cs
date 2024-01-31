using GerirStockLoja.conexao;
using GerirStockLoja.paginas;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerirStockLoja.classes
{
    internal class Categorias
    {

        public static string CategoriaID { get; set; } //variavel global para receber o valor da categoria id que estiver selecionado na tabela
        public static string CategoriaCodigo { get; set; } //variavel global para receber o valor do codigo da categoria selecionado na tabela

        //combo box onde vai ser adicionado os valores
        public ComboBox CbCategorias { get; set; }

        private string Query_nome_categorias = "SELECT categoria_nome FROM categorias";
        private string DB_CAMPO_CATEGORIA_NOME = "categoria_nome";

        private string Query_categorias_por_fornecedor = "SELECT fornecedor_id FROM fornecedores WHERE fornecedor_nome = @fornecedor_nome";
        private string DB_CAMPO_FORNECEDOR_ID = "fornecedor_id";
        private string PARAMETRO_FORNECEDOR_NOME = "@fornecedor_nome";
        private string PARAMETRO_FORNECEDOR_ID = "@fornecedor_id";

        private string Query_categoria_nome = "SELECT categoria_nome FROM categorias WHERE categoria_fornecedor_id = @fornecedor_id";

        private string Query_nome_categoria_por_codigo = "SELECT categoria_nome FROM categorias WHERE categoria_codigo = @categoria_codigo";
        private string PARAMETRO_CATEGORIA_CODIGO = "@categoria_codigo";

        private string Query_tabela_categorias = "SELECT categoria_nome, categoria_fornecedor_id, categoria_codigo FROM categorias";

        private string Query_fornecedor_id_pelo_nome = "SELECT fornecedor_id FROM fornecedores WHERE fornecedor_nome = @fornecedor_nome";

        private string Query_inserir_categoria = "INSERT INTO categorias (categoria_nome, categoria_fornecedor_id, categoria_codigo) VALUES (@categoria_nome, @categoria_fornecedor_id, @categoria_codigo)";
        private string PARAMETRO_CATEGORIA_NOME = "@categoria_nome";
        private string PARAMETRO_CATEGORIA_FORNECEDOR_ID = "@categoria_fornecedor_id";

        private string Query_verificar_codigo_categoria = "SELECT categoria_codigo FROM categorias WHERE categoria_codigo = @categoria_codigo";

        private string Query_atualizar_categoria = "UPDATE categorias SET categoria_nome = @categoria_nome, categoria_fornecedor_id = @categoria_fornecedor_id WHERE categoria_id = @categoria_id";
        private string PARAMETRO_CATEGORIA_ID = "@categoria_id";

        private string Query_eliminar_categoria = "DELETE FROM categorias WHERE categoria_id = @categoria_id";

        private string Query_categoria_id_pelo_codigo = "SELECT categoria_id FROM categorias WHERE categoria_codigo = @categoria_codigo";
        private string DB_CAMPO_CATEGORIA_ID = "categoria_id";

        // Método para carregar as categorias na combo box
        public void CarregarCategorias()
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();              

                    MySqlCommand executacmdsql = new MySqlCommand(Query_nome_categorias, conexaoDB);

                    conexaoDB.Open();

                    MySqlDataReader dados = executacmdsql.ExecuteReader();

                    while (dados.Read())
                    {
                        // Adicionar itens à ComboBox 
                        CbCategorias.Items.Add(dados[DB_CAMPO_CATEGORIA_NOME].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
            finally
            {
                // fechar a conexão 
                if (conexaoDB != null )
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo que carrega a combo box categorias de acordo com o fornecedor selecionado
        public void CarregarCategoriasPorFornecedor(string fornecedor_nome)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_categorias_por_fornecedor, conexaoDB);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, fornecedor_nome);

                    conexaoDB.Open();

                    MySqlDataReader dados_fornecedor_id = executacmdsql.ExecuteReader();
                  
                    if (dados_fornecedor_id.Read())
                    {
                        // Obter o código da categoria
                        string fornecedor_id = dados_fornecedor_id.GetString(DB_CAMPO_FORNECEDOR_ID);

                        // Fechar o leitor de dados
                        dados_fornecedor_id.Close();

                        MySqlCommand executacmdsql2 = new MySqlCommand(Query_categoria_nome, conexaoDB);
                        executacmdsql2.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_ID, fornecedor_id);

                        // Abrir um novo leitor para a segunda consulta
                        MySqlDataReader dados_categorias = executacmdsql2.ExecuteReader();

                        // Limpar os itens antes de adicionar novos
                        CbCategorias.Items.Clear();

                        // Ciclo para mostrar os dados baseados na categoria selecionada
                        while (dados_categorias.Read())
                        {
                            // Adicionar itens à ComboBox usando o método AdicionarCategoria
                            CbCategorias.Items.Add(dados_categorias[DB_CAMPO_CATEGORIA_NOME].ToString());
                        }

                        // Fechar o leitor de dados
                        dados_categorias.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar as categorias: " + ex.Message);
            }
            finally
            {
                //fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para ir buscar o nome da categoria a partir do codigo
        public string CategoriaCodigoParaNome(string categoria_codigo)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                  
                    MySqlCommand executacmdsql = new MySqlCommand(Query_nome_categoria_por_codigo, conexaoDB);

                    executacmdsql.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, categoria_codigo);

                    conexaoDB.Open();

                    MySqlDataReader dados_categoria_nome = executacmdsql.ExecuteReader();

                    // Verifique se há linhas antes de tentar acessar os dados
                    if (dados_categoria_nome.Read())
                    {
                        // Acesse o valor da coluna "categoria_nome" da linha atual
                        string categoria_nome = dados_categoria_nome[DB_CAMPO_CATEGORIA_NOME].ToString();

                        // Feche o leitor de dados
                        dados_categoria_nome.Close();

                        // Retorne o nome da categoria
                        return categoria_nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
            finally
            {
                // Feche a conexão no bloco finally para garantir que seja fechada, mesmo em caso de exceção
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            // Retorna null ou uma string vazia se não houver resultado
            return null;
        }

        //metodo para carregar a tabela categorias
        public DataTable CarregarTabelaCategorias()
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                    conexaoDB.Open();

                    MySqlCommand executacmdsql_tabela = new MySqlCommand(Query_tabela_categorias, conexaoDB);
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

        //metodo para adicionar categoria na pagina de gestao de categorias
        public void AdicionarCategoria(string nome, string codigo, string fornecedor_nome)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados_fornecedor_nome = null;
            MySqlDataReader dados_verificar_codigo = null;

            try
            {
                if (VerificarTextBoxEComboBox(nome, codigo))
                {
                    ClassConexao conexao = new ClassConexao();

                    if (conexao.TestarConexao())
                    {
                        conexaoDB = conexao.ObterConexao();

                        conexaoDB.Open();

                        // Verificar se o código já existe na base de dados
                        MySqlCommand executacmdsql_verificar_codigo = new MySqlCommand(Query_verificar_codigo_categoria, conexaoDB);
                        executacmdsql_verificar_codigo.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, codigo);
                        dados_verificar_codigo  = executacmdsql_verificar_codigo.ExecuteReader();

                        if (dados_verificar_codigo.Read())
                        {
                            MessageBox.Show("O código já existe. Por favor, insira um código único.");
                            dados_verificar_codigo.Close();
                            return;
                        }

                        dados_verificar_codigo.Close();

                        MySqlCommand executacmdsql_fornecedor_nome = new MySqlCommand(Query_fornecedor_id_pelo_nome, conexaoDB);
                        executacmdsql_fornecedor_nome.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, fornecedor_nome);

                        dados_fornecedor_nome = executacmdsql_fornecedor_nome.ExecuteReader();
                        if (dados_fornecedor_nome.Read())
                        {
                            // Obter o id do fornecedor
                            string fornecedor_id = dados_fornecedor_nome.GetString(DB_CAMPO_FORNECEDOR_ID);

                            dados_fornecedor_nome.Close();

                            MySqlCommand executacmdsql_InserirFornecedor = new MySqlCommand(Query_inserir_categoria, conexaoDB);

                            // Passar os parâmetros
                            executacmdsql_InserirFornecedor.Parameters.AddWithValue(PARAMETRO_CATEGORIA_NOME, nome);
                            executacmdsql_InserirFornecedor.Parameters.AddWithValue(PARAMETRO_CATEGORIA_FORNECEDOR_ID, fornecedor_id);
                            executacmdsql_InserirFornecedor.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, codigo);

                            executacmdsql_InserirFornecedor.ExecuteNonQuery();

                            MessageBox.Show("Categoria adicionada com sucesso!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar Categoria: " + ex.Message);
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

        //metodo para atualizar categoria na pagina de gestao de categorias
        public void AtualizarCategorias(string categoria_id, string nome, string codigo, string fornecedor_nome)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados_fornecedor_nome = null;

            try
            {
                if (VerificarTextBoxEComboBox(nome, codigo))
                {
                    ClassConexao conexao = new ClassConexao();

                    if (conexao.TestarConexao())
                    {
                        conexaoDB = conexao.ObterConexao();

                        conexaoDB.Open();

                        if (codigo != CategoriaCodigo)
                        {
                            MessageBox.Show("Não é possivel atualizar o código do produto.");                           
                            return;
                        }


                        MySqlCommand executacmdsql_fornecedor_nome = new MySqlCommand(Query_fornecedor_id_pelo_nome, conexaoDB);
                        executacmdsql_fornecedor_nome.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, fornecedor_nome);

                        dados_fornecedor_nome = executacmdsql_fornecedor_nome.ExecuteReader();
                        if (dados_fornecedor_nome.Read())
                        {
                            // Obter o id do fornecedor
                            string fornecedor_id = dados_fornecedor_nome.GetString(DB_CAMPO_FORNECEDOR_ID);

                            dados_fornecedor_nome.Close();

                            MySqlCommand executacmdsql_AtualizarCategoria = new MySqlCommand(Query_atualizar_categoria, conexaoDB);

                            // Passar os parâmetros
                            executacmdsql_AtualizarCategoria.Parameters.AddWithValue(PARAMETRO_CATEGORIA_NOME, nome);
                            executacmdsql_AtualizarCategoria.Parameters.AddWithValue(PARAMETRO_CATEGORIA_FORNECEDOR_ID, fornecedor_id);
                            executacmdsql_AtualizarCategoria.Parameters.AddWithValue(PARAMETRO_CATEGORIA_ID, categoria_id);

                            // Executar a query
                            executacmdsql_AtualizarCategoria.ExecuteNonQuery();

                            MessageBox.Show("Categoria atualizada com sucesso!");
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar Categoria: " + ex.Message);
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

        //metodo para eliminar categoria na pagina de gestao de categorias
        public void EliminarCategoria(string id, string nome, string codigo)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                //verificaçoes para nao haver eliminiçoes indesejadas 
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Por favor, selecione uma linha da tabela");
                    return;
                }

                if (VerificarTextBoxEComboBox(nome, codigo))
                {
                    ClassConexao conexao = new ClassConexao();

                    if (conexao.TestarConexao())
                    {
                        conexaoDB = conexao.ObterConexao();

                        conexaoDB.Open();

                        MySqlCommand executacmdsql_EliminarFornecedor = new MySqlCommand(Query_eliminar_categoria, conexaoDB);

                        // Passar os parâmetros
                        executacmdsql_EliminarFornecedor.Parameters.AddWithValue(PARAMETRO_CATEGORIA_ID, CategoriaID); //utiliza a variavel global

                        // Executar a query
                        executacmdsql_EliminarFornecedor.ExecuteNonQuery();

                        MessageBox.Show("Categoria eliminada com sucesso!");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar Categoria: " + ex.Message);
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

        //metodo para ir buscar o id da categoria pelo codigo
        public string CaterogiaIdPeloCodigo(string codigo)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados_categoria_id = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    conexaoDB.Open();

                    MySqlCommand executacmdsql_Categoria_id_pelo_codigo = new MySqlCommand(Query_categoria_id_pelo_codigo, conexaoDB);

                    // Passar os parâmetros
                    executacmdsql_Categoria_id_pelo_codigo.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, codigo);

                    // Executar a query
                    dados_categoria_id = executacmdsql_Categoria_id_pelo_codigo.ExecuteReader();

                    if (dados_categoria_id.Read())
                    {
                        string categoria_id = dados_categoria_id[DB_CAMPO_CATEGORIA_ID].ToString();
                        return categoria_id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o id da categoria: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            // Se algo der errado ou não houver dados, retorna vazio
            return ""; 
        }


        //metodo para verificar se as txt box estao preenchidas
        public bool VerificarTextBoxEComboBox(string nome, string codigo)
        {
            // Verificar se a text box esta preenchida
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Insira o nome da Categoria.");
                return false;
            }

            // Verificar se o código é um número inteiro
            if (!int.TryParse(codigo, out int _))
            {
                MessageBox.Show("O código da Categoria deve ser um número inteiro válido.");
                return false;
            }

            return true;
        }

    }
}
