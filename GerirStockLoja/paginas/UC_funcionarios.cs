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
using BCrypt.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace GerirStockLoja.paginas
{
    public partial class UC_funcionarios : UserControl
    {
        public UC_funcionarios()
        {
            InitializeComponent();

            Funcionarios funcionarios = new Funcionarios();
            // Carregar dados no DataGridView
            dgvFuncionarios.DataSource = funcionarios.ObterTabelaFuncionarios();

            //carregar a combo box com os niveis
            NiveisAcesso niveis = new NiveisAcesso();
            niveis.CbNiveis = cbNivel;
            niveis.CarregarNiveis();
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
            {
                return; 
            }

            DataGridViewRow linhaSelecionada = dgvFuncionarios.Rows[e.RowIndex];
     
            //passa os valores da linha selecionada para as text box
            txtNomeFuncionario.Text = linhaSelecionada.Cells["trabalhador_nome"].Value.ToString();
            txtEmailFuncionario.Text = linhaSelecionada.Cells["trabalhador_email"].Value.ToString();
            txtSenhaFuncionario.Text = linhaSelecionada.Cells["trabalhador_senha"].Value.ToString();

            string email = linhaSelecionada.Cells["trabalhador_email"].Value.ToString();
            Funcionarios funcionarios = new Funcionarios();
            string idDoFuncionario = funcionarios.FuncionarioIdPeloEmail(email);
            Funcionarios.FuncionarioId = idDoFuncionario;

            string trabalhador_nivel = linhaSelecionada.Cells["trabalhador_nivel"].Value.ToString();
            string funcionario_nome = funcionarios.FuncionarioNivelIdParaNome(trabalhador_nivel);

            //seleciona o nome do funcionario da linha selecionada na tabela dentro da combo box
            cbNivel.SelectedItem = funcionario_nome;
        }

        private void BtnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            //verificar se as combo box estao preenchidas
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            string funcionario_nome = cbNivel.SelectedItem.ToString();

            //converte do nome da combo box para id
            NiveisAcesso niveis = new NiveisAcesso();           
            string nivel_id = niveis.FuncionarioNomeParaNivelID(funcionario_nome);

            //recebe os valores das text box
            string nome = txtNomeFuncionario.Text;
            string email = txtEmailFuncionario.Text;
            string senha = txtSenhaFuncionario.Text;

            //chama o metodo para adicionar os funcionarios
            Funcionarios funcionarios = new Funcionarios();
            funcionarios.AdicionarFuncionario(nome, email, senha, nivel_id);

            //carregar a tabela com os dados atuaizados
            dgvFuncionarios.DataSource = funcionarios.ObterTabelaFuncionarios();
        }

       
        private void btnAtualizarFuncionario_Click(object sender, EventArgs e)
        {
            //verificar se as combo box estao preenchidas
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            string funcionario_nome = cbNivel.SelectedItem.ToString();

            //converte do nome da combo box para id
            NiveisAcesso niveis = new NiveisAcesso();
            string nivel_id = niveis.FuncionarioNomeParaNivelID(funcionario_nome);

            //recebe os valores das text box
            string nome = txtNomeFuncionario.Text;
            string email = txtEmailFuncionario.Text;
            string senha = txtSenhaFuncionario.Text;

            Funcionarios funcionarios = new Funcionarios();
            funcionarios.AtualizarFuncionario(Funcionarios.FuncionarioId, nome, email, senha, nivel_id);

            //carregar a tabela com os dados atuaizados
            dgvFuncionarios.DataSource = funcionarios.ObterTabelaFuncionarios();
        }


        private void btnApagarFuncionario_Click(object sender, EventArgs e)
        {
            //verificar se as combo box estao preenchidas
            if (!VerificarConteudoComboBox())
            {
                return;
            }

            string nome = txtNomeFuncionario.Text;
            string senha = txtSenhaFuncionario.Text;
            string email = txtEmailFuncionario.Text;

            Funcionarios funcionarios = new Funcionarios();
            funcionarios.EliminarFuncionario(Funcionarios.FuncionarioId, nome, senha, email);

            //carregar a tabela com os dados atuaizados
            dgvFuncionarios.DataSource = funcionarios.ObterTabelaFuncionarios();
        }



        public bool VerificarConteudoComboBox()
        {
            if (cbNivel.SelectedItem == null)
            {
                MessageBox.Show("Selecione um nivel antes de adicionar o funcionario.");
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
            cbNivel.Items.Clear();
            txtNomeFuncionario.Text = string.Empty;
            txtEmailFuncionario.Text = string.Empty;
            txtSenhaFuncionario.Text = string.Empty;
            Funcionarios.FuncionarioId = string.Empty;

            //carregar a combo box com os niveis
            NiveisAcesso niveis = new NiveisAcesso();
            niveis.CbNiveis = cbNivel;
            niveis.CarregarNiveis();
        }
    }
}
