using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_
{
    public partial class frmRealizaPedido : Form
    {
        public frmRealizaPedido()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            String unid = Convert.ToString(cbunid.Text); //convertendo pra string
            int quant = Convert.ToInt16(txtquant.Text); //convertendo pra int

            //verificando se tem campo nulo
            if (txtcpf.Text == "" || txtdata.Text == "" || txtquant.Text == "" || txtrestricao.Text == "" || txtproduto.Text == "" || unid == "")
            {
                MessageBox.Show("Preencha TODOS os campos do formulário!!");
            }

            else
            {
                //verificando quantidade pedida
                if (quant <= 0)
                {
                    MessageBox.Show("Quantidade inválida");
                }

                else
                {
                    //Enviando 
                    RealizaPedido ped = new RealizaPedido(); //criando variavel 'ped' do tipo RealizaPedido

                    String mensagem = ped.CadastraPed(txtproduto.Text, txtdata.Text, txtcpf.Text, quant, txtrestricao.Text, unid);
                    //a funcao cadastraPed retorna '1' se der certo e '2' se der errado

                    if (mensagem == "1")
                    {
                        MessageBox.Show("Pedido enviado com sucesso!!");
                    }
                    else
                    {
                        MessageBox.Show("Erro! Pedidos não enviados");
                    }
                }


            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //apagando todos os campos
            txtproduto.Clear();
            txtdata.Clear();
            txtrestricao.Clear();
            txtcpf.Clear();
            txtquant.Clear();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            //fecha formulario
            this.Close();
        }
    }
}
