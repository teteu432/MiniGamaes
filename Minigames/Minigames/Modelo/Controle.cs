using Minigames.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigames.Modelo
{
    internal class Controle
    {
        public bool tem;
        public string mensagem = ""; //menssagem de sucesso ou erro


        public bool acessar(string login, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarlogin(login, senha);
            if( ! loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem; //para saber se tam algum erro no código
            }
            return tem;
        }
        public string cadastrar(string email, string senha, string confSenha) 
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            return mensagem;
        }
        

    }
}
