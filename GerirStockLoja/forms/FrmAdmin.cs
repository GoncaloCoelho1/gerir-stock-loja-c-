using GerirStockLoja.classes;
using GerirStockLoja.paginas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerirStockLoja.forms
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            string nomeTrabalhador = LoginManager.NomeTrabalhador;

            labelBemVindo.Text = "Bem vindo " + nomeTrabalhador;


        }

        //metodo para adicionar um user control ao painel admin, limpando o anterior e adicionando um novo
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            UC_vender uc = new UC_vender();
            addUserControl(uc);
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            UC_vender uc = new UC_vender();
            addUserControl(uc);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEstatisticas_Click(object sender, EventArgs e)
        {
            UC_estatisticas uc = new UC_estatisticas();
            addUserControl(uc);
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            UC_comprar uc = new UC_comprar();
            addUserControl(uc);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            UC_categorias uc = new UC_categorias();
            addUserControl(uc);
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            UC_produtosDGV uc = new UC_produtosDGV();
            addUserControl(uc);
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            UC_funcionarios uc = new UC_funcionarios();
            addUserControl(uc);
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            UC_fornecedores uc = new UC_fornecedores();
            addUserControl(uc);
        }

        
    }
}
