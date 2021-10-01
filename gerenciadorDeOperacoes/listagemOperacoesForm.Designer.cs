
namespace gerenciadorDeOperacoes
{
    partial class ListagemOperacoes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_operacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHoraOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moedaAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorMoedaAdquirida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moedaPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_operacao,
            this.DataHoraOperacao,
            this.nomeCliente,
            this.moedaAdquirida,
            this.valorMoedaAdquirida,
            this.moedaPagamento,
            this.valorPago,
            this.valorTotal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(836, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_operacao
            // 
            this.ID_operacao.HeaderText = "ID";
            this.ID_operacao.Name = "ID_operacao";
            this.ID_operacao.ReadOnly = true;
            // 
            // DataHoraOperacao
            // 
            this.DataHoraOperacao.HeaderText = "Data";
            this.DataHoraOperacao.Name = "DataHoraOperacao";
            this.DataHoraOperacao.ReadOnly = true;
            // 
            // nomeCliente
            // 
            this.nomeCliente.HeaderText = "Cliente";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            // 
            // moedaAdquirida
            // 
            this.moedaAdquirida.HeaderText = "Moeda Adquirida";
            this.moedaAdquirida.Name = "moedaAdquirida";
            this.moedaAdquirida.ReadOnly = true;
            // 
            // valorMoedaAdquirida
            // 
            this.valorMoedaAdquirida.HeaderText = "Quantidade Adquirida";
            this.valorMoedaAdquirida.Name = "valorMoedaAdquirida";
            this.valorMoedaAdquirida.ReadOnly = true;
            // 
            // moedaPagamento
            // 
            this.moedaPagamento.HeaderText = "Moeda de Pagamento";
            this.moedaPagamento.Name = "moedaPagamento";
            this.moedaPagamento.ReadOnly = true;
            // 
            // valorPago
            // 
            this.valorPago.HeaderText = "Valor Pago";
            this.valorPago.Name = "valorPago";
            this.valorPago.ReadOnly = true;
            // 
            // valorTotal
            // 
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.ReadOnly = true;
            // 
            // ListagemOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ListagemOperacoes";
            this.ShowIcon = false;
            this.Text = "listagem de Operacoes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_operacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn moedaAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorMoedaAdquirida;
        private System.Windows.Forms.DataGridViewTextBoxColumn moedaPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}