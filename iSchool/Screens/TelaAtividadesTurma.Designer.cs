namespace Tela_De_Login
{
    partial class frmAtividadesTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvTurmas = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTurmas = new System.Windows.Forms.Label();
            this.btnCadastrarAtividade2 = new System.Windows.Forms.Button();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvTurmas
            // 
            this.dtgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTurmas.Location = new System.Drawing.Point(53, 281);
            this.dtgvTurmas.Name = "dtgvTurmas";
            this.dtgvTurmas.Size = new System.Drawing.Size(711, 150);
            this.dtgvTurmas.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(713, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTurmas
            // 
            this.lblTurmas.AutoSize = true;
            this.lblTurmas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurmas.Location = new System.Drawing.Point(50, 243);
            this.lblTurmas.Name = "lblTurmas";
            this.lblTurmas.Size = new System.Drawing.Size(52, 18);
            this.lblTurmas.TabIndex = 16;
            this.lblTurmas.Text = "Turma";
            // 
            // btnCadastrarAtividade2
            // 
            this.btnCadastrarAtividade2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAtividade2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAtividade2.Location = new System.Drawing.Point(560, 146);
            this.btnCadastrarAtividade2.Name = "btnCadastrarAtividade2";
            this.btnCadastrarAtividade2.Size = new System.Drawing.Size(204, 50);
            this.btnCadastrarAtividade2.TabIndex = 15;
            this.btnCadastrarAtividade2.Text = "Cadastrar Atividade";
            this.btnCadastrarAtividade2.UseVisualStyleBackColor = true;
            this.btnCadastrarAtividade2.Click += new System.EventHandler(this.btnCadastrarAtividade2_Click);
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(12, 20);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(191, 24);
            this.lblNomeProfessor.TabIndex = 14;
            this.lblNomeProfessor.Text = "Nome do Professor";
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.Location = new System.Drawing.Point(108, 243);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(245, 17);
            this.lblNomeTurma.TabIndex = 19;
            this.lblNomeTurma.Text = "Desenvolvimento de Sistemas SA01";
            // 
            // frmAtividadesTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomeTurma);
            this.Controls.Add(this.dtgvTurmas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTurmas);
            this.Controls.Add(this.btnCadastrarAtividade2);
            this.Controls.Add(this.lblNomeProfessor);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAtividadesTurma";
            this.Text = "Atividades da Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTurmas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTurmas;
        private System.Windows.Forms.Button btnCadastrarAtividade2;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.Label lblNomeTurma;
    }
}