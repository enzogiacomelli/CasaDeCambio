using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerenciadorDeOperacoes
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void inicial_Load(object sender, EventArgs e)
        {

        }

        private void operaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void novaMoedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editarMoedasForm form = new editarMoedasForm();
            form.Show();
        }

        private void visualizarMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visualizarMoedasForm form = new visualizarMoedasForm();
            form.Show();
        }

        private void btnCalcularConversao_Click(object sender, EventArgs e)
        {
            string moedaDest = moedaDestino.SelectedItem.ToString();
            string moedaOrig = moedaOrigem.SelectedItem.ToString();
            double valorMoedaDest = Convert.ToDouble(valorMoedaDestino.Text);


            valorMoedaOrigem.Text = string.Format("{0:0.00}", Calculadora.ConverteMoedas(moedaDest, valorMoedaDest, moedaOrig));
            taxaCompra.Text = string.Format("{0:0.00}", Convert.ToDouble(valorMoedaOrigem.Text) * 0.10);
            valorTotal.Text = string.Format("{0:0.00}", Convert.ToDouble(taxaCompra.Text) + Convert.ToDouble(valorMoedaOrigem.Text));

            btnSaveOperacao.Enabled = true;

        }

        private void valorMoedaOrigem_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dolarhoje.com/");
        }

        private void btnSaveOperacao_Click(object sender, EventArgs e)
        {
            dataOperacao.Value = DateTime.Now;
            //string.Format("{0:0.00}",
            Operacao operacao = new Operacao(nomeClienteTxt.Text, 
                dataOperacao.Value, 
                moedaDestino.Text, 
                moedaOrigem.Text, 
                Convert.ToDouble(string.Format("{0:0.00}", valorMoedaDestino.Text)), 
                Convert.ToDouble(string.Format("{0:0.00}", valorMoedaOrigem.Text)), 
                Convert.ToDouble(string.Format("{0:0.00}", taxaCompra.Text)), 
                Convert.ToDouble(string.Format("{0:0.00}", valorTotal.Text))
                );



            DataPersistence.saveOperacao(operacao);

            nomeClienteTxt.Clear();
            moedaDestino.SelectedItem = null;
            moedaOrigem.SelectedItem = null;
            valorMoedaDestino.Clear();
            valorMoedaOrigem.Clear();
            taxaCompra.Clear();
            valorTotal.Clear();

            btnSaveOperacao.Enabled = false;
        }

        private void listagemDeOperaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListagemOperacoes form = new ListagemOperacoes();
            form.Show();
        }
    }
}
