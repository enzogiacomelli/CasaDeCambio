using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gerenciadorDeOperacoes
{
    class DataPersistence
    {
        public static MySqlConnection conectarNoBanco()
        {
            //criando a string de conexão com os parametros do banco a ser utilizado
            MySqlConnectionStringBuilder dadosConn = new MySqlConnectionStringBuilder();
            dadosConn.Server = "localhost";
            dadosConn.Database = "casa_de_cambio";
            dadosConn.UserID = "root";
            dadosConn.Password = "";
            //cria a conexão
            MySqlConnection conexaoDB = new MySqlConnection(dadosConn.ToString());
            return conexaoDB;
        }

        public static Moeda selectMoedas(string nomeMoeda)
        {
            var conexaoDB = conectarNoBanco();
            conexaoDB.Open();

            MySqlCommand comandoSql = conexaoDB.CreateCommand();
            comandoSql.CommandText = "SELECT * FROM `moedas` WHERE `nome_moeda`= '" + nomeMoeda + "'";

            MySqlDataReader reader = comandoSql.ExecuteReader();
            reader.Read();

            Moeda moeda = new Moeda(reader.GetString(0), reader.GetDouble(1), reader.GetDouble(2), reader.GetDouble(3));

            conexaoDB.Close();

            return moeda;
        }


        public static MySqlDataReader atualizarGrid(MySqlConnection conectarBanco)
        {

            MySqlCommand comandoSql = conectarBanco.CreateCommand(); //criando o comando para inserir no banco
            comandoSql.CommandText = "SELECT * FROM `moedas`";

            MySqlDataReader reader = comandoSql.ExecuteReader(); //comando de ler a query

            return reader;
        }

        public static void saveOperacao(Operacao operacao)
        {
            var conexaoDB = conectarNoBanco();
            conexaoDB.Open();
            
            MySqlCommand comandoSql = conexaoDB.CreateCommand();
            comandoSql.CommandText = "INSERT INTO `operacoes` " +
                "(`data_hora`, `moeda_adquirida`, `moeda_paga`, `valor_moeda_adquirida`, `taxa`, `valor_moeda_paga`, `valor_total`, `nome_cliente`) " +
                "VALUES ('" + operacao.DateTimeOperacao + "', '" +
                 operacao.MoedaAdquirida + "', '" +
                 operacao.MoedaPagamento + "', '" +
                 operacao.ValorMoedaDestino + "', '" +
                 operacao.Taxa + "', '" +
                 operacao.ValorMoedaOrigem + "', '" +
                 operacao.ValorTotal + "', '" +
                 operacao.NomeDoCliente + "')";

            comandoSql.ExecuteNonQuery();
            conexaoDB.Close();
        }

        public static void updateMoedas()
        {
            var conexaoDB = conectarNoBanco();
            conexaoDB.Open();

            MySqlCommand comandoSql = conexaoDB.CreateCommand();
            comandoSql.CommandText = "INSERT INTO `moedas` SET ";//terminar dps

        }

    }
}