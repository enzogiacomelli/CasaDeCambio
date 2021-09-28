using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gerenciadorDeOperacoes
{
    public partial class visualizarMoedasForm : Form
    {
        public visualizarMoedasForm()
        {
            InitializeComponent();
        }

        private void visualizarMoedasForm_Load(object sender, EventArgs e)
        {
            var conectaBanco = DataPersistence.conectarNoBanco();
            conectaBanco.Open();
            var reader = DataPersistence.atualizarGrid(conectaBanco);

            dataGridViewMoedas.Rows.Clear();

            while(reader.Read())
            {
                DataGridViewRow linha = (DataGridViewRow)dataGridViewMoedas.Rows[0].Clone();
                linha.Cells[0].Value = reader.GetString(0);
                linha.Cells[1].Value = reader.GetDouble(1);
                linha.Cells[2].Value = reader.GetDouble(2);
                linha.Cells[3].Value = reader.GetDouble(3);
                linha.Cells[4].Value = reader.GetInt32(4);
                dataGridViewMoedas.Rows.Add(linha);
            }
            conectaBanco.Close();
        }
    }
}
