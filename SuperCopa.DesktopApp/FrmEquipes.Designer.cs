namespace SuperCopa.DesktopApp
{
    partial class FrmEquipes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbTreinador = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirJogador = new System.Windows.Forms.Button();
            this.btnAdicionarJogador = new System.Windows.Forms.Button();
            this.lvJogadores = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.cbTreinador);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Size = new System.Drawing.Size(624, 550);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Treinador:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(488, 22);
            this.textBox1.TabIndex = 2;
            // 
            // cbTreinador
            // 
            this.cbTreinador.FormattingEnabled = true;
            this.cbTreinador.Location = new System.Drawing.Point(115, 70);
            this.cbTreinador.Name = "cbTreinador";
            this.cbTreinador.Size = new System.Drawing.Size(488, 24);
            this.cbTreinador.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvJogadores);
            this.groupBox1.Controls.Add(this.btnExcluirJogador);
            this.groupBox1.Controls.Add(this.btnAdicionarJogador);
            this.groupBox1.Location = new System.Drawing.Point(28, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 398);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jogadores:";
            // 
            // btnExcluirJogador
            // 
            this.btnExcluirJogador.Location = new System.Drawing.Point(454, 342);
            this.btnExcluirJogador.Name = "btnExcluirJogador";
            this.btnExcluirJogador.Size = new System.Drawing.Size(101, 36);
            this.btnExcluirJogador.TabIndex = 2;
            this.btnExcluirJogador.Text = "Excluir";
            this.btnExcluirJogador.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarJogador
            // 
            this.btnAdicionarJogador.Location = new System.Drawing.Point(347, 342);
            this.btnAdicionarJogador.Name = "btnAdicionarJogador";
            this.btnAdicionarJogador.Size = new System.Drawing.Size(101, 36);
            this.btnAdicionarJogador.TabIndex = 1;
            this.btnAdicionarJogador.Text = "Adicionar";
            this.btnAdicionarJogador.UseVisualStyleBackColor = true;
            // 
            // lvJogadores
            // 
            this.lvJogadores.Location = new System.Drawing.Point(25, 38);
            this.lvJogadores.Name = "lvJogadores";
            this.lvJogadores.Size = new System.Drawing.Size(530, 298);
            this.lvJogadores.TabIndex = 3;
            this.lvJogadores.UseCompatibleStateImageBehavior = false;
            // 
            // FrmEquipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(624, 617);
            this.Name = "FrmEquipes";
            this.Text = "Cadastro de Equipes";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExcluirJogador;
        private System.Windows.Forms.Button btnAdicionarJogador;
        private System.Windows.Forms.ComboBox cbTreinador;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvJogadores;
    }
}
