using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Minigames.Aprentação
{
    public partial class Adivinhe : Form
    {
        Thread tv;

        int tentativa = 0;
        int minimo = 0;
        int maximo = 10;
        int numero = 0;
        int chances = 3;



        public Adivinhe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Adivinhe_Load(object sender, EventArgs e)
        {
            textNumero.Enabled = false;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            tentativa = 0;
            minimo = 0;
            maximo = 10;
            numero = 0;
            Random rdn = new Random();
            numero = rdn.Next(minimo, maximo);

            Label_Numero.Text = "Jogo iniciado" +
                Environment.NewLine +
                "Adivinhe o número entre" + Environment.NewLine +
                string.Format("{0} e {1}", minimo, maximo);
            textNumero.Enabled = true;
            textNumero.Text = "";
            textNumero.Focus();
            btniniciar.Enabled = false;
                
            
        }

        private void textNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Return && textNumero.Text != "") 
            {
                e.SuppressKeyPress = true;
                int.TryParse(textNumero.Text, out int valor);

                if(valor < numero)
                {
                    Label_Numero.Text = "O numero é mais alto";
                    tentativa++;
                }else if (valor > numero) 
                {
                    Label_Numero.Text = "O numero é mais baixo";
                    tentativa++;

                }
                else
                {
                    //Venceu
                    Label_Numero.Text = "acertou!!!" + Environment.NewLine +
                        "tentativas: " + tentativa;
                    textNumero.Enabled = false;
                     btniniciar.Enabled = true;
                }
                
                    
                
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            this.Close();
            tv = new Thread(AbrirJogos);
            tv.SetApartmentState(ApartmentState.STA);
            tv.Start();
        }
        public void AbrirJogos(object obj)
        {
            Application.Run(new MiniJogos());
        }
    }
}
