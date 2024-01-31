using GerirStockLoja.classes;
using GerirStockLoja.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GerirStockLoja.paginas
{
    public partial class UC_estatisticas : UserControl
    {
        public UC_estatisticas()
        {
            InitializeComponent();

            //carrega os metodos para a pagina
            Estatisticas estatisticas = new Estatisticas();
            estatisticas.PreencherChartTrabalhador(chartTrabalhadores);
            estatisticas.PreencherChartMaiorVenda(chartMaiorVenda);
            estatisticas.MostrarTotalVendas(lblTotalVendas);
            estatisticas.MostrarMaiorVenda(lblMaiorVenda);
            estatisticas.MostrarValorTotalVendas(lblValorTotalVendas);

        }
    }
}
