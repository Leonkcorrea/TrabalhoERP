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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            bool verifica = false;
            Entrar entrar = new Entrar();
            verifica = entrar.verificarLogin(txtuser.Text, txtsenha.Text);
            if(verifica == true)
            {
                frmPrincipal prin = new frmPrincipal();
                prin.Show();
                
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos, tente novamente");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmCadastraFunc cadfun = new frmCadastraFunc();
            cadfun.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        }
    }
}
