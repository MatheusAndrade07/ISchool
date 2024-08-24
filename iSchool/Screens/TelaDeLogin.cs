using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tela_De_Login.Database; 

namespace Tela_De_Login
{
    public partial class frmTelaLogin : Form
    {

        public frmTelaLogin()
        {
            InitializeComponent();
        }       

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            string email = txtLogin.Text;
            string senha = txtLoginSenha.Text;

            StrConnection conexaoDB = new StrConnection();
            string connectionString = conexaoDB.ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string sql = "SELECT COUNT(*) FROM Professor WHERE Email = @Email AND Senha = @Senha";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);

                    try
                    {
                        conexao.Open();
                        int resultado = (int)cmd.ExecuteScalar();

                        if (resultado > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmTelaProfessor frmProfessor = new frmTelaProfessor(email);
                            frmProfessor.Show();      
                            
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
    }
}