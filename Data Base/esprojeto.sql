-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 24-Jun-2021 às 23:11
-- Versão do servidor: 10.4.6-MariaDB
-- versão do PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `esprojeto`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `account`
--

CREATE TABLE `account` (
  `id` int(10) UNSIGNED NOT NULL,
  `email` varchar(135) NOT NULL,
  `password` varchar(135) NOT NULL,
  `Person_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `account`
--

INSERT INTO `account` (`id`, `email`, `password`, `Person_id`) VALUES
(1, 'adminguy@', '1234', 1),
(2, 'Staffguy@', '1234', 3),
(3, 'clientguy@', '1234', 2),
(4, 'Wilson-andre100@hotmail.com', '1234', 10),
(5, 'Adalberto@hotmail.com', '1234', 11),
(6, 'w', 'w', 12),
(11, 'doutor@', '1234', 18);

-- --------------------------------------------------------

--
-- Estrutura da tabela `adminaccount`
--

CREATE TABLE `adminaccount` (
  `id` int(10) UNSIGNED NOT NULL,
  `Account_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `adminaccount`
--

INSERT INTO `adminaccount` (`id`, `Account_id`) VALUES
(1, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `appointment`
--

CREATE TABLE `appointment` (
  `id` int(10) UNSIGNED NOT NULL,
  `date` text NOT NULL,
  `description` varchar(300) DEFAULT NULL,
  `scheduled_time` text NOT NULL,
  `StaffAccount_id` int(10) UNSIGNED NOT NULL,
  `ClientAccount_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `appointment`
--

INSERT INTO `appointment` (`id`, `date`, `description`, `scheduled_time`, `StaffAccount_id`, `ClientAccount_id`) VALUES
(1, '2021-06-12 ', 'Check-up', '2021-06-24 18:40:00', 1, 1),
(3, '2021-06-22', 'Check-up', '2021-06-22 18:51:37', 1, 1),
(12, '2021-06-22', 'Blood test', '2021-06-22 19:30:56', 1, 1),
(16, '2021-06-23', 'Radiography', '2021-06-23 10:17:05', 1, 4),
(17, '2021-06-23', 'Check-up', '2021-06-23 11:11:43', 3, 4),
(18, '2021-06-23', 'Check-up', '2021-06-23 12:22:12', 3, 4),
(19, '2021-06-23', 'Radiography', '2021-06-23 12:23:29', 1, 4),
(20, '2021-06-23', 'Blood test', '2021-06-24 20:40:02', 3, 3);

-- --------------------------------------------------------

--
-- Estrutura da tabela `clientaccount`
--

CREATE TABLE `clientaccount` (
  `id` int(10) UNSIGNED NOT NULL,
  `Account_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `clientaccount`
--

INSERT INTO `clientaccount` (`id`, `Account_id`) VALUES
(1, 3),
(3, 5),
(4, 6);

-- --------------------------------------------------------

--
-- Estrutura da tabela `item`
--

CREATE TABLE `item` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(45) NOT NULL,
  `type` enum('medicine','treatment','exercise') NOT NULL,
  `weight` decimal(10,0) DEFAULT NULL,
  `session` varchar(45) DEFAULT NULL,
  `treat_time` decimal(10,0) DEFAULT NULL,
  `exercise_dur` varchar(45) DEFAULT NULL,
  `Prescription_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `item`
--

INSERT INTO `item` (`id`, `name`, `type`, `weight`, `session`, `treat_time`, `exercise_dur`, `Prescription_id`) VALUES
(1, 'Penicillin', 'medicine', '250', NULL, '30', NULL, 1),
(2, 'Anti-Inflammatory', 'medicine', '150', NULL, '20', NULL, 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `person`
--

CREATE TABLE `person` (
  `id` int(11) NOT NULL,
  `name` varchar(135) DEFAULT NULL,
  `age` int(11) DEFAULT NULL,
  `address` varchar(135) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `person`
--

INSERT INTO `person` (`id`, `name`, `age`, `address`) VALUES
(1, 'AdminGuy', 12, 'Funchal'),
(2, 'Clientguy', 1, 'Ribeira Brava'),
(3, 'Staffguy', 23, 'Calheta'),
(10, 'Luis', 23, 'Serra da estrela'),
(11, 'joao', 69, 'Caniço'),
(12, 'wilson', 1, 'Ribeira Brava'),
(18, 'Doutor Manfarrico', 12, 'Funchal');

-- --------------------------------------------------------

--
-- Estrutura da tabela `prescription`
--

CREATE TABLE `prescription` (
  `id` int(10) UNSIGNED NOT NULL,
  `name` varchar(45) NOT NULL,
  `description` varchar(200) NOT NULL,
  `date_prescribed` text NOT NULL,
  `Appointment_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `prescription`
--

INSERT INTO `prescription` (`id`, `name`, `description`, `date_prescribed`, `Appointment_id`) VALUES
(1, 'Medical Items', 'Prescribed the following medicines:\r\n- Penicillin\r\n- Anti - inflammatory', '24/06/2021 19:49:13', 1),
(2, 'Results', 'Positive Results', '24/06/2021 19:49:13', 20),
(3, 'Result', 'Negative Results', '24/06/2021 19:49:21', 20),
(8, 'Medical Items', 'ben-u-ron 500 mg', '24/06/2021 20:46:29', 20);

-- --------------------------------------------------------

--
-- Estrutura da tabela `staffaccount`
--

CREATE TABLE `staffaccount` (
  `id` int(10) UNSIGNED NOT NULL,
  `department` varchar(45) DEFAULT NULL,
  `salary` double NOT NULL,
  `Account_id` int(10) UNSIGNED NOT NULL,
  `AdminAccount_id` int(10) UNSIGNED NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Extraindo dados da tabela `staffaccount`
--

INSERT INTO `staffaccount` (`id`, `department`, `salary`, `Account_id`, `AdminAccount_id`) VALUES
(1, 'Doctor', 12, 2, 1),
(3, 'Doctor', 12, 11, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email_UNIQUE` (`email`),
  ADD UNIQUE KEY `idAccount_UNIQUE` (`id`),
  ADD KEY `fk_Account_Person1_idx` (`Person_id`);

--
-- Índices para tabela `adminaccount`
--
ALTER TABLE `adminaccount`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_AdminAccount_Account1_idx` (`Account_id`);

--
-- Índices para tabela `appointment`
--
ALTER TABLE `appointment`
  ADD PRIMARY KEY (`id`,`StaffAccount_id`,`ClientAccount_id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Appointment_StaffAccount_idx` (`StaffAccount_id`),
  ADD KEY `fk_Appointment_ClientAccount1_idx` (`ClientAccount_id`);

--
-- Índices para tabela `clientaccount`
--
ALTER TABLE `clientaccount`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_ClientAccount_Account1_idx` (`Account_id`);

--
-- Índices para tabela `item`
--
ALTER TABLE `item`
  ADD PRIMARY KEY (`id`,`Prescription_id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Item_Prescription1_idx` (`Prescription_id`);

--
-- Índices para tabela `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idPerson_UNIQUE` (`id`);

--
-- Índices para tabela `prescription`
--
ALTER TABLE `prescription`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `id_UNIQUE` (`id`),
  ADD KEY `fk_Prescription_Appointment1_idx` (`Appointment_id`);

--
-- Índices para tabela `staffaccount`
--
ALTER TABLE `staffaccount`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `idAccounts_UNIQUE` (`id`),
  ADD KEY `fk_StaffAccount_Account1_idx` (`Account_id`),
  ADD KEY `fk_StaffAccount_AdminAccount1_idx` (`AdminAccount_id`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `account`
--
ALTER TABLE `account`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT de tabela `adminaccount`
--
ALTER TABLE `adminaccount`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `appointment`
--
ALTER TABLE `appointment`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT de tabela `clientaccount`
--
ALTER TABLE `clientaccount`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de tabela `item`
--
ALTER TABLE `item`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de tabela `person`
--
ALTER TABLE `person`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;

--
-- AUTO_INCREMENT de tabela `prescription`
--
ALTER TABLE `prescription`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `staffaccount`
--
ALTER TABLE `staffaccount`
  MODIFY `id` int(10) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `account`
--
ALTER TABLE `account`
  ADD CONSTRAINT `fk_Account_Person1` FOREIGN KEY (`Person_id`) REFERENCES `person` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `adminaccount`
--
ALTER TABLE `adminaccount`
  ADD CONSTRAINT `fk_AdminAccount_Account1` FOREIGN KEY (`Account_id`) REFERENCES `account` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `appointment`
--
ALTER TABLE `appointment`
  ADD CONSTRAINT `fk_Appointment_ClientAccount1` FOREIGN KEY (`ClientAccount_id`) REFERENCES `clientaccount` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_Appointment_StaffAccount` FOREIGN KEY (`StaffAccount_id`) REFERENCES `staffaccount` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `clientaccount`
--
ALTER TABLE `clientaccount`
  ADD CONSTRAINT `fk_ClientAccount_Account1` FOREIGN KEY (`Account_id`) REFERENCES `account` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `item`
--
ALTER TABLE `item`
  ADD CONSTRAINT `fk_Item_Prescription1` FOREIGN KEY (`Prescription_id`) REFERENCES `prescription` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `prescription`
--
ALTER TABLE `prescription`
  ADD CONSTRAINT `fk_Prescription_Appointment1` FOREIGN KEY (`Appointment_id`) REFERENCES `appointment` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Limitadores para a tabela `staffaccount`
--
ALTER TABLE `staffaccount`
  ADD CONSTRAINT `fk_StaffAccount_Account1` FOREIGN KEY (`Account_id`) REFERENCES `account` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_StaffAccount_AdminAccount1` FOREIGN KEY (`AdminAccount_id`) REFERENCES `adminaccount` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
