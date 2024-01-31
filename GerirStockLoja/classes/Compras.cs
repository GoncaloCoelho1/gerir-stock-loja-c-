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
    internal class Compras
    {
        private string QueryCompra = "INSERT INTO compras (compra_trabalhador_id, compra_produto_codigo, compra_valor) VALUES (@trabalhador_id, @produto_codigo, @valor)";
        private string PARAMETRO_PRODUTO_CODIGO = "@produto_codigo";
        private string PARAMETRO_TRABALHADOR_ID = "@trabalhador_id";
        private string PARAMETRO_VALOR = "@valor";

        private string QueryAtualizarStock = "UPDATE produtos SET produto_quantidade_stock = produto_quantidade_stock + 1 WHERE produto_codigo = @produto_codigo";


        //metodo para realizar compras
        public void RealizarCompra(string[] produtos, string trabalhadorId) 
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                    conexaoDB.Open(); 

                    if (produtos.Length == 0)
                    {
                        MessageBox.Show("Não foi possível realizar a compra. Adicione as unidades compradas antes de concluir.");
                        return;
                    }

                    string produtosCodigo = string.Join(", ", produtos); // adiciona "," entre todos os códigos de produtos da lista

                    MySqlCommand executacmdsql = new MySqlCommand(QueryCompra, conexaoDB);

                    // Passar os valores
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_PRODUTO_CODIGO, produtosCodigo);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_ID, trabalhadorId);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_VALOR, Produtos.ValorTotal);

                    executacmdsql.ExecuteNonQuery(); // executa a query

                    MessageBox.Show("Compra realizada com sucesso!");

                    // após compra realizada vamos adicionar o stock correspondente aos produtos comprados
                    AtualizarStockAposCompra(produtos, conexaoDB);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar compra: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        // após realizar a compra atualiza o stock atual dos produtos disponíveis, recebendo a quantidade que foi comprada de um determinado produto e adicionando ao stock existente
        public void AtualizarStockAposCompra(string[] produtos, MySqlConnection conexaoDB) 
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
