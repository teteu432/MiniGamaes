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
        public string cadastrar(string Username, string Password, string confSenha) 
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(Username, Password, confSenha);
            if(loginDao.tem) //a mensagem que vai vir é de sucesso
            {
                this.tem = true;    
            }
            return mensagem;
        }
        

    }
}
