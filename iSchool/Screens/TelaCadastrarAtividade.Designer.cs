namespace Tela_De_Login
{
    partial class frmCadastrarAtividade
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
            this.btnCadastrarAtividade = new System.Windows.Forms.Button();
            this.lblDescricaoAtividade = new System.Windows.Forms.Label();
            this.lblTituloAtividade = new System.Windows.Forms.Label();
            this.txtTituloAtividade = new System.Windows.Forms.TextBox();
            this.rtxDescricaoAtividade = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarAtividade
            // 
            this.btnCadastrarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarAtividade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarAtividade.Location = new System.Drawing.Point(166, 280);
            this.btnCadastrarAtividade.Name = "btnCadastrarAtividade";
            this.btnCadastrarAtividade.Size = new System.Drawing.Size(204, 50);
            this.btnCadastrarAtividade.TabIndex = 10;
            this.btnCadastrarAtividade.Text = "Cadastrar Atividade";
            this.btnCadastrarAtividade.UseVisualStyleBackColor = true;
            this.btnCadastrarAtividade.Click += new System.EventHandler(this.btnCadastrarAtividade_Click);
            // 
            // lblDescricaoAtividade
            // 
            this.lblDescricaoAtividade.AutoSize = true;
            this.lblDescricaoAtividade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoAtividade.Location = new System.Drawing.Point(146, 110);
            this.lblDescricaoAtividade.Name = "lblDescricaoAtividade";
            this.lblDescricaoAtividade.Size = new System.Drawing.Size(226, 24);
            this.lblDescricaoAtividade.TabIndex = 14;
            this.lblDescricaoAtividade.Text = "Descrição da Atividade";
            // 
            // lblTituloAtividade
            // 
            this.lblTituloAtividade.AutoSize = true;
            this.lblTituloAtividade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloAtividade.Location = new System.Drawing.Point(169, 44);
            this.lblTituloAtividade.Name = "lblTituloAtividade";
            this.lblTituloAtividade.Size = new System.Drawing.Size(185, 24);
            this.lblTituloAtividade.TabIndex = 13;
            this.lblTituloAtividade.Text = "Titíulo da Atividade";
            // 
            // txtTituloAtividade
            // 
            this.txtTituloAtividade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloAtividade.Location = new System.Drawing.Point(150, 71);
            this.txtTituloAtividade.Name = "txtTituloAtividade";
            this.txtTituloAtividade.Size = new System.Drawing.Size(220, 26);
            this.txtTituloAtividade.TabIndex = 11;
            // 
            // rtxDescricaoAtividade
            // 
            this.rtxDescricaoAtividade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxDescricaoAtividade.Location = new System.Drawing.Point(139, 137);
            this.rtxDescricaoAtividade.Name = "rtxDescricaoAtividade";
            this.rtxDescricaoAtividade.Size = new System.Drawing.Size(255, 137);
            this.rtxDescricaoAtividade.TabIndex = 15;
            this.rtxDescricaoAtividade.Text = "";
            // 
            // frmCadastrarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 385);
            this.Controls.Add(this.rtxDescricaoAtividade);
            this.Controls.Add(this.lblDescricaoAtividade);
            this.Controls.Add(this.lblTituloAtividade);
            this.Controls.Add(this.txtTituloAtividade);
            this.Controls.Add(this.btnCadastrarAtividade);
            this.Name = "frmCadastrarAtividade";
            this.Text = "Cadastrar Atividade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarAtividade;
        private System.Windows.Forms.Label lblDescricaoAtividade;
        private System.Windows.Forms.Label lblTituloAtividade;
        private System.Windows.Forms.TextBox txtTituloAtividade;
        private System.Windows.Forms.RichTextBox rtxDescricaoAtividade;
    }
}