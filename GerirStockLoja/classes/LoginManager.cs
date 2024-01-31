using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GerirStockLoja.conexao;
using GerirStockLoja.forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using BCrypt.Net;


namespace GerirStockLoja.classes
{
    internal class LoginManager
    {
        public static string Id { get; set; }
        public static string NomeTrabalhador { get; set; }

        private string QueryObterSenha = "SELECT trabalhador_senha, trabalhador_nivel, trabalhador_id, trabalhador_nome FROM trabalhadores WHERE trabalhador_email = @trabalhador_email";

        private string DB_CAMPO_TRABALHADOR_SENHA = "trabalhador_senha";
        private string DB_CAMPO_TRABALHADOR_NIVEL = "trabalhador_nivel";
        private string DB_CAMPO_TRABALHADOR_NOME = "trabalhador_nome";
        private string DB_CAMPO_TRABALHADOR_ID = "trabalhador_id";
        private string PARAMETRO_TRABALHADOR_EMAIL = "@trabalhador_email";

        private string NIVEL_ADMIN = "1";
        private string NIVEL_FUNCIONARIO = "2";

        public bool ExecutarLogin(string email, string senha)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    // Validar se o email foi preenchido
                    if (string.IsNullOrWhiteSpace(email))
                    {
                        MessageBox.Show("Por favor, insira o email.");
                        return false;
                    }

                    // Validar se a senha foi preenchida
                    if (string.IsNullOrWhiteSpace(senha))
                    {
                        MessageBox.Show("Por favor, insira a password.");
                        return false;
                    }

                    conexaoDB = conexao.ObterConexao();

                    // Obter a senha encriptada do trabalhador usando o email fornecido
                    MySqlCommand executacmdsqlSenha = new MySqlCommand(QueryObterSenha, conexaoDB);
                    executacmdsqlSenha.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_EMAIL, email);

                    conexaoDB.Open();

                    MySqlDataReader dados = executacmdsqlSenha.ExecuteReader();

                    if (dados.Read())
                    {
                        // Verificar a senha usando Bcrypt
                        string senhaHashDB = dados.GetString(DB_CAMPO_TRABALHADOR_SENHA);
                        string nivel_acesso = dados.GetString(DB_CAMPO_TRABALHADOR_NIVEL);
                        string id = dados.GetString(DB_CAMPO_TRABALHADOR_ID);
                        string nomeTrabalhador = dados.GetString(DB_CAMPO_TRABALHADOR_NOME);

                        //se a senha da bd e a introduzida corresponderem executa o login
                        if (BCrypt.Net.BCrypt.Verify(senha, senhaHashDB))
                        {
                            LoginManager.Id = id;
                            LoginManager.NomeTrabalhador = nomeTrabalhador;

                            //atribuir o acesso de acordo com o nivel da pessoa que estiver a fazer login
                            if (nivel_acesso == NIVEL_ADMIN)
                            {
                                MessageBox.Show("Entrou no sistema como administrador!");

                                FrmAdmin frm = new FrmAdmin();
                                frm.Show();
                            }
                            else if (nivel_acesso == NIVEL_FUNCIONARIO)
                            {
                                MessageBox.Show("Entrou no sistema como trabalhador com sucesso! ");

                                FrmTrabalhadores frm = new FrmTrabalhadores();
                                frm.Show();
                            }
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta, tente novamente!");
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email incorreto, tente novamente!");
                        return false;
                    }

                }
                else
                {
                    MessageBox.Show("Erro na conexão com a base de dados");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
                return false;
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }
    }
}