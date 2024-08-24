using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tela_De_Login.Database;
using System.Linq;

namespace Tela_De_Login
{
    public partial class frmTelaProfessor : Form
    {
        private string emailProfessorLogado;

        public frmTelaProfessor(string emailProfessor)
        {
            InitializeComponent();
            this.emailProfessorLogado = emailProfessor;
            AtualizarNomeProfessor();
            CarregarTurmasDoProfessor();
            AdicionarBotoesDataGridView();
        }

        private void AtualizarNomeProfessor()
        {
            StrConnection conexaoDB = new StrConnection();
            string connectionString = conexaoDB.ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string sql = "SELECT Nome FROM Professor WHERE Email = @EmailProfessor";
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@EmailProfessor", emailProfessorLogado);

                    try
                    {
                        conexao.Open();
                        object nomeProfessor = cmd.ExecuteScalar();

                        if (nomeProfessor != null)
                        {
                            lblNomeProfessor.Text = "Olá, " + nomeProfessor.ToString();
                        }
                        else
                        {
                            lblNomeProfessor.Text = "Nome não encontrado";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar o nome do professor: " + ex.Message);
                    }
                }
            }
        }

        public void CarregarTurmasDoProfessor()
        {
            StrConnection conexaoDB = new StrConnection();
            string connectionString = conexaoDB.ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT t.NomeTurma, t.IdTurma 
                    FROM Turma t
                    JOIN Professor p ON t.IdProfessor = p.IdProfessor
                    WHERE p.Email = @EmailProfessor";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@EmailProfessor", emailProfessorLogado);

                    try
                    {
                        conexao.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dtgvTurmas.DataSource = dt;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar as turmas: " + ex.Message);
                    }
                }
            }
        }

        private void AdicionarBotoesDataGridView()
        {
            DataGridViewButtonColumn colVisualizar = new DataGridViewButtonColumn();
            colVisualizar.Name = "colunaVisualizar";
            colVisualizar.HeaderText = "Visualizar";
            colVisualizar.Text = "Visualizar";
            colVisualizar.UseColumnTextForButtonValue = true;
            dtgvTurmas.Columns.Add(colVisualizar);

            DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn();
            colExcluir.Name = "colunaExcluir";
            colExcluir.HeaderText = "Excluir";
            colExcluir.Text = "Excluir";
            colExcluir.UseColumnTextForButtonValue = true;
            dtgvTurmas.Columns.Add(colExcluir);

            dtgvTurmas.CellContentClick += dtgvTurmas_CellContentClick;
        }

 
        private void dtgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dtgvTurmas.Columns[e.ColumnIndex].Name == "colunaVisualizar")
                {
                    int idTurma = Convert.ToInt32(dtgvTurmas.Rows[e.RowIndex].Cells["IdTurma"].Value);
                    VisualizarTurma(idTurma);
                }
                else if (dtgvTurmas.Columns[e.ColumnIndex].Name == "colunaExcluir")
                {
                    int idTurma = Convert.ToInt32(dtgvTurmas.Rows[e.RowIndex].Cells["IdTurma"].Value);
                    ExcluirTurma(idTurma);
                }
            }
        }

        private void VisualizarTurma(int idTurma)
        {
            frmAtividadesTurma frm = new frmAtividadesTurma(emailProfessorLogado, idTurma);
            frm.ShowDialog();
        }

        private void ExcluirTurma(int idTurma)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta turma?",
                                                  "Confirmar Exclusão",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    StrConnection conexaoDB = new StrConnection();
                    string connectionString = conexaoDB.ConnectionString;

                    using (SqlConnection conexao = new SqlConnection(connectionString))
                    {
                        string sql = "DELETE FROM Turma WHERE IdTurma = @IdTurma";
                        using (SqlCommand cmd = new SqlCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("@IdTurma", idTurma);
                            conexao.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    CarregarTurmasDoProfessor();

                    MessageBox.Show("Turma excluída com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a turma: " + ex.Message);
                }
            }
        }

        private void btnTelaCadastro_Click(object sender, EventArgs e)
        {
            var frm = new frmTelaCadastrarTurma(emailProfessorLogado);
            frm.Owner = this;
            frm.ShowDialog();

            CarregarTurmasDoProfessor();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            frmTelaLogin frmLogin = Application.OpenForms.OfType<frmTelaLogin>().FirstOrDefault();
            if (frmLogin == null)
            {
                frmLogin = new frmTelaLogin();
                frmLogin.Show();
            }
            else
            {
                frmLogin.Show();
                frmLogin.BringToFront();
                frmLogin.Focus();
            }
        }
    }
}