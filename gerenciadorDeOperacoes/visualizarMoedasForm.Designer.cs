namespace gerenciadorDeOperacoes
{
    partial class visualizarMoedasForm
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
            this.dataGridViewMoedas = new System.Windows.Forms.DataGridView();
            this.colunaNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaConvReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaConvDolar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaConvEuro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoedas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMoedas
            // 
            this.dataGridViewMoedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMoedas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNome,
            this.colunaConvReal,
            this.colunaConvDolar,
            this.colunaConvEuro,
            this.colunaID});
            this.dataGridViewMoedas.Location = new System.Drawing.Point(12, 78);
            this.dataGridViewMoedas.Name = "dataGridViewMoedas";
            this.dataGridViewMoedas.Size = new System.Drawing.Size(545, 360);
            this.dataGridViewMoedas.TabIndex = 0;
            // 
            // colunaNome
            // 
            this.colunaNome.HeaderText = "Nome";
            this.colunaNome.Name = "colunaNome";
            this.colunaNome.ReadOnly = true;
            // 
            // colunaConvReal
            // 
            this.colunaConvReal.HeaderText = "Conversão para real";
            this.colunaConvReal.Name = "colunaConvReal";
            this.colunaConvReal.ReadOnly = true;
            // 
            // colunaConvDolar
            // 
            this.colunaConvDolar.HeaderText = "Conversão para dolar";
            this.colunaConvDolar.Name = "colunaConvDolar";
            this.colunaConvDolar.ReadOnly = true;
            // 
            // colunaConvEuro
            // 
            this.colunaConvEuro.HeaderText = "Conversão para euro";
            this.colunaConvEuro.Name = "colunaConvEuro";
            this.colunaConvEuro.ReadOnly = true;
            // 
            // colunaID
            // 
            this.colunaID.HeaderText = "ID";
            this.colunaID.Name = "colunaID";
            this.colunaID.ReadOnly = true;
            // 
            // visualizarMoedasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.dataGridViewMoedas);
            this.MaximizeBox = false;
            this.Name = "visualizarMoedasForm";
            this.ShowIcon = false;
            this.Text = "Visualizar moedas";
            this.Load += new System.EventHandler(this.visualizarMoedasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMoedas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMoedas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaConvReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaConvDolar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaConvEuro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaID;
    }
}