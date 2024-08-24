namespace Tela_De_Login
{
    partial class frmTelaProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaProfessor));
            this.lblTurmas = new System.Windows.Forms.Label();
            this.btnTelaCadastro = new System.Windows.Forms.Button();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.dtgvTurmas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTurmas
            // 
            this.lblTurmas.AutoSize = true;
            this.lblTurmas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurmas.Location = new System.Drawing.Point(50, 232);
            this.lblTurmas.Name = "lblTurmas";
            this.lblTurmas.Size = new System.Drawing.Size(60, 18);
            this.lblTurmas.TabIndex = 10;
            this.lblTurmas.Text = "Turmas";
            // 
            // btnTelaCadastro
            // 
            this.btnTelaCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaCadastro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaCadastro.Location = new System.Drawing.Point(560, 135);
            this.btnTelaCadastro.Name = "btnTelaCadastro";
            this.btnTelaCadastro.Size = new System.Drawing.Size(204, 50);
            this.btnTelaCadastro.TabIndex = 9;
            this.btnTelaCadastro.Text = "Cadastrar Turma";
            this.btnTelaCadastro.UseVisualStyleBackColor = true;
            this.btnTelaCadastro.Click += new System.EventHandler(this.btnTelaCadastro_Click);
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.Location = new System.Drawing.Point(12, 9);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(191, 24);
            this.lblNomeProfessor.TabIndex = 8;
            this.lblNomeProfessor.Text = "Nome do Professor";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(713, 9);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 38);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // dtgvTurmas
            // 
            this.dtgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTurmas.Location = new System.Drawing.Point(53, 270);
            this.dtgvTurmas.Name = "dtgvTurmas";
            this.dtgvTurmas.Size = new System.Drawing.Size(711, 150);
            this.dtgvTurmas.TabIndex = 13;
            // 
            // frmTelaProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgvTurmas);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTurmas);
            this.Controls.Add(this.btnTelaCadastro);
            this.Controls.Add(this.lblNomeProfessor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaProfessor";
            this.Text = "Administrar Turmas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTurmas;
        private System.Windows.Forms.Button btnTelaCadastro;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dtgvTurmas;
    }
}