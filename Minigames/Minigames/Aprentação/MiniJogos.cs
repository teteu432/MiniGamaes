using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Minigames.Aprentação
{
    public partial class MiniJogos : Form
    {
        Thread j1;
        public MiniJogos()
        {
            InitializeComponent();
        }

        private void Jogo1_Click(object sender, EventArgs e)
        {
            this.Close();
            j1 = new Thread(AbrirJanela);
            j1.SetApartmentState(ApartmentState.STA);
            j1.Start();
        }

        private void AbrirJanela(object obj)
        {
            Application.Run(new Adivinhe());
        }

        private void jogo2_Click(object sender, EventArgs e)
        {

        }

        private void jogo3_Click(object sender, EventArgs e)
        {

        }

        private void jogo4_Click(object sender, EventArgs e)
        {

        }
    }
}
