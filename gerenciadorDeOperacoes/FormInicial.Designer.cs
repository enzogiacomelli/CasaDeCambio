namespace gerenciadorDeOperacoes
{
    partial class inicial
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeClienteTxt = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaMoedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarMoedasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listagemDeOperaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorMoedaOrigem = new System.Windows.Forms.MaskedTextBox();
            this.dataOperacao = new System.Windows.Forms.DateTimePicker();
            this.moedaOrigem = new System.Windows.Forms.ComboBox();
            this.moedaDestino = new System.Windows.Forms.ComboBox();
            this.valorMoedaDestino = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.taxaCompra = new System.Windows.Forms.MaskedTextBox();
            this.valorTotal = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalcularConversao = new System.Windows.Forms.Button();
            this.btnSaveOperacao = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Operação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data da Operação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Moeda de Origem";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Moeda de Destino";
            // 
            // nomeClienteTxt
            // 
            this.nomeClienteTxt.Location = new System.Drawing.Point(12, 78);
            this.nomeClienteTxt.Name = "nomeClienteTxt";
            this.nomeClienteTxt.Size = new System.Drawing.Size(215, 20);
            this.nomeClienteTxt.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moedasToolStripMenuItem,
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(470, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moedasToolStripMenuItem
            // 
            this.moedasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaMoedaToolStripMenuItem,
            this.visualizarMoedasToolStripMenuItem});
            this.moedasToolStripMenuItem.Name = "moedasToolStripMenuItem";
            this.moedasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.moedasToolStripMenuItem.Text = "Moedas";
            // 
            // novaMoedaToolStripMenuItem
            // 
            this.novaMoedaToolStripMenuItem.Name = "novaMoedaToolStripMenuItem";
            this.novaMoedaToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.novaMoedaToolStripMenuItem.Text = "Editar moedas";
            this.novaMoedaToolStripMenuItem.Click += new System.EventHandler(this.novaMoedaToolStripMenuItem_Click);
            // 
            // visualizarMoedasToolStripMenuItem
            // 
            this.visualizarMoedasToolStripMenuItem.Name = "visualizarMoedasToolStripMenuItem";
            this.visualizarMoedasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.visualizarMoedasToolStripMenuItem.Text = "Visualizar moedas";
            this.visualizarMoedasToolStripMenuItem.Click += new System.EventHandler(this.visualizarMoedasToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listagemDeOperaçõesToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            this.operaçõesToolStripMenuItem.Click += new System.EventHandler(this.operaçõesToolStripMenuItem_Click);
            // 
            // listagemDeOperaçõesToolStripMenuItem
            // 
            this.listagemDeOperaçõesToolStripMenuItem.Name = "listagemDeOperaçõesToolStripMenuItem";
            this.listagemDeOperaçõesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.listagemDeOperaçõesToolStripMenuItem.Text = "Listagem de operações";
            // 
            // valorMoedaOrigem
            // 
            this.valorMoedaOrigem.Location = new System.Drawing.Point(118, 217);
            this.valorMoedaOrigem.Name = "valorMoedaOrigem";
            this.valorMoedaOrigem.ReadOnly = true;
            this.valorMoedaOrigem.Size = new System.Drawing.Size(100, 20);
            this.valorMoedaOrigem.TabIndex = 7;
            this.valorMoedaOrigem.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.valorMoedaOrigem_MaskInputRejected);
            // 
            // dataOperacao
            // 
            this.dataOperacao.CustomFormat = "";
            this.dataOperacao.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dataOperacao.Location = new System.Drawing.Point(12, 117);
            this.dataOperacao.Name = "dataOperacao";
            this.dataOperacao.Size = new System.Drawing.Size(215, 20);
            this.dataOperacao.TabIndex = 8;
            // 
            // moedaOrigem
            // 
            this.moedaOrigem.FormattingEnabled = true;
            this.moedaOrigem.Items.AddRange(new object[] {
            "Real",
            "Dolar",
            "Euro"});
            this.moedaOrigem.Location = new System.Drawing.Point(12, 217);
            this.moedaOrigem.Name = "moedaOrigem";
            this.moedaOrigem.Size = new System.Drawing.Size(100, 21);
            this.moedaOrigem.TabIndex = 9;
            // 
            // moedaDestino
            // 
            this.moedaDestino.FormattingEnabled = true;
            this.moedaDestino.Items.AddRange(new object[] {
            "Real",
            "Dolar",
            "Euro"});
            this.moedaDestino.Location = new System.Drawing.Point(12, 157);
            this.moedaDestino.Name = "moedaDestino";
            this.moedaDestino.Size = new System.Drawing.Size(100, 21);
            this.moedaDestino.TabIndex = 10;
            // 
            // valorMoedaDestino
            // 
            this.valorMoedaDestino.Location = new System.Drawing.Point(118, 157);
            this.valorMoedaDestino.Mask = "00000";
            this.valorMoedaDestino.Name = "valorMoedaDestino";
            this.valorMoedaDestino.Size = new System.Drawing.Size(100, 20);
            this.valorMoedaDestino.TabIndex = 11;
            this.valorMoedaDestino.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(115, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor a pagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor desejado";
            // 
            // taxaCompra
            // 
            this.taxaCompra.Location = new System.Drawing.Point(118, 256);
            this.taxaCompra.Name = "taxaCompra";
            this.taxaCompra.ReadOnly = true;
            this.taxaCompra.Size = new System.Drawing.Size(100, 20);
            this.taxaCompra.TabIndex = 14;
            // 
            // valorTotal
            // 
            this.valorTotal.Location = new System.Drawing.Point(118, 297);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            this.valorTotal.Size = new System.Drawing.Size(100, 20);
            this.valorTotal.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(115, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Taxa (10%)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(115, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Valor total a pagar";
            // 
            // btnCalcularConversao
            // 
            this.btnCalcularConversao.Location = new System.Drawing.Point(12, 337);
            this.btnCalcularConversao.Name = "btnCalcularConversao";
            this.btnCalcularConversao.Size = new System.Drawing.Size(100, 23);
            this.btnCalcularConversao.TabIndex = 18;
            this.btnCalcularConversao.Text = "Calcular valores";
            this.btnCalcularConversao.UseVisualStyleBackColor = true;
            this.btnCalcularConversao.Click += new System.EventHandler(this.btnCalcularConversao_Click);
            // 
            // btnSaveOperacao
            // 
            this.btnSaveOperacao.Enabled = false;
            this.btnSaveOperacao.Location = new System.Drawing.Point(118, 337);
            this.btnSaveOperacao.Name = "btnSaveOperacao";
            this.btnSaveOperacao.Size = new System.Drawing.Size(100, 23);
            this.btnSaveOperacao.TabIndex = 19;
            this.btnSaveOperacao.Text = "Salvar operação";
            this.btnSaveOperacao.UseVisualStyleBackColor = true;
            this.btnSaveOperacao.Click += new System.EventHandler(this.btnSaveOperacao_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 430);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Verificar valores";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 452);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSaveOperacao);
            this.Controls.Add(this.btnCalcularConversao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valorTotal);
            this.Controls.Add(this.taxaCompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valorMoedaDestino);
            this.Controls.Add(this.moedaDestino);
            this.Controls.Add(this.moedaOrigem);
            this.Controls.Add(this.dataOperacao);
            this.Controls.Add(this.valorMoedaOrigem);
            this.Controls.Add(this.nomeClienteTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "inicial";
            this.ShowIcon = false;
            this.Text = "Gerenciador de Operações";
            this.Load += new System.EventHandler(this.inicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox nomeClienteTxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaMoedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarMoedasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listagemDeOperaçõesToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox valorMoedaOrigem;
        private System.Windows.Forms.DateTimePicker dataOperacao;
        private System.Windows.Forms.ComboBox moedaOrigem;
        private System.Windows.Forms.ComboBox moedaDestino;
        private System.Windows.Forms.MaskedTextBox valorMoedaDestino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox taxaCompra;
        private System.Windows.Forms.MaskedTextBox valorTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalcularConversao;
        private System.Windows.Forms.Button btnSaveOperacao;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

