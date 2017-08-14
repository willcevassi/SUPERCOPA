namespace SuperCopa.DesktopApp
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPartidas = new System.Windows.Forms.Button();
            this.btnCompeticoes = new System.Windows.Forms.Button();
            this.btnEquipes = new System.Windows.Forms.Button();
            this.btnTreinadores = new System.Windows.Forms.Button();
            this.btnJogadores = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnPartidas);
            this.panel1.Controls.Add(this.btnCompeticoes);
            this.panel1.Controls.Add(this.btnEquipes);
            this.panel1.Controls.Add(this.btnTreinadores);
            this.panel1.Controls.Add(this.btnJogadores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1115, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSair.Image = global::SuperCopa.DesktopApp.Properties.Resources.Sair_48;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(591, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(110, 85);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPartidas
            // 
            this.btnPartidas.Image = global::SuperCopa.DesktopApp.Properties.Resources.Jogos_48;
            this.btnPartidas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPartidas.Location = new System.Drawing.Point(475, 12);
            this.btnPartidas.Name = "btnPartidas";
            this.btnPartidas.Size = new System.Drawing.Size(110, 85);
            this.btnPartidas.TabIndex = 4;
            this.btnPartidas.Text = "Partidas";
            this.btnPartidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPartidas.UseVisualStyleBackColor = true;
            this.btnPartidas.Click += new System.EventHandler(this.btnPartidas_Click);
            // 
            // btnCompeticoes
            // 
            this.btnCompeticoes.Image = global::SuperCopa.DesktopApp.Properties.Resources.Competicao_48;
            this.btnCompeticoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompeticoes.Location = new System.Drawing.Point(359, 12);
            this.btnCompeticoes.Name = "btnCompeticoes";
            this.btnCompeticoes.Size = new System.Drawing.Size(110, 85);
            this.btnCompeticoes.TabIndex = 3;
            this.btnCompeticoes.Text = "Competições";
            this.btnCompeticoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompeticoes.UseVisualStyleBackColor = true;
            this.btnCompeticoes.Click += new System.EventHandler(this.btnCompeticoes_Click);
            // 
            // btnEquipes
            // 
            this.btnEquipes.Image = global::SuperCopa.DesktopApp.Properties.Resources.Times_48;
            this.btnEquipes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEquipes.Location = new System.Drawing.Point(243, 12);
            this.btnEquipes.Name = "btnEquipes";
            this.btnEquipes.Size = new System.Drawing.Size(110, 85);
            this.btnEquipes.TabIndex = 2;
            this.btnEquipes.Text = "Equipes";
            this.btnEquipes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEquipes.UseVisualStyleBackColor = true;
            this.btnEquipes.Click += new System.EventHandler(this.btnEquipes_Click);
            // 
            // btnTreinadores
            // 
            this.btnTreinadores.Image = global::SuperCopa.DesktopApp.Properties.Resources.Treinador_48;
            this.btnTreinadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTreinadores.Location = new System.Drawing.Point(127, 12);
            this.btnTreinadores.Name = "btnTreinadores";
            this.btnTreinadores.Size = new System.Drawing.Size(110, 85);
            this.btnTreinadores.TabIndex = 1;
            this.btnTreinadores.Text = "Treinadores";
            this.btnTreinadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTreinadores.UseVisualStyleBackColor = true;
            this.btnTreinadores.Click += new System.EventHandler(this.btnTreinadores_Click);
            // 
            // btnJogadores
            // 
            this.btnJogadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJogadores.Image = global::SuperCopa.DesktopApp.Properties.Resources.Jogadores_48;
            this.btnJogadores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnJogadores.Location = new System.Drawing.Point(11, 11);
            this.btnJogadores.Name = "btnJogadores";
            this.btnJogadores.Size = new System.Drawing.Size(110, 85);
            this.btnJogadores.TabIndex = 0;
            this.btnJogadores.Text = "Jogadores";
            this.btnJogadores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnJogadores.UseVisualStyleBackColor = true;
            this.btnJogadores.Click += new System.EventHandler(this.btnJogadores_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 228);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1115, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 116);
            this.panel2.TabIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 253);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "SuperCopa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnJogadores;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnTreinadores;
        private System.Windows.Forms.Button btnEquipes;
        private System.Windows.Forms.Button btnCompeticoes;
        private System.Windows.Forms.Button btnPartidas;
        private System.Windows.Forms.Button btnSair;
    }
}

