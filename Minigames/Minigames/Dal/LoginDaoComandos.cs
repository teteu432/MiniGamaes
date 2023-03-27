using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minigames.Dal
{
    internal class LoginDaoComandos
    {
        public string mensagem = "";
        public bool tem ;
        SqlCommand cmd = new SqlCommand();
        conexao con = new conexao();
        SqlDataReader dr;

        
        public bool verificarlogin(string login, string senha)
        {
            //procurar no banco de dados
            cmd.CommandText = "SELECT * FROM Usuario where Username = '"+login+"' AND Password = '"+senha+"' ";
           
            cmd.Parameters.AddWithValue("Username", "login");
            cmd.Parameters.AddWithValue("Password", "senha"); 

            
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    tem = true;
                }
                con.desconectar();
                dr.Close();
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com banco de dados!";
            }
            return tem;
            
        }
        

        public string cadastrar(string email, string senha, string confSenha)
        {   //comandos para inserir
            if (senha.Equals(confSenha))
            {
                cmd.CommandText = "insert into loginss(@e, @s);";
                cmd.Parameters.AddWithValue("@e", email);
                cmd.Parameters.AddWithValue("@s", senha);

                try
                {
                    cmd.Connection = con.conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                }
                catch (SqlException)
                {
                    this.mensagem = "erro com Banco de Dados";
                }
            }
            return mensagem;
        }

    }
}
