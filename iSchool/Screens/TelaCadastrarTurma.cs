using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tela_De_Login.Database;

namespace Tela_De_Login
{
    public partial class frmTelaCadastrarTurma : Form
    {
        private string emailProfessor;

        public frmTelaCadastrarTurma(string emailProfessor)
        {
            InitializeComponent();
            this.emailProfessor = emailProfessor;
        }

        private void btnCadastrarTurma_Click(object sender, EventArgs e)
        {
            string nomeTurma = txtNomeCadastrarTurma.Text.Trim();

            if (string.IsNullOrEmpty(nomeTurma))
            {
                MessageBox.Show("Digite o nome da turma!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idProfessor = ObterIdProfessor(emailProfessor);

                StrConnection conexaoDB = new StrConnection();
                string connectionString = conexaoDB.ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string sql = "INSERT INTO Turma (NomeTurma, IdProfessor) VALUES (@NomeTurma, @IdProfessor)";
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@NomeTurma", nomeTurma);
                        cmd.Parameters.AddWithValue("@IdProfessor", idProfessor);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Turma cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomeCadastrarTurma.Text = "";

                AtualizarDataGridViewTurmas();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar turma: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int ObterIdProfessor(string email)
        {
            StrConnection conexaoDB = new StrConnection();
            string connectionString = conexaoDB.ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string sql = "SELECT IdProfessor FROM Professor WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    conexao.Open();
                    object resultado = cmd.ExecuteScalar();
                    return (int)(resultado ?? 0);
                }
            }
        }

        private void AtualizarDataGridViewTurmas()
        {
            frmTelaProfessor frmProfessor = (frmTelaProfessor)this.Owner;

            frmProfessor.CarregarTurmasDoProfessor();
        }
    }
}