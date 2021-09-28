using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorDeOperacoes
{
    class Moeda
    {
        public string Nome;
        public double ConverterParaReal;
        public double ConverterParaDolar;
        public double ConverterParaEuro;

        public Moeda(string nome, double convertToReal, double convertToDolar, double convertToEuro)
        {
            Nome = nome;
            ConverterParaReal = convertToReal;
            ConverterParaDolar = convertToDolar;
            ConverterParaEuro = convertToEuro;
        }

        public Moeda()
        {

        }
    }
}
