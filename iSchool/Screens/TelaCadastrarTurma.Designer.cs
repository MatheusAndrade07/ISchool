namespace Tela_De_Login
{
    partial class frmTelaCadastrarTurma
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
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.lblNomeTurma = new System.Windows.Forms.Label();
            this.txtNomeCadastrarTurma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarTurma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTurma.Location = new System.Drawing.Point(178, 175);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(159, 50);
            this.btnCadastrarTurma.TabIndex = 10;
            this.btnCadastrarTurma.Text = "Cadastrar";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // lblNomeTurma
            // 
            this.lblNomeTurma.AutoSize = true;
            this.lblNomeTurma.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeTurma.Location = new System.Drawing.Point(174, 80);
            this.lblNomeTurma.Name = "lblNomeTurma";
            this.lblNomeTurma.Size = new System.Drawing.Size(156, 24);
            this.lblNomeTurma.TabIndex = 12;
            this.lblNomeTurma.Text = "Nome da Turma";
            // 
            // txtNomeCadastrarTurma
            // 
            this.txtNomeCadastrarTurma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCadastrarTurma.Location = new System.Drawing.Point(151, 125);
            this.txtNomeCadastrarTurma.Name = "txtNomeCadastrarTurma";
            this.txtNomeCadastrarTurma.Size = new System.Drawing.Size(220, 26);
            this.txtNomeCadastrarTurma.TabIndex = 11;
            // 
            // frmTelaCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 312);
            this.Controls.Add(this.lblNomeTurma);
            this.Controls.Add(this.txtNomeCadastrarTurma);
            this.Controls.Add(this.btnCadastrarTurma);
            this.Name = "frmTelaCadastrarTurma";
            this.Text = "Cadastrar Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarTurma;
        private System.Windows.Forms.Label lblNomeTurma;
        private System.Windows.Forms.TextBox txtNomeCadastrarTurma;
    }
}