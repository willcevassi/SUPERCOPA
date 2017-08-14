using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SuperCopa.DesktopApp
{
    public partial class FrmEquipes : SuperCopa.DesktopApp.FrmBaseCadastros
    {
        public FrmEquipes()
        {
            InitializeComponent();
        }


        #region Operações de Crud

        public override void Novo()
        {
            MessageBox.Show(this, "Clique do Botão Novo Equipe");
        }

        public override void Excluir()
        {
            MessageBox.Show(this, "Clique do Botão Excluir Equipe");
        }

        public override void Pesquisar()
        {
            MessageBox.Show(this, "Clique do Botão Pesquisar Equipe");
        }

        public override void Editar()
        {
            MessageBox.Show(this, "Clique do Botão Editar Equipe");
        }


        public override void Salvar()
        {
            MessageBox.Show(this, "Clique do Botão Salvar Equipe");

        }

        public override void GerarRelatorio()
        {
            MessageBox.Show(this, "Clique do Botão Gerar Relação de Equipees");
        }

        #endregion
    }
}
