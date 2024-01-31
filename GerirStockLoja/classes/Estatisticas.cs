using GerirStockLoja.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace GerirStockLoja.classes
{
    internal class Estatisticas
    {
        private string Query_comparacao_trabalhadores = "SELECT trabalhador_nome, COUNT(*) AS NumeroVendas FROM vendas " +
                        "INNER JOIN trabalhadores ON vendas.venda_trabalhador_id = trabalhadores.trabalhador_id GROUP BY trabalhador_nome";

        private string DB_CAMPO_TRABALHADOR_NOME = "trabalhador_nome";

        private string Query_maior_venda = "SELECT trabalhador_nome, MAX(venda_valor) AS MaiorVenda FROM vendas " +
                                               "INNER JOIN trabalhadores ON vendas.venda_trabalhador_id = trabalhadores.trabalhador_id " +
                                               "GROUP BY trabalhador_nome";

        private string Query_total_vendas = "SELECT COUNT(*) AS TotalVendas FROM vendas WHERE venda_trabalhador_id = @trabalhador_id";
        private string PARAMETRO_TRABALHADOR_ID = "@trabalhador_id";

        private string Query_maior_venda_lbl = "SELECT MAX(venda_valor) AS MaiorVenda FROM vendas WHERE venda_trabalhador_id = @trabalhador_id";

        private string Query_Valor_Total = "SELECT SUM(venda_valor) AS ValorTotal FROM vendas WHERE venda_trabalhador_id = @trabalhador_id";

        //metodo generico para preencher graficos
        private void PreencherGrafico(Chart chart, string query, string nomeSerie, string nomeEixoX, string nomeEixoY)
        {
            MySqlConnection conexaoDB = null;
            MySqlDataReader dados = null;
            MySqlDataAdapter adapter = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(query, conexaoDB);

                    conexaoDB.Open();

                    dados = executacmdsql.ExecuteReader();

                    // Verifica se há linhas antes de continuar
                    if (dados.HasRows)
                    {
                        DataTable dataTable = new DataTable();

                        // Preenche o DataTable com os resultados do MySqlDataReader
                        dataTable.Load(dados);

                        // Fecha o MySqlDataReader
                        dados.Close();

                        // Abre novamente o MySqlDataReader para a execução da consulta original
                        dados = executacmdsql.ExecuteReader();

                        // Limpar pontos antigos antes de adicionar novos pontos
                        chart.Series[nomeSerie].Points.Clear();

                        // Adicionar novos pontos
                        foreach (DataRow row in dataTable.Rows)
                        {
                            string valorEixoX = row[nomeEixoX].ToString();
                            int valorEixoY = Convert.ToInt32(row[nomeEixoY]);

                            // Adicionar ponto ao gráfico
                            chart.Series[nomeSerie].Points.AddXY(valorEixoX, valorEixoY);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar estatísticas: " + ex.Message);
            }
            finally
            {
                // Certifica-se de fechar o MySqlDataReader
                if (dados != null && !dados.IsClosed)
                {
                    dados.Close();
                }

                // Certifica-se de limpar o adapter 
                if (adapter != null)
                {
                    adapter.Dispose();
                }

                // fechar a conexão 
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para preencher os graficos
        public void PreencherChartTrabalhador(Chart chart)
        {
            chart.Palette = ChartColorPalette.Pastel;            
            PreencherGrafico(chart, Query_comparacao_trabalhadores, "VendasPorFuncionario", DB_CAMPO_TRABALHADOR_NOME, "NumeroVendas");
        }

        //metodo para preencher os graficos
        public void PreencherChartMaiorVenda(Chart chart)
        {          
            PreencherGrafico(chart, Query_maior_venda, "MaiorVendaPorFuncionario", DB_CAMPO_TRABALHADOR_NOME, "MaiorVenda");
        }


        //metodo para carregar a label com informaçao relativa ao trabalhador
        public void MostrarTotalVendas(Label lblTotalVendas)
        {
            string trabalhador_id = LoginManager.Id;
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();


                    MySqlCommand executacmdsql = new MySqlCommand(Query_total_vendas, conexaoDB);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_ID, trabalhador_id);

                    conexaoDB.Open();

                    using (MySqlDataReader dados_total_vendas = executacmdsql.ExecuteReader())
                    {
                        if (dados_total_vendas.Read())
                        {
                            int totalVendas = dados_total_vendas.GetInt32("TotalVendas");

                            // Atualize a label com o total de vendas
                            lblTotalVendas.Text = $"Total de Vendas: {totalVendas}";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar o total de vendas: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para carregar a label com informaçao relativa ao trabalhador
        public void MostrarMaiorVenda(Label lblMaiorVenda)
        {
            string trabalhador_id = LoginManager.Id;
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_maior_venda_lbl, conexaoDB);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_ID, trabalhador_id);

                    conexaoDB.Open();

                    using (MySqlDataReader dados_maior_venda = executacmdsql.ExecuteReader())
                    {
                        if (dados_maior_venda.Read())
                        {
                            if (!dados_maior_venda.IsDBNull(dados_maior_venda.GetOrdinal("MaiorVenda")))
                            {
                                double maiorVenda = dados_maior_venda.GetDouble("MaiorVenda");

                                // Atualize a label com o valor da maior venda
                                lblMaiorVenda.Text = $"Maior Venda: {maiorVenda:N2}€";  // N2 significa dois dígitos decimais
                            }
                            else
                            {
                                // Não houve vendas registradas para o trabalhador logado
                                lblMaiorVenda.Text = "Nenhuma venda registada";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar a maior venda: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

        }

        //metodo para carregar a label com informaçao relativa ao trabalhador
        public void MostrarValorTotalVendas(Label lblValorTotalVendas)
        {
            string trabalhador_id = LoginManager.Id;
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_Valor_Total, conexaoDB);
                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_ID, trabalhador_id);

                    conexaoDB.Open();

                    object resultado = executacmdsql.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        double valorTotalVendas = Convert.ToDouble(resultado);
                        lblValorTotalVendas.Text = $"Valor Total em Vendas: {valorTotalVendas:N2}€";
                    }
                    else
                    {
                        lblValorTotalVendas.Text = "Nenhuma venda registada.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao calcular o valor total das vendas: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

    }
}
