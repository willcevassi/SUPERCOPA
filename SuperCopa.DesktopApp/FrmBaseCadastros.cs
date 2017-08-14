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
    public partial class FrmBaseCadastros : Form,ICrud
    {
        public FrmBaseCadastros()
        {
            InitializeComponent();
        }

        public virtual void Editar() { }

        public virtual void Excluir() { }

        public virtual void GerarRelatorio() { }

        public virtual void Novo() { }

        public virtual void Pesquisar() {  }

        public virtual void Salvar()  { }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        private void FrmBaseCadastros_Load(object sender, EventArgs e)
        {
            this.CarregarFormulario();
        }

        public virtual void CarregarFormulario() { }

        #region Barra de Ferramentas
        private void tbtnNovo_Click(object sender, EventArgs e)
        {
            this.Novo();
        }

        private void tbtnSalvar_Click(object sender, EventArgs e)
        {
            this.Salvar();
        }

        private void tbtnExcluir_Click(object sender, EventArgs e)
        {
            this.Excluir();
        }

        private void tbtnPesquisar_Click(object sender, EventArgs e)
        {
            this.Pesquisar();
        }

        private void tbtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbtnGerarRelatorio_Click(object sender, EventArgs e)
        {
            this.GerarRelatorio();
        }
        #endregion
    }
}
