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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRealizaPedido cadprod = new frmRealizaPedido();
            cadprod.Show();
        }

        private void CadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
