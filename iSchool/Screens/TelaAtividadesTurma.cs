using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Tela_De_Login.Database;
using System.Linq;

namespace Tela_De_Login
{
    public partial class frmAtividadesTurma : Form
    {
        private string emailProfessorLogado;
        private int idTurma;

        public frmAtividadesTurma(string emailProfessor, int idTurma)
        {
            InitializeComponent();
            this.emailProfessorLogado = emailProfessor;
            this.idTurma = idTurma;

            CarregarInformacoesTurma();
            CarregarAtividadesDaTurma();
            AdicionarBotaoExcluirAtividade();
        }

        private void btnCadastrarAtividade2_Click(object sender, EventArgs e)
        {
            var frm = new frmCadastrarAtividade(emailProfessorLogado, idTurma);
            frm.Owner = this; 
            frm.ShowDialog();
            CarregarAtividadesDaTurma(); 
        }      

        private void CarregarInformacoesTurma()
        {
            StrConnection conexaoDB = new StrConnection();
            string connectionString = conexaoDB.ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT p.Nome AS NomeProfessor, t.NomeTurma
                    FROM Turma t
                    JOIN Professor p ON t.IdProfessor = p.IdProfessor
                    WHERE t.IdTurma = @IdTurma";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@IdTurma", idTurma);

                    try
                    {
                        conexao.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNomeProfessor.Text = "Professor: " + reader["NomeProfessor"].ToString();
                                lblNomeTurma.Text = reader["NomeTurma"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar informações da turma: " + ex.Message);
                    }
                }
            }
        }

        public void CarregarAtividadesDaTurma()
        {
            StrConnection conexaoDB = new StrConnection();
            string connectionString = conexaoDB.ConnectionString;

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                string sql = @"
                    SELECT a.IdAtividade, a.Descricao 
                    FROM Atividade a
                    WHERE a.IdTurma = @IdTurma";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@IdTurma", idTurma);

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
                        MessageBox.Show("Erro ao carregar atividades da turma: " + ex.Message);
                    }
                }
            }
        }

        private void AdicionarBotaoExcluirAtividade()
        {
            DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn();
            colExcluir.Name = "colunaExcluirAtividade"; 
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
                if (dtgvTurmas.Columns[e.ColumnIndex].Name == "colunaExcluirAtividade")
                {
                    int idAtividade = Convert.ToInt32(dtgvTurmas.Rows[e.RowIndex].Cells["IdAtividade"].Value);
                    ExcluirAtividade(idAtividade);
                }
            }
        }

        private void ExcluirAtividade(int idAtividade)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja excluir esta atividade?",
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
                        string sql = "DELETE FROM Atividade WHERE IdAtividade = @IdAtividade";
                        using (SqlCommand cmd = new SqlCommand(sql, conexao))
                        {
                            cmd.Parameters.AddWithValue("@IdAtividade", idAtividade);
                            conexao.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    CarregarAtividadesDaTurma();

                    MessageBox.Show("Atividade excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir a atividade: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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