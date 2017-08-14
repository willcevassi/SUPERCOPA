using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperCopa.DesktopApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult opcao = MessageBox.Show(this, "Você tem certeza que deseja sair ?", "SuperCopa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (opcao == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnJogadores_Click(object sender, EventArgs e)
        {
            FrmJogadores frmJogadores = new FrmJogadores();
            frmJogadores.ShowDialog(this);
        }

        private void btnTreinadores_Click(object sender, EventArgs e)
        {
            FrmTreinadores frmTreinadores = new FrmTreinadores();
            frmTreinadores.ShowDialog(this);
        }

        private void btnEquipes_Click(object sender, EventArgs e)
        {
            FrmEquipes frmEquipes = new FrmEquipes();
            frmEquipes.ShowDialog(this);
        }

        private void btnCompeticoes_Click(object sender, EventArgs e)
        {
            FrmCompeticoes frmCompeticoes = new FrmCompeticoes();
            frmCompeticoes.ShowDialog(this);
        }

        private void btnPartidas_Click(object sender, EventArgs e)
        {
            FrmPartidas frmPartidas = new FrmPartidas();
            frmPartidas.ShowDialog(this);
        }
    }
}
