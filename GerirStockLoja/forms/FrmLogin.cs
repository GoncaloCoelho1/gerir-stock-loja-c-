using GerirStockLoja.classes;
using GerirStockLoja.paginas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GerirStockLoja
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
     

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email, senha;

            //recebe os valores inseridos nas text box
            email = textBoxEmail.Text;
            senha = textBoxSenha.Text;

            //executa o metodo
            LoginManager login = new LoginManager();
            bool loginSucesso = login.ExecutarLogin(email, senha);

            if (loginSucesso)
            {
                // Ocultar a página se o login for bem-sucedido
                this.Hide();
            }
        }

    }
}
