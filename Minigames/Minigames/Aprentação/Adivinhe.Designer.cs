namespace Minigames.Aprentação
{
    partial class Adivinhe
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
            this.btniniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.Label_Numero = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btniniciar
            // 
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(176, 234);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(109, 40);
            this.btniniciar.TabIndex = 0;
            this.btniniciar.Text = "GO";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adivinhe o número que a  maquina está pensando!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNumero
            // 
            this.textNumero.CausesValidation = false;
            this.textNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumero.Location = new System.Drawing.Point(176, 173);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(109, 29);
            this.textNumero.TabIndex = 3;
            this.textNumero.TextChanged += new System.EventHandler(this.textNumero_TextChanged);
            this.textNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNumero_KeyDown);
            // 
            // Label_Numero
            // 
            this.Label_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Numero.Location = new System.Drawing.Point(52, 58);
            this.Label_Numero.Name = "Label_Numero";
            this.Label_Numero.Size = new System.Drawing.Size(341, 92);
            this.Label_Numero.TabIndex = 4;
            this.Label_Numero.Text = "Advinhe um numero de 0 a 10";
            this.Label_Numero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // voltar
            // 
            this.voltar.Location = new System.Drawing.Point(398, 325);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 5;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // Adivinhe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 360);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.Label_Numero);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btniniciar);
            this.Name = "Adivinhe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivinhe um número";
            this.Load += new System.EventHandler(this.Adivinhe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btniniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label Label_Numero;
        private System.Windows.Forms.Button voltar;
    }
}