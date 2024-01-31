using GerirStockLoja.conexao;
using GerirStockLoja.paginas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerirStockLoja.classes
{
    internal class Produtos
    {
        public static string ProdutoID { get; set; }
        public static string Produto_Codigo_selecionado { get; set; }
        public ComboBox CbProdutos { get; set; } //combo box onde vai ser adicionado os valores

        public static List<string> produtos = new List<string>(); // Lista para armazenar códigos dos produtos

        public static double ValorTotal { get; set; } // Variável para armazenar o valor total

        private string Query_categoria_codigo = "SELECT categoria_codigo FROM categorias WHERE categoria_nome = @categoria_nome";
        private string DB_CAMPO_CATEGORIA_CODIGO = "categoria_codigo";
        private string PARAMETRO_CATEGORIA_NOME = "@categoria_nome";

        private string Query_produto_nome = "SELECT produto_nome FROM produtos WHERE produto_categoria_codigo = @categoria_codigo";
        private string DB_CAMPO_PRODUTO_NOME = "produto_nome";
        private string PARAMETRO_CATEGORIA_CODIGO = "@categoria_codigo";

        private string Query_produto_codigo = "SELECT produto_codigo, produto_quantidade_stock FROM produtos WHERE produto_nome = @produto_nome";
        private string DB_CAMPO_PRODUTO_QUANTIDADE_STOCK = "produto_quantidade_stock";
        private string DB_CAMPO_PRODUTO_CODIGO = "produto_codigo";
        private string PARAMETRO_PRODUTO_NOME = "@produto_nome";

        private string Query_valor_produto_venda = "SELECT produto_valor_venda FROM produtos WHERE produto_codigo = @produto_codigo";
        private string DB_CAMPO_PRODUTO_VALOR_VENDA = "produto_valor_venda";
        private string PARAMETRO_PRODUTO_CODIGO = "@produto_codigo";

        private string Query_fornecedor_id = "SELECT fornecedor_id FROM fornecedores WHERE fornecedor_nome = @fornecedor_nome";
        private string DB_CAMPO_FORNECEDOR_ID = "fornecedor_id";
        private string PARAMETRO_FORNECEDOR_NOME = "@fornecedor_nome";

        private string Query_produto_nome_from_categoria_e_fornecedor = "SELECT produto_nome FROM produtos WHERE produto_categoria_codigo = @categoria_codigo AND produto_fornecedor_id = @fornecedor_id";
        private string PARAMETRO_FORNECEDOR_ID = "@fornecedor_id";

        private string Query_valor_produto_compra = "SELECT produto_valor_compra FROM produtos WHERE produto_codigo = @produto_codigo";
        private string DB_CAMPO_PRODUTO_VALOR_COMPRA = "produto_valor_compra";

        private string Query_verificar_codigo = "SELECT produto_codigo FROM produtos WHERE produto_codigo = @produto_codigo";

        private string Query_verificar_nome = "SELECT produto_nome FROM produtos WHERE produto_nome = @produto_nome";

        private string Query_adicionar_produto = "INSERT INTO produtos (produto_nome, produto_categoria_codigo, produto_fornecedor_id, produto_quantidade_stock, produto_valor_compra, produto_valor_venda, produto_codigo)" +
                                "VALUES(@produto_nome, @categoria_codigo, @fornecedor_id, @quantidade_Stock, @valor_compra, @valor_venda, @produto_codigo)";
        private string PARAMETRO_QUANTIDADE_STOCK = "@quantidade_Stock";
        private string PARAMETRO_VALOR_VENDA = "@valor_venda";
        private string PARAMETRO_VALOR_COMPRA = "@valor_compra";

        private string QueryAtualizarProduto = "UPDATE produtos SET produto_nome = @produto_nome, produto_categoria_codigo = @categoria_codigo, produto_fornecedor_id = @fornecedor_id, produto_quantidade_stock = @quantidade_Stock, " +
            "produto_valor_compra = @valor_compra, produto_valor_venda = @valor_venda WHERE produto_codigo = @produto_codigo";

        private string Query_apagar_produto = "DELETE FROM produtos WHERE produto_id = @produto_id";
        private string PARAMETRO_PRODUTO_ID = "@produto_id";

        private string Query_tabela = "SELECT produto_nome, produto_categoria_codigo, produto_fornecedor_id, produto_quantidade_stock, produto_valor_compra, produto_valor_venda, produto_codigo FROM produtos";

        private string Query_produto_codigo_para_id = "SELECT produto_id FROM produtos WHERE produto_codigo = @produto_codigo";
        private string DB_CAMPO_PRODUTO_ID = "produto_id";


        //metodo para selecionar os produtos associados a uma determinada categoria
        public void CarregarProdutosPorCategoria(string categoriaSelecionada)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql_categoria = new MySqlCommand(Query_categoria_codigo, conexaoDB);
                    executacmdsql_categoria.Parameters.AddWithValue(PARAMETRO_CATEGORIA_NOME, categoriaSelecionada);

                    conexaoDB.Open();

                    MySqlDataReader dados_codigo_categoria = executacmdsql_categoria.ExecuteReader();

                    if (dados_codigo_categoria.Read())
                    {
                        // Obter o código da categoria
                        string categoria_codigo = dados_codigo_categoria.GetString(DB_CAMPO_CATEGORIA_CODIGO);

                        // Fechar o leitor de dados
                        dados_codigo_categoria.Close();

                        MySqlCommand executacmdsql_produto = new MySqlCommand(Query_produto_nome, conexaoDB);
                        executacmdsql_produto.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, categoria_codigo);

                        // Abrir um novo leitor para a segunda consulta
                        MySqlDataReader dados_produtos = executacmdsql_produto.ExecuteReader();

                        // Limpar os itens antes de adicionar novos
                        CbProdutos.Items.Clear();

                        // Ciclo para mostrar os dados baseados na categoria selecionada
                        while (dados_produtos.Read())
                        {
                            // Adicionar produtos ao ComboBox usando o método AdicionarProduto
                            CbProdutos.Items.Add(dados_produtos[DB_CAMPO_PRODUTO_NOME].ToString());
                        }

                        // Fechar o leitor de dados
                        dados_produtos.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
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

        //metodo para adicionar produtos a uma lista, para poder haver varios produtos vendidos em apenas uma venda
        public void AdicionarProdutosVendidosNaLista(string quantidadeVendida, string produto_nome) 
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao()) //se a conexao com a bd for bem sucedida
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql_ProdutoInfo = new MySqlCommand(Query_produto_codigo, conexaoDB);
                    executacmdsql_ProdutoInfo.Parameters.AddWithValue(PARAMETRO_PRODUTO_NOME, produto_nome);

                    conexaoDB.Open();

                    MySqlDataReader dados_codigo_produto = executacmdsql_ProdutoInfo.ExecuteReader(); //passa os resultados para uma variavel

                    if (dados_codigo_produto.Read()) //se essa variavel tiver populada
                    {
                        string produto_codigo = dados_codigo_produto.GetString(DB_CAMPO_PRODUTO_CODIGO);
                        int stock_atual = dados_codigo_produto.GetInt32(DB_CAMPO_PRODUTO_QUANTIDADE_STOCK);
                        dados_codigo_produto.Close();

                        if (int.TryParse(quantidadeVendida, out int quantidadeVezes) && quantidadeVezes > 0) //converte o valor para inteiro e depois passa para a variavel quantidadeVezes
                        {
                            // Verificar se há estoque suficiente
                            if (quantidadeVezes > stock_atual)
                            {
                                MessageBox.Show($"O stock atual do produto são {stock_atual} unidades. Não foi possivel adicionar os produtos.");
                                return;
                            }

                            for (int i = 0; i < quantidadeVezes; i++) //fica a adicionar produtos e a adicionar o valor à variavel o numero de vezes que foi passado anteriormente
                            {
                                produtos.Add(produto_codigo); //adiciona na lista

                                MySqlCommand executacmdsqlValor = new MySqlCommand(Query_valor_produto_venda, conexaoDB);
                                executacmdsqlValor.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produto_codigo);

                                MySqlDataReader dados_produto_valor = executacmdsqlValor.ExecuteReader();

                                if (dados_produto_valor.Read())
                                {
                                    double valor = dados_produto_valor.GetDouble(DB_CAMPO_PRODUTO_VALOR_VENDA); //passa o valor do produto para uma variavel
                                    ValorTotal += valor; //incrementa esse valor na variavel global

                                    dados_produto_valor.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insira um valor inteiro maior do que zero no campo Unidades Vendidas");
                            return;
                        }

                    }

                    //condiçao para mostrar a mensagem caso seja 1 ou mais produtos
                    if (int.TryParse(quantidadeVendida, out int quantidade) && quantidade > 1)
                    {
                        MessageBox.Show("Produtos adicionados com sucesso!");
                    }
                    else if (quantidade == 1)
                    {
                        MessageBox.Show("Produto adicionado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para carregar os nomes dos produtos associados a um fornecedor dentro de uma determinada categoria
        public void CarregarProdutos(string categoriaSelecionada, string fornecedor_nome)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados_codigo_categoria = null;
            MySqlDataReader dados_fornecedor_id = null;
            MySqlDataReader dados_produtos = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql_categoria_codigo = new MySqlCommand(Query_categoria_codigo, conexaoDB);
                    executacmdsql_categoria_codigo.Parameters.AddWithValue(PARAMETRO_CATEGORIA_NOME, categoriaSelecionada);

                    MySqlCommand executacmdsql_fornecedor_id = new MySqlCommand(Query_fornecedor_id, conexaoDB);
                    executacmdsql_fornecedor_id.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, fornecedor_nome);

                    conexaoDB.Open();

                    dados_codigo_categoria = executacmdsql_categoria_codigo.ExecuteReader();

                    if (dados_codigo_categoria.Read())
                    {
                        // Obter o código da categoria
                        string categoria_codigo = dados_codigo_categoria.GetString(DB_CAMPO_CATEGORIA_CODIGO);

                        // Fechar o leitor de dados
                        dados_codigo_categoria.Close();

                        dados_fornecedor_id = executacmdsql_fornecedor_id.ExecuteReader();

                        if (dados_fornecedor_id.Read())
                        {
                            // Obter o id do fornecedor
                            string fornecedor_id = dados_fornecedor_id.GetString(DB_CAMPO_FORNECEDOR_ID);

                            // Fechar o leitor de dados
                            dados_fornecedor_id.Close();

                            MySqlCommand executacmdsql2 = new MySqlCommand(Query_produto_nome_from_categoria_e_fornecedor, conexaoDB);
                            executacmdsql2.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, categoria_codigo);
                            executacmdsql2.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_ID, fornecedor_id);

                            dados_produtos = executacmdsql2.ExecuteReader();

                            // Limpar os itens antes de adicionar novos
                            CbProdutos.Items.Clear();

                            // Ciclo para mostrar os dados baseados na categoria selecionada
                            while (dados_produtos.Read())
                            {
                                // Adicionar produtos ao ComboBox usando o método AdicionarProduto
                                CbProdutos.Items.Add(dados_produtos[DB_CAMPO_PRODUTO_NOME].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
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

        //metodo para adicionar produtos comprados numa lista
        public void AdicionarProdutosCompradosNaLista(string quantidadeComprada, string produto_nome) 
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao()) //se a conexao com a bd for bem sucedida
                {
                    conexaoDB = conexao.ObterConexao();


                    MySqlCommand executacmdsql = new MySqlCommand(Query_produto_codigo, conexaoDB);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_PRODUTO_NOME, produto_nome);

                    conexaoDB.Open();

                    MySqlDataReader dados_codigo_produto = executacmdsql.ExecuteReader(); //passa os resultados para uma variavel

                    if (dados_codigo_produto.Read()) //se essa variavel tiver populada
                    {
                        string produto_codigo = dados_codigo_produto.GetString(DB_CAMPO_PRODUTO_CODIGO);
                        dados_codigo_produto.Close();

                        if (int.TryParse(quantidadeComprada, out int quantidadeVezes)) //converte o valor para inteiro e depois passa para a variavel quantidadeVezes
                        {
                            for (int i = 0; i < quantidadeVezes; i++) //fica a adicionar produtos e a adicionar o valor à variavel o numero de vezes que foi passado anteriormente
                            {
                                produtos.Add(produto_codigo); //adiciona na lista

                                MySqlCommand executacmdsqlValor = new MySqlCommand(Query_valor_produto_compra, conexaoDB);
                                executacmdsqlValor.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produto_codigo);

                                MySqlDataReader dados_produto_valor = executacmdsqlValor.ExecuteReader();

                                if (dados_produto_valor.Read())
                                {
                                    double valor = dados_produto_valor.GetDouble(DB_CAMPO_PRODUTO_VALOR_COMPRA); //passa o valor do produto para uma variavel
                                    ValorTotal += valor; //incrementa esse valor na variavel global

                                    dados_produto_valor.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Insira um valor inteiro no campo Unidades a Comprar");
                            return;
                        }

                    }

                    //pequena condiçao para mostrar a mensagem caso seja 1 ou mais produtos
                    if (int.TryParse(quantidadeComprada, out int quantidade) && quantidade > 1)
                    {
                        MessageBox.Show("Produtos adicionados com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Produto adicionado com sucesso!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para adicionar novos produtos
        public void AdicionarNovosProdutos(string nomeCategoria, string nome_novo_produto, string fornecedor_nome, string quantidade_Stock, string valor_compra, string valor_venda, string produto_codigo)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados_codigo_categoria = null;
            MySqlDataReader dados_fornecedor_id = null;
            MySqlDataReader dados_verificar_codigo = null;
            MySqlDataReader dados_verificar_nome = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    if (!VerificarTxtBoxEComboBox(nomeCategoria, nome_novo_produto, fornecedor_nome, valor_compra, valor_venda, produto_codigo))
                    {
                        return;
                    }

                    //definir as queries para usar mais tarde os data readers
                    MySqlCommand executacmdsql_categoria_codigo = new MySqlCommand(Query_categoria_codigo, conexaoDB);
                    executacmdsql_categoria_codigo.Parameters.AddWithValue(PARAMETRO_CATEGORIA_NOME, nomeCategoria);

                    MySqlCommand executacmdsql_fornecedor_id = new MySqlCommand(Query_fornecedor_id, conexaoDB);
                    executacmdsql_fornecedor_id.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, fornecedor_nome);

                    MySqlCommand executacmdsql_verificar_codigo = new MySqlCommand(Query_verificar_codigo, conexaoDB);
                    executacmdsql_verificar_codigo.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produto_codigo);

                    MySqlCommand executacmdsql_verificar_nome = new MySqlCommand(Query_verificar_nome, conexaoDB);
                    executacmdsql_verificar_nome.Parameters.AddWithValue(PARAMETRO_PRODUTO_NOME, nome_novo_produto);

                    conexaoDB.Open();

                    dados_verificar_codigo = executacmdsql_verificar_codigo.ExecuteReader();

                    // Se existir algum produto com o mesmo código
                    if (dados_verificar_codigo.Read())
                    {
                        MessageBox.Show("O código do produto inserido já está associado a algum produto existente.");
                        dados_verificar_codigo.Close();
                        return;
                    }
                    dados_verificar_codigo.Close(); 

                    dados_verificar_nome = executacmdsql_verificar_nome.ExecuteReader();

                    // Se existir algum produto com o mesmo nome
                    if (dados_verificar_nome.Read())
                    {
                        MessageBox.Show("O nome do produto inserido já está associado a algum produto existente.");
                        dados_verificar_nome.Close();
                        return;
                    }
                    dados_verificar_nome.Close();

                    //se passar na verificaçao do nome e do codigo entao faz a insereçao na bd
                    dados_codigo_categoria = executacmdsql_categoria_codigo.ExecuteReader();

                    if (dados_codigo_categoria.Read())
                    {
                        // Obter o código da categoria
                        string categoria_codigo = dados_codigo_categoria.GetString(DB_CAMPO_CATEGORIA_CODIGO);

                        // Fechar o leitor de dados
                        dados_codigo_categoria.Close();

                        dados_fornecedor_id = executacmdsql_fornecedor_id.ExecuteReader();

                        if (dados_fornecedor_id.Read())
                        {
                            // Obter o id do fornecedor
                            string fornecedor_id = dados_fornecedor_id.GetString(DB_CAMPO_FORNECEDOR_ID);

                            // Fechar o leitor de dados
                            dados_fornecedor_id.Close();

                            MySqlCommand executacmdsql_inserir_produto = new MySqlCommand(Query_adicionar_produto, conexaoDB);

                            // Passar os parâmetros
                            executacmdsql_inserir_produto.Parameters.AddWithValue(PARAMETRO_PRODUTO_NOME, nome_novo_produto);
                            executacmdsql_inserir_produto.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, categoria_codigo);
                            executacmdsql_inserir_produto.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_ID, fornecedor_id);
                            executacmdsql_inserir_produto.Parameters.AddWithValue(PARAMETRO_QUANTIDADE_STOCK, quantidade_Stock);
                            executacmdsql_inserir_produto.Parameters.AddWithValue(PARAMETRO_VALOR_COMPRA, valor_compra);
                            executacmdsql_inserir_produto.Parameters.AddWithValue(PARAMETRO_VALOR_VENDA, valor_venda);
                            executacmdsql_inserir_produto.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produto_codigo);

                            executacmdsql_inserir_produto.ExecuteNonQuery();

                            MessageBox.Show("Produto adicionado com sucesso!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
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

        //metodo para atualizar um produto pelo codigo do produto(este nao pode ser alterado, se for alterado da erro)
        public void AtualizarProduto(string produto_codigo_tabela, string novoNome, string novaCategoria, string novoFornecedor, string novaQuantidade, string novoValorCompra, string novoValorVenda, string produto_codigo)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados_codigo_categoria = null;
            MySqlDataReader dados_fornecedor_id = null;


            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    if(!VerificarTxtBoxEComboBox(novaCategoria, novoFornecedor, novoNome, novoValorCompra, novoValorVenda, produto_codigo))
                    {
                        return;
                    }

                    MySqlCommand executacmdsql_categoria_codigo = new MySqlCommand(Query_categoria_codigo, conexaoDB);
                    executacmdsql_categoria_codigo.Parameters.AddWithValue(PARAMETRO_CATEGORIA_NOME, novaCategoria);

                    MySqlCommand executacmdsql_fornecedor_id = new MySqlCommand(Query_fornecedor_id, conexaoDB);
                    executacmdsql_fornecedor_id.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_NOME, novoFornecedor);

                    MySqlCommand executacmdsql_verificar_produto_existente = new MySqlCommand(Query_verificar_codigo, conexaoDB);
                    executacmdsql_verificar_produto_existente.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produto_codigo);

                    conexaoDB.Open();

                    //condicao para mostrar o erro em que o codigo do produto nao pode ser atualizado
                    if (produto_codigo_tabela == produto_codigo)
                    {

                        dados_codigo_categoria = executacmdsql_categoria_codigo.ExecuteReader();

                        if (dados_codigo_categoria.Read())
                        {
                            // Obter o código da categoria
                            string categoria_codigo = dados_codigo_categoria.GetString(DB_CAMPO_CATEGORIA_CODIGO);

                            // Fechar o leitor de dados
                            dados_codigo_categoria.Close();

                            dados_fornecedor_id = executacmdsql_fornecedor_id.ExecuteReader();

                            if (dados_fornecedor_id.Read())
                            {
                                // Obter o id do fornecedor
                                string fornecedor_id = dados_fornecedor_id.GetString(DB_CAMPO_FORNECEDOR_ID);

                                // Fechar o leitor de dados
                                dados_fornecedor_id.Close();


                                MySqlCommand executacmdsqlAtualizarProduto = new MySqlCommand(QueryAtualizarProduto, conexaoDB);

                                executacmdsqlAtualizarProduto.Parameters.AddWithValue(PARAMETRO_PRODUTO_NOME, novoNome);
                                executacmdsqlAtualizarProduto.Parameters.AddWithValue(PARAMETRO_CATEGORIA_CODIGO, categoria_codigo);
                                executacmdsqlAtualizarProduto.Parameters.AddWithValue(PARAMETRO_FORNECEDOR_ID, fornecedor_id);
                                executacmdsqlAtualizarProduto.Parameters.AddWithValue(PARAMETRO_QUANTIDADE_STOCK, novaQuantidade);
                                executacmdsqlAtualizarProduto.Parameters.AddWithValue(PARAMETRO_VALOR_COMPRA, novoValorCompra);
                                executacmdsqlAtualizarProduto.Parameters.AddWithValue(PARAMETRO_VALOR_VENDA, novoValorVenda);
                                executacmdsqlAtualizarProduto.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produto_codigo);

                                executacmdsqlAtualizarProduto.ExecuteNonQuery();

                                MessageBox.Show("Produto atualizado com sucesso!");
                            }
                            
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("Codigo do produto nao pode ser atualizado.");                       
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o produto: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para apagar o produto
        public void ApagarProduto(string produto_id, string produto_codigo)
        {

            MySqlConnection conexaoDB = null;

            try
            {
                if (string.IsNullOrEmpty(produto_id))
                {
                    MessageBox.Show("Por favor, selecione uma linha da tabela");
                    return;
                }

                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao()) //se a conexao com a bd for bem sucedida
                {
                    conexaoDB = conexao.ObterConexao();

                    conexaoDB.Open();

                    MySqlCommand executacmdsql_apagar = new MySqlCommand(Query_apagar_produto, conexaoDB);
                    executacmdsql_apagar.Parameters.AddWithValue(PARAMETRO_PRODUTO_ID, produto_id);

                    executacmdsql_apagar.ExecuteNonQuery();

                    MessageBox.Show("Produto apagado com sucesso!");

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar produto: " + ex.Message);
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

        //metodo para ir buscar o id do produto atraves do codigo
        public string ProdutoCodigoParaID(string produto_codigo)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados_produto_id = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    conexaoDB.Open();

                    MySqlCommand executacmdsql_Categoria_id_pelo_codigo = new MySqlCommand(Query_produto_codigo_para_id, conexaoDB);

                    // Passar os parâmetros
                    executacmdsql_Categoria_id_pelo_codigo.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produto_codigo);

                    // Executar a query
                    dados_produto_id = executacmdsql_Categoria_id_pelo_codigo.ExecuteReader();

                    if (dados_produto_id.Read())
                    {
                        string produto_id = dados_produto_id[DB_CAMPO_PRODUTO_ID].ToString();
                        return produto_id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar o id do produto: " + ex.Message);
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

        //metodo para carregar a tabela produtos com os dados
        public DataTable ObterDadosProdutos()
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                    conexaoDB.Open();

                    MySqlCommand executacmdsql_tabela = new MySqlCommand(Query_tabela, conexaoDB);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(executacmdsql_tabela);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
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

        //metodo para fazer as verificaçoes as txt box e combo box
        public bool VerificarTxtBoxEComboBox(string nome_categoria, string fornecedor_nome, string nome_produto, string valor_compra, string valor_venda, string produto_codigo)
        {
            // Verificar se a categoria está selecionada
            if (string.IsNullOrWhiteSpace(nome_categoria))
            {
                MessageBox.Show("Selecione uma categoria antes de adicionar o produto.");
                return false;
            }

            // Verificar se o fornecedor está selecionado
            if (string.IsNullOrWhiteSpace(fornecedor_nome))
            {
                MessageBox.Show("Selecione um fornecedor antes de adicionar o produto.");
                return false;
            }

            // Validar o nome do produto (deve ser uma string não vazia)
            if (string.IsNullOrWhiteSpace(nome_produto))
            {
                MessageBox.Show("Por favor, insira um nome de produto válido.");
                return false;
            }

            // Validar o valor de compra (deve ser um valor double válido)
            if (!double.TryParse(valor_compra, out _))
            {
                MessageBox.Show("Por favor, insira um valor de compra válido.");
                return false;
            }

            // Validar o valor de venda (deve ser um valor double válido)
            if (!double.TryParse(valor_venda, out _))
            {
                MessageBox.Show("Por favor, insira um valor de venda válido.");
                return false;
            }

            // Validar o código do produto (deve ser um número inteiro válido)
            if (!int.TryParse(produto_codigo, out _))
            {
                MessageBox.Show("Por favor, insira um código de produto válido.");
                return false;
            }
            return true;
        }
    }
}
