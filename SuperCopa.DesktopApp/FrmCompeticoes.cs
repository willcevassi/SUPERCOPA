using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperCopa.DesktopApp
{
    public partial class FrmCompeticoes : SuperCopa.DesktopApp.FrmBaseCadastros
    {
        public FrmCompeticoes()
        {
            InitializeComponent();
        }

        #region Operações de Crud

        public override void Novo()
        {
            MessageBox.Show(this, "Clique do Botão Novo Competição");
        }

        public override void Excluir()
        {
            MessageBox.Show(this, "Clique do Botão Excluir Competição");
        }

        public override void Pesquisar()
        {
            MessageBox.Show(this, "Clique do Botão Pesquisar Competição");
        }

        public override void Salvar()
        {
            MessageBox.Show(this, "Clique do Botão Salvar Competição");

        }

        public override void GerarRelatorio()
        {
            MessageBox.Show(this, "Clique do Botão Gerar Relação de Competiçãoes");
        }

        #endregion

    }
}
