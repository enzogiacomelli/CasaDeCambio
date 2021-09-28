using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorDeOperacoes
{
    class Operacao
    {
        public string NomeDoCliente;
        public DateTime DateTimeOperacao;
        public string MoedaAdquirida;
        public string MoedaPagamento;
        public double ValorMoedaDestino;
        public double Taxa;
        public double ValorMoedaOrigem;
        public double ValorTotal;
        

        public Operacao(string nomeCliente, DateTime dataHora, string moedaDestino, string moedaOrigem, double valorMoedaDestino, double valorMoedaOrigem, double taxa, double valorTotal)
        {
            NomeDoCliente = nomeCliente;
            DateTimeOperacao = dataHora;
            MoedaAdquirida = moedaDestino;
            MoedaPagamento = moedaOrigem;
            ValorMoedaDestino = valorMoedaDestino;
            Taxa = taxa;
            ValorMoedaOrigem = valorMoedaOrigem;
            ValorTotal = valorTotal;
        }
    }
}
