namespace Minigames.Aprentação
{
    partial class MiniJogos
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
            this.Jogo1 = new System.Windows.Forms.Button();
            this.jogo2 = new System.Windows.Forms.Button();
            this.jogo3 = new System.Windows.Forms.Button();
            this.jogo4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jogo1
            // 
            this.Jogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jogo1.Location = new System.Drawing.Point(70, 125);
            this.Jogo1.Name = "Jogo1";
            this.Jogo1.Size = new System.Drawing.Size(235, 118);
            this.Jogo1.TabIndex = 0;
            this.Jogo1.Text = "Sortei";
            this.Jogo1.UseVisualStyleBackColor = true;
            this.Jogo1.Click += new System.EventHandler(this.Jogo1_Click);
            // 
            // jogo2
            // 
            this.jogo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogo2.Location = new System.Drawing.Point(418, 125);
            this.jogo2.Name = "jogo2";
            this.jogo2.Size = new System.Drawing.Size(235, 118);
            this.jogo2.TabIndex = 1;
            this.jogo2.Text = "Em breve";
            this.jogo2.UseVisualStyleBackColor = true;
            this.jogo2.Click += new System.EventHandler(this.jogo2_Click);
            // 
            // jogo3
            // 
            this.jogo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogo3.Location = new System.Drawing.Point(70, 282);
            this.jogo3.Name = "jogo3";
            this.jogo3.Size = new System.Drawing.Size(235, 118);
            this.jogo3.TabIndex = 2;
            this.jogo3.Text = "Em breve";
            this.jogo3.UseVisualStyleBackColor = true;
            this.jogo3.Click += new System.EventHandler(this.jogo3_Click);
            // 
            // jogo4
            // 
            this.jogo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jogo4.Location = new System.Drawing.Point(418, 282);
            this.jogo4.Name = "jogo4";
            this.jogo4.Size = new System.Drawing.Size(235, 118);
            this.jogo4.TabIndex = 3;
            this.jogo4.Text = "Em breve";
            this.jogo4.UseVisualStyleBackColor = true;
            this.jogo4.Click += new System.EventHandler(this.jogo4_Click);
            // 
            // MiniJogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 438);
            this.Controls.Add(this.jogo4);
            this.Controls.Add(this.jogo3);
            this.Controls.Add(this.jogo2);
            this.Controls.Add(this.Jogo1);
            this.Name = "MiniJogos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiniJogos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Jogo1;
        private System.Windows.Forms.Button jogo2;
        private System.Windows.Forms.Button jogo3;
        private System.Windows.Forms.Button jogo4;
    }
}