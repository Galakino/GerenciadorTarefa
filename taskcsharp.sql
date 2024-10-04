-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: 04-Out-2024 às 14:35
-- Versão do servidor: 5.7.11
-- PHP Version: 7.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `taskcsharp`
--
CREATE DATABASE IF NOT EXISTS `taskcsharp` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `taskcsharp`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tarefas`
--

DROP TABLE IF EXISTS `tarefas`;
CREATE TABLE IF NOT EXISTS `tarefas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `tarefaNome` varchar(100) NOT NULL,
  `dataFazer` varchar(20) DEFAULT NULL,
  `prioridade` varchar(20) NOT NULL,
  `dataCadastro` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tarefas`
--

INSERT INTO `tarefas` (`id`, `tarefaNome`, `dataFazer`, `prioridade`, `dataCadastro`) VALUES
(4, 'Estudar DankiCode', '07/10', 'Alta', '04/10/2024'),
(5, 'Limpar a casa', '16/10', 'Alta', '04/10/2024'),
(6, 'Arrumar o Pc', '05/10', 'Baixa', '04/10/2024'),
(7, 'Estudar para o enem', '13/10', 'Alta', '04/10/2024'),
(10, 'Lavar louça', '05/10', 'Alta', '04/10/2024');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
