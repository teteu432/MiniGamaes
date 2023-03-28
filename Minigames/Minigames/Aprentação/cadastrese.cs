using Minigames.Modelo;
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
using System.Windows.Forms;

namespace Minigames.Aprentação
{
    public partial class cadastrese : Form
    {
        Thread t1;
        public cadastrese()
        {
            InitializeComponent();
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string mensagem = controle.cadastrar(email1.Text, senha1.Text, confSenha.Text);
            if(controle.tem)//menssagem de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show(controle.mensagem);// mensagem de erro
            }
        }

        private void email1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJogos);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

        }
        public void AbrirJogos(object obj)
        {
            Application.Run(new telaDeLogin());
        }
    }
}
