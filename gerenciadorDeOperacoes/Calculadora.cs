using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerenciadorDeOperacoes
{
    class Calculadora
    {
        public static double ConverteMoedas(string nomeMoedaDestino, double valorMoedaDestino, string nomeMoedaOrigem)
        {
            //retornar o valor da moeda de origens: ex: quero comprar 1 real com dolar, deve retornar 0,18 dolares

            var moedaDest = DataPersistence.selectMoedas(nomeMoedaDestino);


            if (moedaDest.Nome == "Real")
            {
                switch ((nomeMoedaOrigem))
                {
                    case "Dolar":
                        return valorMoedaDestino * moedaDest.ConverterParaDolar;

                    case "Euro":
                        return valorMoedaDestino * moedaDest.ConverterParaEuro;

                    case "Real":
                        return valorMoedaDestino;
                }
            }

            if(moedaDest.Nome == "Dolar")
                {
                    switch ((nomeMoedaOrigem))
                    {
                        case "Dolar":
                            return valorMoedaDestino;

                        case "Euro":
                            return valorMoedaDestino * moedaDest.ConverterParaEuro;

                        case "Real":
                            return valorMoedaDestino * moedaDest.ConverterParaReal;
                    }
            }

            if (moedaDest.Nome == "Euro")
            {
                switch ((nomeMoedaOrigem))
                {
                    case "Dolar":
                        return valorMoedaDestino * moedaDest.ConverterParaDolar;

                    case "Euro":
                        return valorMoedaDestino;

                    case "Real":
                        return valorMoedaDestino * moedaDest.ConverterParaReal;
                }
            }

            return 0;

        }
    }
}