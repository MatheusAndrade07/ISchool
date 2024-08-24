namespace Tela_De_Login
{
    partial class frmTelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLogin));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.lblBemVindoTelaLogin = new System.Windows.Forms.Label();
            this.btnEntrarLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(68, 121);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(220, 26);
            this.txtLogin.TabIndex = 0;
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginSenha.Location = new System.Drawing.Point(68, 187);
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.Size = new System.Drawing.Size(220, 26);
            this.txtLoginSenha.TabIndex = 1;
            // 
            // lblBemVindoTelaLogin
            // 
            this.lblBemVindoTelaLogin.AutoSize = true;
            this.lblBemVindoTelaLogin.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindoTelaLogin.Location = new System.Drawing.Point(100, 42);
            this.lblBemVindoTelaLogin.Name = "lblBemVindoTelaLogin";
            this.lblBemVindoTelaLogin.Size = new System.Drawing.Size(156, 33);
            this.lblBemVindoTelaLogin.TabIndex = 2;
            this.lblBemVindoTelaLogin.Text = "Bem Vindo";
            // 
            // btnEntrarLogin
            // 
            this.btnEntrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrarLogin.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarLogin.Location = new System.Drawing.Point(97, 230);
            this.btnEntrarLogin.Name = "btnEntrarLogin";
            this.btnEntrarLogin.Size = new System.Drawing.Size(159, 50);
            this.btnEntrarLogin.TabIndex = 3;
            this.btnEntrarLogin.Text = "Entrar";
            this.btnEntrarLogin.UseVisualStyleBackColor = true;
            this.btnEntrarLogin.Click += new System.EventHandler(this.btnEntrarLogin_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(64, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(64, 160);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 24);
            this.lblSenha.TabIndex = 5;
            this.lblSenha.Text = "Senha";
            // 
            // frmTelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 314);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnEntrarLogin);
            this.Controls.Add(this.lblBemVindoTelaLogin);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTelaLogin";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.Label lblBemVindoTelaLogin;
        private System.Windows.Forms.Button btnEntrarLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
    }
}

