using GerirStockLoja.conexao;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GerirStockLoja.classes
{
    internal class Funcionarios
    {
        
        public static string FuncionarioId { get; set; } //variavel global para receber o valor do funcionario ID sempre que uma linha da tabela for clicada

        private string Query_tabela_funcionario = "SELECT trabalhador_nome, trabalhador_email, trabalhador_senha, trabalhador_nivel FROM trabalhadores";

        private string Query_nivel_nome = "SELECT nivel_nome FROM niveis_acesso WHERE nivel_id = @trabalhador_nivel";
        private string DB_CAMPO_NIVEL_NOME = "nivel_nome";
        private string PARAMETRO_TRABALHADOR_NIVEL = "@trabalhador_nivel";

        private string Query_obter_id_pelo_email = "SELECT trabalhador_id FROM trabalhadores WHERE trabalhador_email = @trabalhador_email";
        private string DB_CAMPO_TRABALHADOR_ID = "trabalhador_id";
        private string PARAMETRO_TRABALHADOR_EMAIL = "@trabalhador_email";

        private string QueryInserirFuncionario = "INSERT INTO trabalhadores (trabalhador_nome, trabalhador_email, trabalhador_senha, trabalhador_nivel) VALUES (@trabalhador_nome, @trabalhador_email, @trabalhador_senha, @trabalhador_nivel)";
        private string PARAMETRO_TRABALHADOR_NOME = "@trabalhador_nome";
        private string PARAMETRO_TRABALHADOR_SENHA = "@trabalhador_senha";

        private string QueryAtualizarFuncionario = "UPDATE trabalhadores SET trabalhador_nome = @trabalhador_nome, trabalhador_email = @trabalhador_email, trabalhador_senha = @trabalhador_senha, trabalhador_nivel = @trabalhador_nivel WHERE trabalhador_id = @trabalhador_id";
        private string PARAMETRO_TRABALHADOR_ID = "@trabalhador_id";

        private string Query_verificar_email = "SELECT COUNT(*) FROM trabalhadores WHERE trabalhador_email = @trabalhador_email";

        private string QueryEliminarFuncionario = "DELETE FROM trabalhadores WHERE trabalhador_id = @trabalhador_id";

        //metodo para obter a tabela de funcionario da bd
        public DataTable ObterTabelaFuncionarios()
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                    conexaoDB.Open();

                    MySqlCommand executacmdsql_tabela = new MySqlCommand(Query_tabela_funcionario, conexaoDB);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(executacmdsql_tabela);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    return dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os niveis: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            return null;
        }

        //metodo para tranformar o nivel do trabalhador no nome do nivel correspondente para selecionar na combo box quando a linha da tabela for clicada
        public string FuncionarioNivelIdParaNome(string trabalhador_nivel)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_nivel_nome, conexaoDB);

                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_NIVEL, trabalhador_nivel);

                    conexaoDB.Open();

                    MySqlDataReader dados_nivel_nome = executacmdsql.ExecuteReader();

                    //se tiver lido os dados passa o nome do trabalhador para uma variavel
                    if (dados_nivel_nome.Read())
                    {
                        string nivel_nome = dados_nivel_nome[DB_CAMPO_NIVEL_NOME].ToString();

                        // Fechar o leitor de dados
                        dados_nivel_nome.Close();

                        // Retorna a string do nome do trabalhador
                        return nivel_nome;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar funcionarios: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }

            // Retorna null ou uma string vazia se nao houver resultado
            return null;
        }


        //metodo para obter o id através do email para mais tarde ser possivel atualizar um funcionario pelo id 
        public string FuncionarioIdPeloEmail(string email)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql = new MySqlCommand(Query_obter_id_pelo_email, conexaoDB);

                    executacmdsql.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_EMAIL, email);

                    conexaoDB.Open();

                    MySqlDataReader dados_id_funcionario = executacmdsql.ExecuteReader();

                    if (dados_id_funcionario.Read())
                    {
                        FuncionarioId = dados_id_funcionario[DB_CAMPO_TRABALHADOR_ID].ToString();

                        // Fechar o leitor de dados
                        dados_id_funcionario.Close();

                        // Retorna a string do nome do trabalhador
                        return FuncionarioId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao ir buscar o id do funcionario à base de dados: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
            // Se houver um erro retorna uma string vazia
            return string.Empty;
        }

        //metodo para adicionar um funcionario à bd
        public void AdicionarFuncionario(string nome, string email, string senha, string nivel_id)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                // Verificar o formato do e-mail
                if (!FormatoEmail(email))
                {
                    MessageBox.Show("Por favor, insira um formato de e-mail válido.");
                    return;
                }
                if (!VerificarConteudoTxtBox(nome, senha))
                {
                    return;
                }

                // Verificar se o e-mail já existe no banco de dados
                if (VerificarEmailBD(email))
                {
                    MessageBox.Show("Este e-mail já está associado a uma conta. Por favor, use outro e-mail.");
                    return;
                }

                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    // Encriptar a senha usando Bcrypt
                    string senhaEncriptada = BCrypt.Net.BCrypt.HashPassword(senha);

                    conexaoDB.Open();

                    MySqlCommand executacmdsql_InserirFuncionario = new MySqlCommand(QueryInserirFuncionario, conexaoDB);

                    // Passar os parâmetros
                    executacmdsql_InserirFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_NOME, nome);
                    executacmdsql_InserirFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_EMAIL, email);
                    executacmdsql_InserirFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_SENHA, senhaEncriptada);
                    executacmdsql_InserirFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_NIVEL, nivel_id);

                    // Executar a query
                    executacmdsql_InserirFuncionario.ExecuteNonQuery();

                    MessageBox.Show("Funcionário adicionado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar funcionário: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para atualizar o funcionario
        public void AtualizarFuncionario(string id, string nome, string email, string senha, string nivel_id)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                if (!VerificarConteudoTxtBox(nome, senha))
                {
                    return;
                }

                // Verificar o formato do e-mail
                if (!FormatoEmail(email))
                {
                    MessageBox.Show("Por favor, insira um formato de e-mail válido.");
                    return;
                }

                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();
                   
                    // Encriptar a senha usando Bcrypt
                    string senhaEncriptada = BCrypt.Net.BCrypt.HashPassword(senha);

                    conexaoDB.Open();
                  
                    MySqlCommand executacmdsql_AtualizarFuncionario = new MySqlCommand(QueryAtualizarFuncionario, conexaoDB);

                    // Passar os parâmetros
                    executacmdsql_AtualizarFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_ID, id);
                    executacmdsql_AtualizarFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_NOME, nome);
                    executacmdsql_AtualizarFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_EMAIL, email);
                    executacmdsql_AtualizarFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_SENHA, senhaEncriptada);
                    executacmdsql_AtualizarFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_NIVEL, nivel_id);

                    // Executar a query
                    executacmdsql_AtualizarFuncionario.ExecuteNonQuery();

                    MessageBox.Show("Funcionário atualizado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar funcionário: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }

        //metodo para eliminar um funcionario através do id do funcionario da linha que esta selecionada
        public void EliminarFuncionario(string id, string nome,  string senha, string email)
        {
            MySqlConnection conexaoDB = null;

            try
            {
                //verificaçoes para nao haver eliminiçoes indesejadas 
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Por favor, selecione uma linha da tabela");
                    return;
                }

                if (!VerificarConteudoTxtBox(nome, senha))
                {
                    return;
                }

                // Verificar o formato do e-mail
                if (!FormatoEmail(email))
                {
                    MessageBox.Show("Por favor, insira um formato de e-mail válido.");
                    return;
                }
                              
                ClassConexao conexao = new ClassConexao();

                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();


                    conexaoDB.Open();

                    MySqlCommand executacmdsql_AtualizarFuncionario = new MySqlCommand(QueryEliminarFuncionario, conexaoDB);

                    // Passar os parâmetros
                    executacmdsql_AtualizarFuncionario.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_ID, id);

                    // Executar a query
                    executacmdsql_AtualizarFuncionario.ExecuteNonQuery();

                    MessageBox.Show("Funcionário Eliminado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao eliminar funcionário: " + ex.Message);
            }
            finally
            {
                // Fechar a conexão
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
        }


        // Verificar o formato do e-mail
        private bool FormatoEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        //verificar se as text box estao preenchidas
        private bool VerificarConteudoTxtBox(string nome, string senha)
        {
            // Verificar se a categoria está selecionada
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, Insira o nome.");
                return false;
            }

            // Verificar se a categoria está selecionada
            if (string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, Insira a senha.");
                return false;
            }
            return true;
        }

        // Verificar se o e-mail já existe no banco de dados
        private bool VerificarEmailBD(string email)
        {
            MySqlConnection conexaoDB = null;
            try
            {
                ClassConexao conexao = new ClassConexao();
                if (conexao.TestarConexao())
                {
                    conexaoDB = conexao.ObterConexao();

                    MySqlCommand executacmdsql_verificar_email = new MySqlCommand(Query_verificar_email, conexaoDB);
                    executacmdsql_verificar_email.Parameters.AddWithValue(PARAMETRO_TRABALHADOR_EMAIL, email);

                    conexaoDB.Open();

                    int count = Convert.ToInt32(executacmdsql_verificar_email.ExecuteScalar()); //retorna o primeiro valor que encontrar

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar o e-mail: " + ex.Message);
            }
            finally
            {
                if (conexaoDB != null)
                {
                    conexaoDB.Close();
                }
            }
            return false;
        }       
    }
}
