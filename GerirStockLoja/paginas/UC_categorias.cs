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
    public partial class UC_categorias : UserControl
    {
        public UC_categorias()
        {
            InitializeComponent();

            //chamar o metodo para carregar a tabela com informaçao
            Categorias categorias = new Categorias();
            dgvCategorias.DataSource = categorias.CarregarTabelaCategorias();

            Fornecedores fornecedores = new Fornecedores();
            fornecedores.CbFornecedores = cbFornecedores;
            fornecedores.CarregarFornecedores();

        }


        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow linhaSelecionada = dgvCategorias.Rows[e.RowIndex];

            //passa os valores da linha selecionada para as text box
            txtNomeCategoria.Text = linhaSelecionada.Cells["categoria_nome"].Value.ToString();
            txtCodigoCategoria.Text = linhaSelecionada.Cells["categoria_codigo"].Value.ToString();

           

            string categoria_codigo = linhaSelecionada.Cells["categoria_codigo"].Value.ToString();
            
            Categorias.CategoriaCodigo = categoria_codigo;//passsa para a variavel global o valor do codigo da categoria da linha selecionada
            Categorias categorias = new Categorias();

            string categoria_id = categorias.CaterogiaIdPeloCodigo(Categorias.CategoriaCodigo);
            Categorias.CategoriaID = categoria_id; //passsa para a variavel global o valor do id da categoria da linha selecionada

            string categoria_fornecedor_id = linhaSelecionada.Cells["categoria_fornecedor_id"].Value.ToString();
            Fornecedores fornecedores = new Fornecedores();
            string fornecedor_nome = fornecedores.FornecedorIdParaNome(categoria_fornecedor_id);
            cbFornecedores.SelectedItem = fornecedor_nome;

        }

        private void BtnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            
            // Se todas as validações passarem, continuar com o processo de adição do produto
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            //recebe os valores das text box
            string categoria_nome = txtNomeCategoria.Text;
            string categoria_codigo = txtCodigoCategoria.Text;
            string fornecedor_nome = cbFornecedores.SelectedItem.ToString();

            //chama o metodo para adicionar a categoria
            Categorias categorias = new Categorias();
            categorias.AdicionarCategoria(categoria_nome, categoria_codigo, fornecedor_nome);

            //carregar a tabela com os dados atuaizados
            dgvCategorias.DataSource = categorias.CarregarTabelaCategorias();
        }

        private void btnAtualizarCategoria_Click(object sender, EventArgs e)
        {
            // Se todas as validações passarem, continuar com o processo de adição do produto
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            //recebe os valores das text box
            string categoria_nome = txtNomeCategoria.Text;
            string categoria_codigo = txtCodigoCategoria.Text;
            string fornecedor_nome = cbFornecedores.SelectedItem.ToString();

            //chama o metodo para adicionar a categoria
            Categorias categorias = new Categorias();
            categorias.AtualizarCategorias(Categorias.CategoriaID, categoria_nome, categoria_codigo, fornecedor_nome);

            //carregar a tabela com os dados atuaizados
            dgvCategorias.DataSource = categorias.CarregarTabelaCategorias();
        }

        private void btnApagarCategoria_Click(object sender, EventArgs e)
        {
            // Se todas as validações passarem, continuar com o processo de adição do produto
            if (!VerificarConteudoComboBox())
            {
                return;
            }
            //recebe os valores das text box
            string categoria_nome = txtNomeCategoria.Text;
            string categoria_codigo = txtCodigoCategoria.Text;

            Categorias categorias = new Categorias();
            categorias.EliminarCategoria(Categorias.CategoriaID, categoria_nome, categoria_codigo);

            //carregar a tabela com os dados atuaizados
            dgvCategorias.DataSource = categorias.CarregarTabelaCategorias();
        }

        public bool VerificarConteudoComboBox()
        {

            // Verificar se a ComboBox dos fornecedores está selecionada
            if (cbFornecedores.SelectedItem == null)
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
        
        private void LimparCampos()
        {
            cbFornecedores.Items.Clear();
            txtNomeCategoria.Text = string.Empty;
            txtCodigoCategoria.Text = string.Empty;
            Categorias.CategoriaID = string.Empty;

            Fornecedores fornecedores = new Fornecedores();
            fornecedores.CbFornecedores = cbFornecedores;
            fornecedores.CarregarFornecedores();
        }
    }
}
