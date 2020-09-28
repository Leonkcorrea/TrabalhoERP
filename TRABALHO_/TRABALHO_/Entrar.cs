using System;
using System.Collections.Generic;

using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_
{
    public class Entrar
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public bool tem = false;
        MySqlDataReader dr;
        public String mensagem;

        public bool verificarLogin(String usuario, String senha)
        {
            cmd.CommandText = "SELECT * FROM CLIENTE WHERE (usuario = @usuario) and (senha=@senha)";
            cmd.Parameters.AddWithValue("@usuario",usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch(MySqlException e)
            {
                this.mensagem = "Erro ao se conectar ao Banco de Dados!!";
            }
            return tem;


        }
    
    }
}
