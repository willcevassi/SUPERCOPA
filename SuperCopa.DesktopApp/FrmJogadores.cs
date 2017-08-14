using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperCopa.DesktopApp
{
    public partial class FrmJogadores : SuperCopa.DesktopApp.FrmBaseCadastros
    {
        public FrmJogadores()
        {
            InitializeComponent();
        }
        #region Operações de Crud

        public override void Novo()
        {
            MessageBox.Show(this, "Clique do Botão Novo Jogador");
        }

        public override void Excluir()
        {
            MessageBox.Show(this, "Clique do Botão Excluir Jogador");
        }

        public override void Pesquisar()
        {
            MessageBox.Show(this, "Clique do Botão Pesquisar Jogador");
        }

        public override void Editar()
        {
            MessageBox.Show(this, "Clique do Botão Editar Jogador");
        }


        public override void Salvar()
        {
            MessageBox.Show(this, "Clique do Botão Salvar Jogador");

        }

        public override void GerarRelatorio()
        {
            MessageBox.Show(this, "Clique do Botão Gerar Relação de Jogadores");
        }

        #endregion

    }
}
