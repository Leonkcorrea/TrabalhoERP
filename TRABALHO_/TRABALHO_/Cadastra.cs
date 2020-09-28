using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_
{
    public class Cadastra
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        MySqlCommand cmd2 = new MySqlCommand();
        public String mensagem = "";
        MySqlDataReader dr;

        public string CadastraFunc(String usuario, String senha)
        {
            cmd.CommandText = "INSERT INTO CLIENTE(usuario, senha) VALUES (@usuario, @senha)";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd2.CommandText = "SELECT * FROM CLIENTE WHERE usuario = @usuario";
            cmd2.Parameters.AddWithValue("@usuario", usuario);

            try
            {

                cmd2.Connection = conexao.conectar();
                dr = cmd2.ExecuteReader();

                if (dr.HasRows)
                {
                    this.mensagem = "2";
                    conexao.desconectar();
                }
                else
                {
                    conexao.desconectar();
                    cmd.Connection = conexao.conectar();
                    cmd.ExecuteNonQuery();
                    conexao.desconectar();
                    this.mensagem = "1";
                }

            }
            catch (MySqlException e)
            {
                this.mensagem = "3";
            }

            return mensagem;
        }

    }
}

