-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: erp_rcp
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8mb4 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dba_atividade`
--

DROP TABLE IF EXISTS `dba_atividade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dba_atividade` (
  `atv_codigo` char(7) NOT NULL,
  `atv_descricao` varchar(150) DEFAULT NULL,
  `atv_observacao` blob,
  PRIMARY KEY (`atv_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dba_atividade`
--

LOCK TABLES `dba_atividade` WRITE;
/*!40000 ALTER TABLE `dba_atividade` DISABLE KEYS */;
INSERT INTO `dba_atividade` VALUES ('99.99-1','OUTRO TESTE','teste de valores alterados'),('99.99-2','MUDANÇA NO RCP SEM PRIVILÉGIO A TRIGGER','outro valor'),('99.99-7','TESTE','çalksjdfçaksdjfç'),('99.99-9','OUTRAS ATIVIDADES','Atividades não especificadas no código CNAE.\r\nooooooo');
/*!40000 ALTER TABLE `dba_atividade` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dba_atividade_AFTER_INSERT` AFTER INSERT ON `dba_atividade` FOR EACH ROW BEGIN
	INSERT INTO log_rcp.dba_atividade (
		codigo, 
		campo, 
		data_hora, 
		usuario, 
		acao, 
		old_value, 
		new_value)
	VALUES (
		new.atv_codigo, 
		'descricao', 
		now(), 
		@usuario, 
		'1', 
		null, 
		new.atv_descricao);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dba_atividade_AFTER_UPDATE` AFTER UPDATE ON `dba_atividade` FOR EACH ROW BEGIN
	IF old.atv_descricao <> new.atv_descricao THEN
		INSERT INTO log_rcp.dba_atividade (
			codigo, 
			campo, 
			data_hora, 
			usuario, 
			acao, 
			old_value, 
			new_value)
		VALUES (
			new.atv_codigo, 
			'descricao', 
			now(), 
			@usuario, 
			'2', 
			old.atv_descricao, 
			new.atv_descricao);
		END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `dba_empresa`
--

DROP TABLE IF EXISTS `dba_empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dba_empresa` (
  `emp_codigo` smallint(4) NOT NULL AUTO_INCREMENT,
  `emp_nome_formal` varchar(50) NOT NULL,
  `emp_nome_alternativo` varchar(30) DEFAULT NULL,
  `emp_dcriacao` datetime DEFAULT NULL,
  PRIMARY KEY (`emp_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dba_empresa`
--

LOCK TABLES `dba_empresa` WRITE;
/*!40000 ALTER TABLE `dba_empresa` DISABLE KEYS */;
/*!40000 ALTER TABLE `dba_empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dba_ocupacao`
--

DROP TABLE IF EXISTS `dba_ocupacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dba_ocupacao` (
  `ocu_codigo` char(7) NOT NULL,
  `ocu_titulo` varchar(50) DEFAULT NULL,
  `ocu_descricao` blob,
  PRIMARY KEY (`ocu_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dba_ocupacao`
--

LOCK TABLES `dba_ocupacao` WRITE;
/*!40000 ALTER TABLE `dba_ocupacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `dba_ocupacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dba_unidade`
--

DROP TABLE IF EXISTS `dba_unidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `dba_unidade` (
  `uni_empresa` smallint(4) NOT NULL,
  `uni_codigo` smallint(4) NOT NULL,
  `uni_situacao` char(1) NOT NULL DEFAULT '0',
  `uni_nome_unidade` varchar(30) NOT NULL,
  `uni_logradouro` varchar(50) NOT NULL,
  `uni_numero` varchar(10) DEFAULT NULL,
  `uni_complemento` varchar(30) DEFAULT NULL,
  `uni_bairro` varchar(30) DEFAULT NULL,
  `uni_cidade` varchar(50) DEFAULT NULL,
  `uni_estado` varchar(2) DEFAULT NULL,
  `uni_cep` char(9) DEFAULT NULL,
  PRIMARY KEY (`uni_empresa`,`uni_codigo`),
  KEY `fk_dba_unidade_emp_idx` (`uni_empresa`),
  CONSTRAINT `fk_dba_unidade_emp` FOREIGN KEY (`uni_empresa`) REFERENCES `dba_empresa` (`emp_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dba_unidade`
--

LOCK TABLES `dba_unidade` WRITE;
/*!40000 ALTER TABLE `dba_unidade` DISABLE KEYS */;
/*!40000 ALTER TABLE `dba_unidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prm_pessoa`
--

DROP TABLE IF EXISTS `prm_pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `prm_pessoa` (
  `prm_empresa` smallint(4) NOT NULL,
  `prm_codigo` int(7) NOT NULL AUTO_INCREMENT,
  `prm_dcadastro` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `prm_tipo` char(2) NOT NULL,
  `prm_nome_formal` varchar(50) NOT NULL,
  `prm_nome_alternativo` varchar(30) DEFAULT NULL,
  `prm_logradouro` varchar(50) DEFAULT NULL,
  `prm_numero` varchar(10) DEFAULT NULL,
  `prm_complemento` varchar(30) DEFAULT NULL,
  `prm_bairro` varchar(30) DEFAULT NULL,
  `prm_cidade` varchar(50) DEFAULT NULL,
  `prm_estado` char(2) DEFAULT NULL,
  `prm_cep` char(9) DEFAULT NULL,
  `prm_nacionalidade` char(3) DEFAULT NULL,
  `prm_naturalidade` varchar(50) DEFAULT NULL,
  `prm_genero` varchar(10) DEFAULT NULL,
  `prm_orientacao` varchar(15) DEFAULT NULL,
  `prm_estcivil` varchar(15) DEFAULT NULL,
  `prm_federal` varchar(14) DEFAULT NULL,
  `prm_estadual` varchar(25) DEFAULT NULL,
  `prm_municipal` varchar(25) DEFAULT NULL,
  `prm_dcriacao` datetime DEFAULT NULL,
  `prm_cliente` tinyint(1) NOT NULL DEFAULT '0',
  `prm_fornecedor` tinyint(1) NOT NULL DEFAULT '0',
  `prm_parceiro` tinyint(1) NOT NULL DEFAULT '0',
  `prm_transportador` tinyint(1) NOT NULL DEFAULT '0',
  `prm_motorista` tinyint(1) NOT NULL DEFAULT '0',
  `prm_ent_publica` tinyint(1) NOT NULL DEFAULT '0',
  `prm_funcionario` tinyint(1) NOT NULL DEFAULT '0',
  `prm_dependente` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`prm_codigo`,`prm_empresa`),
  KEY `fk_pessoas_emp_idx` (`prm_empresa`),
  CONSTRAINT `fk_pessoas_emp` FOREIGN KEY (`prm_empresa`) REFERENCES `dba_empresa` (`emp_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prm_pessoa`
--

LOCK TABLES `prm_pessoa` WRITE;
/*!40000 ALTER TABLE `prm_pessoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `prm_pessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prm_pessoa_cont`
--

DROP TABLE IF EXISTS `prm_pessoa_cont`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `prm_pessoa_cont` (
  `pco_empresa` smallint(4) NOT NULL,
  `pco_pessoa` int(7) NOT NULL,
  `pco_codigo` smallint(3) NOT NULL,
  `pco_nome` varchar(50) NOT NULL,
  `pco_relacao` varchar(30) NOT NULL,
  `pco_telefone_1` varchar(15) DEFAULT NULL,
  `pco_telefone_2` varchar(15) DEFAULT NULL,
  `pco_email` varchar(256) DEFAULT NULL,
  PRIMARY KEY (`pco_empresa`,`pco_pessoa`,`pco_codigo`),
  KEY `fk_pes_cont_pessoas_idx` (`pco_pessoa`),
  CONSTRAINT `fk_pes_cont_emp` FOREIGN KEY (`pco_empresa`) REFERENCES `dba_empresa` (`emp_codigo`),
  CONSTRAINT `fk_pes_cont_pessoas` FOREIGN KEY (`pco_pessoa`) REFERENCES `prm_pessoa` (`prm_codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prm_pessoa_cont`
--

LOCK TABLES `prm_pessoa_cont` WRITE;
/*!40000 ALTER TABLE `prm_pessoa_cont` DISABLE KEYS */;
/*!40000 ALTER TABLE `prm_pessoa_cont` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sys_user`
--

DROP TABLE IF EXISTS `sys_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `sys_user` (
  `user_id` char(8) NOT NULL,
  `user_nome` varchar(50) NOT NULL,
  `user_email` varchar(256) DEFAULT NULL,
  `user_ativo` tinyint(1) DEFAULT '1',
  `user_dt_cadastro` datetime DEFAULT CURRENT_TIMESTAMP,
  `user_dt_expira` datetime DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sys_user`
--

LOCK TABLES `sys_user` WRITE;
/*!40000 ALTER TABLE `sys_user` DISABLE KEYS */;
INSERT INTO `sys_user` VALUES ('c1442929','FERNANDO BATISTA','fernandovicente.batista@gmail.com',1,'2018-07-09 15:10:02',NULL);
/*!40000 ALTER TABLE `sys_user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-07-25 21:18:46
