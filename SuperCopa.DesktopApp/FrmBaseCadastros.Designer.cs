namespace SuperCopa.DesktopApp
{
    partial class FrmBaseCadastros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnNovo = new System.Windows.Forms.ToolStripButton();
            this.tbtnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tbtnExcluir = new System.Windows.Forms.ToolStripButton();
            this.tbtnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.tbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tbtnGerarRelatorio = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 361);
            this.panel2.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnNovo,
            this.tbtnSalvar,
            this.tbtnExcluir,
            this.tbtnPesquisar,
            this.tbtnGerarRelatorio,
            this.tbtnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(624, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnNovo
            // 
            this.tbtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnNovo.Image = global::SuperCopa.DesktopApp.Properties.Resources.Novo;
            this.tbtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnNovo.Name = "tbtnNovo";
            this.tbtnNovo.Size = new System.Drawing.Size(36, 36);
            this.tbtnNovo.Text = "toolStripButton1";
            this.tbtnNovo.Click += new System.EventHandler(this.tbtnNovo_Click);
            // 
            // tbtnSalvar
            // 
            this.tbtnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSalvar.Image = global::SuperCopa.DesktopApp.Properties.Resources.Salvar;
            this.tbtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSalvar.Name = "tbtnSalvar";
            this.tbtnSalvar.Size = new System.Drawing.Size(36, 36);
            this.tbtnSalvar.Text = "toolStripButton2";
            this.tbtnSalvar.Click += new System.EventHandler(this.tbtnSalvar_Click);
            // 
            // tbtnExcluir
            // 
            this.tbtnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnExcluir.Image = global::SuperCopa.DesktopApp.Properties.Resources.Excluir;
            this.tbtnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnExcluir.Name = "tbtnExcluir";
            this.tbtnExcluir.Size = new System.Drawing.Size(36, 36);
            this.tbtnExcluir.Text = "tbtnExcluir";
            this.tbtnExcluir.Click += new System.EventHandler(this.tbtnExcluir_Click);
            // 
            // tbtnPesquisar
            // 
            this.tbtnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPesquisar.Image = global::SuperCopa.DesktopApp.Properties.Resources.Pesquisar;
            this.tbtnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPesquisar.Name = "tbtnPesquisar";
            this.tbtnPesquisar.Size = new System.Drawing.Size(36, 36);
            this.tbtnPesquisar.Text = "tbtnPesquisar";
            this.tbtnPesquisar.Click += new System.EventHandler(this.tbtnPesquisar_Click);
            // 
            // tbtnSair
            // 
            this.tbtnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnSair.Image = global::SuperCopa.DesktopApp.Properties.Resources.Fechar;
            this.tbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnSair.Name = "tbtnSair";
            this.tbtnSair.Size = new System.Drawing.Size(36, 36);
            this.tbtnSair.Text = "toolStripButton5";
            this.tbtnSair.Click += new System.EventHandler(this.tbtnSair_Click);
            // 
            // tbtnGerarRelatorio
            // 
            this.tbtnGerarRelatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnGerarRelatorio.Image = global::SuperCopa.DesktopApp.Properties.Resources.Relatorio;
            this.tbtnGerarRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnGerarRelatorio.Name = "tbtnGerarRelatorio";
            this.tbtnGerarRelatorio.Size = new System.Drawing.Size(36, 36);
            this.tbtnGerarRelatorio.Text = "toolStripButton1";
            this.tbtnGerarRelatorio.Click += new System.EventHandler(this.tbtnGerarRelatorio_Click);
            // 
            // FrmBaseCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 361);
            this.Controls.Add(this.panel2);
            this.Name = "FrmBaseCadastros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBaseCadastros";
            this.Load += new System.EventHandler(this.FrmBaseCadastros_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnNovo;
        private System.Windows.Forms.ToolStripButton tbtnSalvar;
        private System.Windows.Forms.ToolStripButton tbtnExcluir;
        private System.Windows.Forms.ToolStripButton tbtnPesquisar;
        private System.Windows.Forms.ToolStripButton tbtnSair;
        private System.Windows.Forms.ToolStripButton tbtnGerarRelatorio;
    }
}