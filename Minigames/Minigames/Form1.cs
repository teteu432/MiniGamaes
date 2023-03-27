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
using Minigames.Aprentação;
using Minigames.Modelo;

namespace Minigames
{
    public partial class Form1 : Form
    {
        Thread t1;
        Thread t2;
        public Form1()
        {
            InitializeComponent();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void AbrirJanela(object obj)
        {
            Application.Run(new cadastrese());
        }

        public void AbrirJogos(object obj)
        {
            Application.Run(new MiniJogos());
        }



        private void Entrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(textLogin.Text, textSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    t1 = new Thread(AbrirJogos);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();

                    

                    /* 
                     this.Close();
                    MiniJogos mn = new MiniJogos();
                    mn.Show();
                   */



                }
                else
                {
                    MessageBox.Show("Login não encontato, verifique login e senha", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
