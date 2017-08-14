using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperCopa.DesktopApp
{
    public partial class FrmPartidas : SuperCopa.DesktopApp.FrmBaseCadastros
    {
        public FrmPartidas()
        {
            InitializeComponent();
        }

        #region Operações de Crud

        public override void Novo()
        {
            MessageBox.Show(this, "Clique do Botão Novo Partida");
        }

        public override void Excluir()
        {
            MessageBox.Show(this, "Clique do Botão Excluir Partida");
        }

        public override void Pesquisar()
        {
            MessageBox.Show(this, "Clique do Botão Pesquisar Partida");
        }


        public override void Salvar()
        {
            MessageBox.Show(this, "Clique do Botão Salvar Partida");

        }

        public override void GerarRelatorio()
        {
            MessageBox.Show(this, "Clique do Botão Gerar Relação de Partidaes");
        }

        #endregion
    }
}
