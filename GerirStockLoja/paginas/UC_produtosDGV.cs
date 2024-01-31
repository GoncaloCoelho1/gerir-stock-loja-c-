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
    public partial class UC_produtosDGV : UserControl
    {
        public UC_produtosDGV()
        {
            InitializeComponent();

            Produtos produtos = new Produtos();
            // Carregar dados no DataGridView
            dgvProdutos.DataSource = produtos.ObterDadosProdutos();

            // Popular a combo box categorias na parte de atualizar produtos
            Categorias categoriasAtualizar = new Categorias();
            categoriasAtualizar.CbCategorias = cbCategoria;
            categoriasAtualizar.CarregarCategorias();


            // Popular a combo box fornecedores
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.CbFornecedores = cbFornecedor;
            fornecedores.CarregarFornecedores();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow linhaSelecionada = dgvProdutos.Rows[e.RowIndex];

            //passa os valores da linha selecionada para as text box
            txtNomeProduto.Text = linhaSelecionada.Cells["produto_nome"].Value.ToString();
            txtQuantidadeStock.Text = linhaSelecionada.Cells["produto_quantidade_stock"].Value.ToString();
            txtValorCompra.Text = linhaSelecionada.Cells["produto_valor_compra"].Value.ToString();
            txtValorVenda.Text = linhaSelecionada.Cells["produto_valor_venda"].Value.ToString();
            txtCodigoProduto.Text = linhaSelecionada.Cells["produto_codigo"].Value.ToString();

            //vai buscar o nome da categoria pelo codigo da categoria selecionada
            string categoriaCodigo = linhaSelecionada.Cells["produto_categoria_codigo"].Value.ToString(); 
            Categorias categorias = new Categorias();
            string categoria_nome = categorias.CategoriaCodigoParaNome(categoriaCodigo);

            // Seleciona o nome da categoria na combo box categoria
            cbCategoria.SelectedItem = categoria_nome;

            //vai buscar o nome do fornecedor pelo id do fornecedor selecionado
            string fornecedorId = linhaSelecionada.Cells["produto_fornecedor_id"].Value.ToString();
            Fornecedores fornecedores = new Fornecedores();
            string fornecedor_nome = fornecedores.FornecedorIdParaNome(fornecedorId);
                
            cbFornecedor.SelectedItem = fornecedor_nome;

            //passar o codigo do produto selecionado para a variavel global
            string produto_codigo_selecionado = linhaSelecionada.Cells["produto_codigo"].Value.ToString();
            Produtos.Produto_Codigo_selecionado = produto_codigo_selecionado;

            Produtos produtos = new Produtos();
            string produto_id = produtos.ProdutoCodigoParaID(Produtos.Produto_Codigo_selecionado);
            Produtos.ProdutoID = produto_id;

        }

        private void BtnAdicionarProduto_Click(object sender, EventArgs e)
        {

            // Se todas as validações passarem, continuar com o processo de adição do produto
            string codigo_produto = txtCodigoProduto.Text;
            string valor_compra = txtValorCompra.Text;
            string valor_venda = txtValorVenda.Text;
            string nome_produto = txtNomeProduto.Text;
            string quantidade_stock = txtQuantidadeStock.Text;

            // Se todas as validações passarem, continuar com o processo de adição do produto
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            string categoria_nome = cbCategoria.SelectedItem.ToString();
            string fornecedor_nome = cbFornecedor.SelectedItem.ToString();

            Produtos produtos = new Produtos();
            produtos.AdicionarNovosProdutos(categoria_nome, nome_produto, fornecedor_nome, quantidade_stock, valor_compra, valor_venda, codigo_produto);

            //carregar a tabela com os dados atuaizados
            dgvProdutos.DataSource = produtos.ObterDadosProdutos();
        }


        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {

            // Se todas as validações passarem, continuar com o processo de adição do produto
            string valor_compra = txtValorCompra.Text;
            string valor_venda = txtValorVenda.Text;
            string nome_produto = txtNomeProduto.Text;
            string quantidade_stock = txtQuantidadeStock.Text;
            string codigo_produto = txtCodigoProduto.Text;

            // Se todas as validações passarem, continuar com o processo de adição do produto
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            string categoria_nome = cbCategoria.SelectedItem.ToString();
            string fornecedor_nome = cbFornecedor.SelectedItem.ToString();

            Produtos produtos = new Produtos();
            produtos.AtualizarProduto(Produtos.Produto_Codigo_selecionado, nome_produto, categoria_nome, fornecedor_nome, quantidade_stock, valor_compra, valor_venda, codigo_produto);

            //carregar a tabela com os dados atuaizados
            dgvProdutos.DataSource = produtos.ObterDadosProdutos();

        }

        private void btnApagarProduto_Click(object sender, EventArgs e)
        {
            string codigo_produto = txtCodigoProduto.Text;

            // Se todas as validações passarem, continuar com o processo de adição do produto
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            //variavel global produto id para depois receber o codigo da linha que esta selecionada e tranformar para id e depois usar o codigo id para eliminar o produto
            Produtos produtos = new Produtos();
            produtos.ApagarProduto(Produtos.ProdutoID, codigo_produto);

            //carregar a tabela com os dados atuaizados
            dgvProdutos.DataSource = produtos.ObterDadosProdutos();
        }



        public bool VerificarConteudoComboBox()
        {
            // Verificar se a ComboBox da categoria está selecionada
            if (cbCategoria.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma categoria antes de adicionar o produto.");
                return false;
            }

            // Verificar se a ComboBox dos fornecedores está selecionada
            if (cbFornecedor.SelectedItem == null)
            {
                MessageBox.Show("Selecione um fornecedor antes de adicionar o produto.");
                return false;
            }

            return true; // Se as ComboBoxes têm itens selecionados, retorna true
        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            cbCategoria.Items.Clear();
            cbFornecedor.Items.Clear();
            txtNomeProduto.Text = string.Empty;
            txtCodigoProduto.Text = string.Empty;
            txtValorCompra.Text = string.Empty;
            txtValorVenda.Text = string.Empty;
            txtQuantidadeStock.Text = string.Empty;
            Produtos.ProdutoID = string.Empty;

            //depois de limpar é necessario popular as combo box novamente
            // Popular a combo box categorias na parte de atualizar produtos
            Categorias categoriasAtualizar = new Categorias();
            categoriasAtualizar.CbCategorias = cbCategoria;
            categoriasAtualizar.CarregarCategorias();


            // Popular a combo box fornecedores
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.CbFornecedores = cbFornecedor;
            fornecedores.CarregarFornecedores();

        }
    }
}
