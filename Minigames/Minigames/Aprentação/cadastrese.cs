using Minigames.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minigames.Aprentação
{
    public partial class cadastrese : Form
    {
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
    }
}
