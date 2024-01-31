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
    public partial class UC_fornecedores : UserControl
    {
        public UC_fornecedores()
        {
            InitializeComponent();
            Fornecedores fornecedores = new Fornecedores();
            dgvFornecedores.DataSource = fornecedores.CarregarTabelaFornecedores();

        }

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow linhaSelecionada = dgvFornecedores.Rows[e.RowIndex];

            //passa os valores da linha selecionada para as text box
            txtNomeFornecedor.Text = linhaSelecionada.Cells["fornecedor_nome"].Value.ToString();
            txtMoradaFornecedor.Text = linhaSelecionada.Cells["fornecedor_morada"].Value.ToString();


            string fornecedor_id = linhaSelecionada.Cells["fornecedor_id"].Value.ToString();
            
            Fornecedores.FornecedorID = fornecedor_id; //passsa para a variavel global o valor do id da linha selecionada

        }

        private void BtnAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            //recebe os valores das text box
            string fornecedor_nome = txtNomeFornecedor.Text;
            string fornecedor_morada = txtMoradaFornecedor.Text;

            //chama o metodo para adicionar os fornecedores
            Fornecedores fornecedores = new Fornecedores();
            fornecedores.AdicionarFornecedor(fornecedor_nome, fornecedor_morada);

            //carregar a tabela com os dados atuaizados
            dgvFornecedores.DataSource = fornecedores.CarregarTabelaFornecedores();
        }

        private void btnAtualizarFornecedor_Click(object sender, EventArgs e)
        {
            //recebe os valores das text box
            string fornecedor_nome = txtNomeFornecedor.Text;
            string fornecedor_morada = txtMoradaFornecedor.Text;

            Fornecedores fornecedores = new Fornecedores();
            fornecedores.AtualizarFornecedor(Fornecedores.FornecedorID, fornecedor_nome, fornecedor_morada);


            //carregar a tabela com os dados atuaizados
            dgvFornecedores.DataSource = fornecedores.CarregarTabelaFornecedores();
        }

        private void btnApagarFornecedor_Click(object sender, EventArgs e)
        {
            //recebe os valores das text box
            string fornecedor_nome = txtNomeFornecedor.Text;
            string fornecedor_morada = txtMoradaFornecedor.Text;

            Fornecedores fornecedores = new Fornecedores();
            fornecedores.EliminarFornecedor(Fornecedores.FornecedorID, fornecedor_nome, fornecedor_morada);

            //carregar a tabela com os dados atuaizados
            dgvFornecedores.DataSource = fornecedores.CarregarTabelaFornecedores();

        }

        private void btnLimparCampos_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            txtNomeFornecedor.Text = string.Empty;
            txtMoradaFornecedor.Text = string.Empty;
            Fornecedores.FornecedorID = string.Empty;
        }
    }
}
