using GerirStockLoja.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerirStockLoja.paginas
{
    public partial class UC_comprar : UserControl
    {
        public UC_comprar()
        {
            InitializeComponent();

            //popular a combo box fornecedores
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.CbFornecedores = cbFornecedores;
            fornecedores.CarregarFornecedores(); // Chamar o método para carregar os fornecedores na combo box

        }

        private void cbFornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {

            Categorias categorias = new Categorias();
            categorias.CbCategorias = cbCategorias_fornecedor;
            string fornecedor_selecionado = cbFornecedores.SelectedItem.ToString(); //passar o valor selecionado para a variavel
            categorias.CarregarCategoriasPorFornecedor(fornecedor_selecionado); // Chamar o método para carregar as categorias na combo box

        }

        private void cbCategorias_fornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fornecedor_selecionado = cbFornecedores.SelectedItem.ToString(); //passar o valor selecionado para a variavel

            Produtos produtos = new Produtos();
            produtos.CbProdutos = cbProdutos;
            string categoria_selecionada = cbCategorias_fornecedor.SelectedItem.ToString(); //passar o valor selecionado para a variavel
            produtos.CarregarProdutos(categoria_selecionada, fornecedor_selecionado); // Chamar o método para carregar os produtos na combo box
            
        }

        private void BtnAdicionarProduto_Click(object sender, EventArgs e)
        {
            // Verificar se a ComboBox dos fornecedores está selecionada
            if (cbFornecedores.SelectedItem == null)
            {
                MessageBox.Show("Selecione um fornecedor antes de adicionar o produto.");
                return;
            }

            // Verificar se a ComboBox da categoria está selecionada
            if (cbCategorias_fornecedor.SelectedItem == null)
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

            Produtos produtos = new Produtos();
            produtos.CbProdutos = cbProdutos;

            string produto_selecionado = cbProdutos.SelectedItem.ToString(); //passar o valor selecionado para a variavel
            string quantidade_comprada = TxtboxUniCompradas.Text;
            produtos.AdicionarProdutosCompradosNaLista(quantidade_comprada, produto_selecionado); // Chamar o método para carregar os produtos na combo box

        }

        private void BtnCompra_Click(object sender, EventArgs e)
        {

            Compras compras = new Compras();
            compras.RealizarCompra(Produtos.produtos.ToArray(), LoginManager.Id);

            Produtos.ValorTotal = 0; //coloca a variavel global de valor para 0 para nao somar às proximas vendas
            Produtos.produtos.Clear(); //limpa a lista de produtos para nao adicionar os produtos anteriomente vendidos a uma proxima venda

        }

       
        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            cbFornecedores.Items.Clear();
            cbCategorias_fornecedor.Items.Clear();
            cbProdutos.Items.Clear();
            TxtboxUniCompradas.Text = string.Empty;

            //Como limpei os items da combobox, tenho que os adicionar novamente
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.CbFornecedores = cbFornecedores;
            fornecedores.CarregarFornecedores();
        }

    }
}
