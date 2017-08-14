using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperCopa.Controller.DTO;
using SuperCopa.Controller.DAL;

namespace SuperCopa.DesktopApp
{
    public partial class FrmJogadores : SuperCopa.DesktopApp.FrmBaseCadastros
    {
        

        public FrmJogadores()
        {
            InitializeComponent();
        }

        #region Metodos
        public override void CarregarFormulario()
        {
            this.Novo();
        }

        private void limparCampos()
        {
            this.lblCodigo.Text = string.Empty;
            this.txtNome.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
            this.cbPosicao.SelectedIndex = -1;
        }

        public override void Novo()
        {
            limparCampos();
        }

        #endregion


        #region Operações de Crud

        public override void Excluir()
        {
            MessageBox.Show(this, "Clique do Botão Excluir Jogador");
        }

        public override void Pesquisar()
        {
            MessageBox.Show(this, "Clique do Botão Pesquisar Jogador");
        }

        public override void Salvar()
        {
            JogadorDTO jogadorDTO = new JogadorDTO();
            JogadorDAL DAL = new JogadorDAL();

            jogadorDTO.Id = (string.IsNullOrEmpty(lblCodigo.Text) ? 0 : int.Parse(lblCodigo.Text));
            jogadorDTO.Nome = txtNome.Text;
            jogadorDTO.Telefone = txtTelefone.Text;
            jogadorDTO.PosicaoPrincipal = (cbPosicao.SelectedIndex == -1 ? string.Empty : cbPosicao.SelectedItem.ToString());

            if (DAL.Salvar(jogadorDTO))
            {
                MessageBox.Show("Registro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in DAL._mensagens)
                {
                    sb.AppendLine(item);
                }
                MessageBox.Show(sb.ToString(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public override void GerarRelatorio()
        {
            MessageBox.Show(this, "Clique do Botão Gerar Relação de Jogadores");
        }

        #endregion

    }
}
