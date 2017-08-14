using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperCopa.DesktopApp
{
    public partial class FrmTreinadores : SuperCopa.DesktopApp.FrmBaseCadastros
    {
        public FrmTreinadores()
        {
            InitializeComponent();
        }

        #region Operações de Crud

        public override void Novo()
        {
            MessageBox.Show(this, "Clique do Botão Novo Treinador");
        }

        public override void Excluir()
        {
            MessageBox.Show(this, "Clique do Botão Excluir Treinador");
        }

        public override void Pesquisar()
        {
            MessageBox.Show(this, "Clique do Botão Pesquisar Treinador");
        }

        public override void Editar()
        {
            MessageBox.Show(this, "Clique do Botão Editar Treinador");
        }


        public override void Salvar()
        {
            MessageBox.Show(this, "Clique do Botão Salvar Treinador");

        }

        public override void GerarRelatorio()
        {
            MessageBox.Show(this, "Clique do Botão Gerar Relação de Treinadores");
        }

        #endregion
    }
}
