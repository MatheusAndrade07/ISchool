using System;
using System.Data.SqlClient; 
using System.Windows.Forms;
using Tela_De_Login.Database; 

namespace Tela_De_Login
{
    public partial class frmCadastrarAtividade : Form
    {
        private string emailProfessor;
        private int idTurma;

        public frmCadastrarAtividade(string emailProfessor, int idTurma)
        {
            InitializeComponent();
            this.emailProfessor = emailProfessor;
            this.idTurma = idTurma;
        }

        private void btnCadastrarAtividade_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloAtividade.Text.Trim();
            string descricao = rtxDescricaoAtividade.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descricao))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                StrConnection conexaoDB = new StrConnection();
                string connectionString = conexaoDB.ConnectionString;

                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();

                    string sql = "INSERT INTO Atividade (Descricao, IdTurma) VALUES (@Descricao, @IdTurma)";
                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@Descricao", descricao);
                        cmd.Parameters.AddWithValue("@IdTurma", idTurma);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Atividade cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTituloAtividade.Clear();
                rtxDescricaoAtividade.Clear();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar atividade: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}