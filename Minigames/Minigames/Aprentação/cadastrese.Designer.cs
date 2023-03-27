namespace Minigames.Aprentação
{
    partial class cadastrese
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
            this.label1 = new System.Windows.Forms.Label();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.email1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confSenha = new System.Windows.Forms.TextBox();
            this.senha1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite seu email";
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(123, 229);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 1;
            this.Cadastrar.Text = "cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            // 
            // email1
            // 
            this.email1.Location = new System.Drawing.Point(123, 55);
            this.email1.Name = "email1";
            this.email1.Size = new System.Drawing.Size(158, 20);
            this.email1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite sua senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar senha";
            // 
            // confSenha
            // 
            this.confSenha.Location = new System.Drawing.Point(123, 139);
            this.confSenha.Name = "confSenha";
            this.confSenha.Size = new System.Drawing.Size(88, 20);
            this.confSenha.TabIndex = 5;
            // 
            // senha1
            // 
            this.senha1.Location = new System.Drawing.Point(123, 99);
            this.senha1.Name = "senha1";
            this.senha1.Size = new System.Drawing.Size(88, 20);
            this.senha1.TabIndex = 6;
            // 
            // cadastrese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 291);
            this.Controls.Add(this.senha1);
            this.Controls.Add(this.confSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.email1);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "cadastrese";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox email1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confSenha;
        private System.Windows.Forms.TextBox senha1;
    }
}