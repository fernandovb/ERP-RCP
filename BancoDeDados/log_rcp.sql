-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: log_rcp
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
  `codigo` char(7) NOT NULL,
  `campo` varchar(50) NOT NULL,
  `data_hora` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `usuario` char(32) NOT NULL,
  `acao` char(1) DEFAULT NULL,
  `old_value` varchar(100) DEFAULT NULL,
  `new_value` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dba_atividade`
--

LOCK TABLES `dba_atividade` WRITE;
/*!40000 ALTER TABLE `dba_atividade` DISABLE KEYS */;
INSERT INTO `dba_atividade` VALUES ('99.99-9','descricao','2018-07-25 13:36:20','fernandovb','1',NULL,'ATIVIDADE'),('99.99-9','descricao','2018-07-25 13:40:38','fernandovb','2','ATIVIDADE','OUTRAS ATIVIDADES'),('99.99-1','descricao','2018-07-25 13:52:22','fernandovb','1',NULL,'JAÇKJÇK'),('99.99-2','descricao','2018-07-25 13:52:51','fernandovb','1',NULL,'NOVO TESTE'),('99.99-1','descricao','2018-07-25 13:53:30','fernandovb','2','JAÇKJÇK','OUTRO TESTE'),('99.99-2','descricao','2018-07-25 20:21:53','c1442929','2','NOVO TESTE','MUDANÇA NO DATABASE'),('99.99-2','descricao','2018-07-25 21:01:58','c1442929','2','MUDANÇA NO DATABASE','MUDANÇA NO RCP'),('99.99-2','descricao','2018-07-25 21:03:52','c1442929','2','MUDANÇA NO RCP','MUDANÇA NO RCP SEM PRIVILÉGIO A TRIGGER'),('99.99-7','descricao','2018-07-25 21:15:22','c1442929','1',NULL,'TESTE');
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
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `dba_atividade_BEFORE_INSERT` BEFORE INSERT ON `dba_atividade` FOR EACH ROW BEGIN
	CALL sp_user_corrente(new.usuario);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-07-25 21:18:56
