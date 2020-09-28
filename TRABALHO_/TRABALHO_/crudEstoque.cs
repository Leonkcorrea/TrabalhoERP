using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABALHO_ {
    class crudEstoque {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();
        public String mensagem = "";
        SqlDataReader dr;
        public bool tem = false;


        public bool criar(string nome, string descricao, float preco, float lote){
            cmd.CommandText = "INSERT INTO ESTOQUE(nome, descricao, preco, lote) VALUES (@nome, @descricao, @preco, @lote)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@preco", preco);
            cmd.Parameters.AddWithValue("@lote", lote);
            try {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    tem = true;
                }
            } catch (SqlException e) {
                this.mensagem = "Erro ao se conectar ao Banco de Dados!!";
            }
            return tem;
        }

        //falta valores editados
        public bool editar(int id) {
            cmd.CommandText = "UPDATE estoque SET nome = '@nome', descricao = '@descricao', preco = '@preco', lote = '@lote' WHERE cod_prod = '@id'";
            try {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    tem = true;
                }
            } catch (MySqlException e) {
                this.mensagem = "Erro ao se conectar ao Banco de Dados!!";
            }
            return tem;
        }

        public void remover(int id) {
            cmd.CommandText = "DELETE FROM estoque WHERE cod_prod = '@id'";
            try {
                cmd.Connection = conexao.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows) {
                    tem = true;
                }
            } catch (MySqlException e) {
                this.mensagem = "Erro ao se conectar ao Banco de Dados!!";
            }
            return tem;
        }

        public void vizualizar() {

        }
    }
}
