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
    public partial class editarMoedasForm : Form
    {
        public editarMoedasForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void editarMoedasForm_Load(object sender, EventArgs e)
        {
            var moedaReal = DataPersistence.selectMoedas("Real");
            var moedaDolar = DataPersistence.selectMoedas("Dolar");
            var moedaEuro = DataPersistence.selectMoedas("Euro");

            realToDolar.Text = string.Format("{0:0.00}", moedaReal.ConverterParaDolar);
            realToEuro.Text = string.Format("{0:0.00}", moedaReal.ConverterParaEuro);
            dolarToReal.Text = string.Format("{0:0.00}", moedaDolar.ConverterParaReal);
            dolarToEuro.Text = string.Format("{0:0.00}", moedaDolar.ConverterParaEuro);
            euroToReal.Text = string.Format("{0:0.00}", moedaEuro.ConverterParaReal);
            euroToDolar.Text = string.Format("{0:0.00}", moedaEuro.ConverterParaDolar);

        }

        private void realSaveBtn_Click(object sender, EventArgs e)
        {

        }

        private void checkConn_Click(object sender, EventArgs e)
        {
            var conn = DataPersistence.conectarNoBanco();

            conn.Open();

            ReturnStatusConn.Text = conn.Ping().ToString();

            conn.Close();
        }
    }
}
