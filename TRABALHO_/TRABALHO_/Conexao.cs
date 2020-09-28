using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_
{
    public class Conexao
    {


        MySqlConnection con = new MySqlConnection();
        public Conexao()
        {
            
            con.ConnectionString = "server=mysql.agecriacoes.com;User ID=agecriacoes01;database=agecriacoes01;password=GilbertoF1";
            // Variavel de conexão 
        }

        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed) {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open) {
                con.Close();
            }

        }
    }
}
