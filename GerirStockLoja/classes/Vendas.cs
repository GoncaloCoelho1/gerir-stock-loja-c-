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
    internal class Vendas
    {
        private string QueryVenda = "INSERT INTO vendas (venda_trabalhador_id, venda_produto_codigo, venda_valor) VALUES (@venda_trabalhador_id, @venda_produto_codigo, @venda_valor)";
        private string PARAMETRO_VENDA_PRODUTO_CODIGO = "@venda_produto_codigo";
        private string PARAMETRO_VENDA_TRABALHADOR_ID = "@venda_trabalhador_id";
        private string PARAMETRO_VENDA_VALOR = "@venda_valor";

        private string QueryAtualizarStock = "UPDATE produtos SET produto_quantidade_stock = produto_quantidade_stock - 1 WHERE produto_codigo = @produto_codigo";
        private string PARAMETRO_PRODUTO_CODIGO = "@produto_codigo";

        // metodo para realizar a venda dos produtos
        public void RealizarVenda(string[] produtos, string trabalhadorId) // realiza a venda dos produtos
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                    conexaoDB.Open(); // Abra a conexão aqui

                    // Verificar se a lista de produtos está vazia
                    if (produtos.Length == 0)
                    {
                        MessageBox.Show("Não foi possível realizar a venda. Adicione as unidades vendidas antes de concluir.");
                        return;
                    }

                    string produtosCodigo = string.Join(", ", produtos); // adiciona "," entre todos os códigos de produtos da lista

                    MySqlCommand executacmdsql = new MySqlCommand(QueryVenda, conexaoDB);

                    // Passar os valores
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_VENDA_PRODUTO_CODIGO, produtosCodigo);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_VENDA_TRABALHADOR_ID, trabalhadorId);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_VENDA_VALOR, Produtos.ValorTotal);

                    executacmdsql.ExecuteNonQuery(); // executa a query

                    MessageBox.Show("Venda realizada com sucesso!");

                    // após venda realizada vamos retirar o stock correspondente aos produtos vendidos
                    AtualizarStockAposVenda(produtos, conexaoDB);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a venda: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo apra atualizar o stock apos vendidos os produtos
        public void AtualizarStockAposVenda(string[] produtos, MySqlConnection conexaoDB) // após realizar a venda atualiza o stock atual dos produtos disponíveis
        {
            try
            {
                foreach (string produtoCodigo in produtos)
                {

                    MySqlCommand executacmdsqlStock = new MySqlCommand(QueryAtualizarStock, conexaoDB);
                    executacmdsqlStock.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produtoCodigo);

                    executacmdsqlStock.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o stock: " + ex.Message);
            }
        }

    }
}
