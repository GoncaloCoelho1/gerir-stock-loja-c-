using GerirStockLoja.classes;
using GerirStockLoja.conexao;
using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GerirStockLoja.paginas
{
    public partial class UC_vender : UserControl
    {

        public UC_vender()
        {
            InitializeComponent();

            //popular a combo box categorias
            Categorias categorias = new Categorias();      
            categorias.CbCategorias = cbCategorias;  
            categorias.CarregarCategorias(); // Chamar o método para carregar as categorias na combo box

        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            //popular a combo box produtos
            Produtos produtos = new Produtos();
            produtos.CbProdutos = cbProdutos;         
            string categoria_selecionada = cbCategorias.SelectedItem.ToString(); //passar o valor selecionado para a variavel
            produtos.CarregarProdutosPorCategoria(categoria_selecionada); // Chamar o método para carregar os produtos na combo box
            
        }

        private void BtnAdicionarProduto_Click(object sender, EventArgs e)
        {

            // Verificar se a ComboBox da categoria está selecionada
            if (cbCategorias.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria antes de adicionar o produto.");
                return;
            }

            // Verificar se a ComboBox da categoria está selecionada
            if (cbProdutos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um Produto.");
                return;
            }

            string produto_nome = cbProdutos.SelectedItem.ToString();

            //chamar o metodo criado na classe produtos
            Produtos produtos = new Produtos();
            string unidades_vendidas = TxtboxUniVendidas.Text;
            produtos.AdicionarProdutosVendidosNaLista(unidades_vendidas, produto_nome);
            
        }

        private void BtnVenda_Click(object sender, EventArgs e)
        {

            Vendas vendas = new Vendas();               
            vendas.RealizarVenda(Produtos.produtos.ToArray(), LoginManager.Id);

            Produtos.ValorTotal = 0; //coloca a variavel global de valor para 0 para nao somar às proximas vendas
            Produtos.produtos.Clear(); //limpa a lista de produtos para nao adicionar os produtos anteriomente vendidos a uma proxima venda


        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            cbCategorias.Items.Clear();
            cbProdutos.Items.Clear();
            TxtboxUniVendidas.Text = string.Empty;

            //depois de limpar é necessario popular as combo box novamente
            //popular a combo box categorias
            Categorias categorias = new Categorias();
            categorias.CbCategorias = cbCategorias;
            categorias.CarregarCategorias(); // Chamar o método para carregar as categorias na combo box
        }

        
    }
}
