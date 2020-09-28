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
    public partial class frmCadastraFunc : Form
    {
        public frmCadastraFunc()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            Cadastra cad = new Cadastra();
            mensagem = cad.CadastraFunc(txtuser.Text, txtsenha.Text);

            if(mensagem == "1")
            {
                MessageBox.Show("Usuário cadastrado com sucesso!!");
                this.Close();
            }
            else if (mensagem == "2")
            {
                MessageBox.Show("Usuário existente, tente novamente!!");
            }

            else
            {
                MessageBox.Show("ERRO NA CONEXÃO!!");
            }
            
            
        }
    }
}
