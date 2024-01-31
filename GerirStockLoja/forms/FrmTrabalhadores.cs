using GerirStockLoja.classes;
using GerirStockLoja.conexao;
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

namespace GerirStockLoja
{
    public partial class FrmTrabalhadores : Form
    {
        public FrmTrabalhadores()
        {
            InitializeComponent();

            // Use essas informações conforme necessário
            string nomeTrabalhador = LoginManager.NomeTrabalhador;
            

            labelBemVindo.Text = "Bem vindo " + nomeTrabalhador;


        }

        //metodo para adicionar um user control ao painel admin, limpando o anterior e adicionando um novo
        private void addUserControl(UserControl userControl) 
        {
            userControl.Dock = DockStyle.Fill;
            panelTrabalhadores.Controls.Clear();
            panelTrabalhadores.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void FrmTrabalhadores_Load(object sender, EventArgs e)
        {
            UC_vender uc = new UC_vender();
            addUserControl(uc);
        }


        private void BtnVender_Click(object sender, EventArgs e)
        {
            UC_vender uc = new UC_vender();
            addUserControl(uc);
        }

        private void BtnEstatisticas_Click(object sender, EventArgs e)
        {
            UC_estatisticas uc = new UC_estatisticas();
            addUserControl(uc);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frm = new FrmLogin();
            frm.Show();
        }
    }
}
