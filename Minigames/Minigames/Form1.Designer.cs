namespace Minigames
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CriarConta = new System.Windows.Forms.LinkLabel();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(45, 264);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 1;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(93, 72);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(195, 20);
            this.textLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(93, 106);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(78, 20);
            this.textSenha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Não tem uma conta?";
            // 
            // CriarConta
            // 
            this.CriarConta.AutoSize = true;
            this.CriarConta.Location = new System.Drawing.Point(162, 151);
            this.CriarConta.Name = "CriarConta";
            this.CriarConta.Size = new System.Drawing.Size(54, 13);
            this.CriarConta.TabIndex = 6;
            this.CriarConta.TabStop = true;
            this.CriarConta.Text = "cliqui aqui";
            this.CriarConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CriarConta_LinkClicked);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(323, 264);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 7;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 315);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.CriarConta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel CriarConta;
        private System.Windows.Forms.Button sair;
    }
}

