-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 01-Out-2021 às 01:43
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `casa_de_cambio`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `moedas`
--

CREATE TABLE `moedas` (
  `nome_moeda` varchar(6) NOT NULL,
  `conversao_real` double NOT NULL,
  `conversao_dolar` double NOT NULL,
  `conversao_euro` double NOT NULL,
  `ID_moeda` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `moedas`
--

INSERT INTO `moedas` (`nome_moeda`, `conversao_real`, `conversao_dolar`, `conversao_euro`, `ID_moeda`) VALUES
('Real', 1, 0.19, 0.16, 1),
('Dolar', 5.39, 1, 0.86, 2),
('Euro', 6.3, 1.17, 1, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `operacoes`
--

CREATE TABLE `operacoes` (
  `data_hora` datetime NOT NULL,
  `moeda_adquirida` varchar(6) NOT NULL,
  `moeda_paga` varchar(6) NOT NULL,
  `valor_moeda_adquirida` double NOT NULL,
  `taxa` double NOT NULL,
  `valor_moeda_paga` double NOT NULL,
  `valor_total` double NOT NULL,
  `nome_cliente` varchar(20) NOT NULL,
  `id_operacao` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `operacoes`
--

INSERT INTO `operacoes` (`data_hora`, `moeda_adquirida`, `moeda_paga`, `valor_moeda_adquirida`, `taxa`, `valor_moeda_paga`, `valor_total`, `nome_cliente`, `id_operacao`) VALUES
('2021-09-27 22:08:25', 'Dolar', 'Real', 1, 0.5, 5.39, 5.89, 'jubileu', 1),
('0000-00-00 00:00:00', 'Dolar', 'Real', 1, 0, 5, 5, '', 2);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `moedas`
--
ALTER TABLE `moedas`
  ADD PRIMARY KEY (`ID_moeda`);

--
-- Índices para tabela `operacoes`
--
ALTER TABLE `operacoes`
  ADD PRIMARY KEY (`id_operacao`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `operacoes`
--
ALTER TABLE `operacoes`
  MODIFY `id_operacao` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
