CREATE DATABASE  IF NOT EXISTS `clubdeportivo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `clubdeportivo`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: clubdeportivo
-- ------------------------------------------------------
-- Server version	8.0.35

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `actividad`
--

DROP TABLE IF EXISTS `actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actividad` (
  `idactividad` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `cupoMax` int DEFAULT '30',
  `cupoActual` int DEFAULT '30',
  `valor` double DEFAULT NULL,
  PRIMARY KEY (`idactividad`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actividad`
--

LOCK TABLES `actividad` WRITE;
/*!40000 ALTER TABLE `actividad` DISABLE KEYS */;
INSERT INTO `actividad` VALUES (1,'Futbol',25,25,5000),(2,'Natacion',20,20,5000),(3,'Basquet',25,25,4000);
/*!40000 ALTER TABLE `actividad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cuota`
--

DROP TABLE IF EXISTS `cuota`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuota` (
  `idCuota` int NOT NULL AUTO_INCREMENT,
  `codSocio` int DEFAULT NULL,
  `fechaVencimiento` date DEFAULT NULL,
  `fechaPago` date DEFAULT NULL,
  `monto` decimal(10,2) DEFAULT NULL,
  `estadoPago` tinyint DEFAULT '0',
  `medioPago` varchar(30) DEFAULT NULL,
  `cantCuota` int DEFAULT '1',
  `ultimoPago` tinyint NOT NULL DEFAULT '1',
  PRIMARY KEY (`idCuota`),
  KEY `codSocio` (`codSocio`),
  CONSTRAINT `cuota_ibfk_1` FOREIGN KEY (`codSocio`) REFERENCES `socios` (`codSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuota`
--

LOCK TABLES `cuota` WRITE;
/*!40000 ALTER TABLE `cuota` DISABLE KEYS */;
INSERT INTO `cuota` VALUES (24,23,'2025-07-07','2025-06-07',5000.00,1,'Efectivo',1,0),(25,24,'2025-07-07','2025-06-07',5000.00,1,'Tarjeta',3,1),(26,25,'2025-07-07','2025-06-07',5000.00,1,'Efectivo',1,1),(27,26,'2025-07-07','2025-06-07',5000.00,1,'Tarjeta',6,1),(28,27,'2025-07-07','2025-06-07',5000.00,1,'Tarjeta',2,1),(29,23,'2025-08-07','2025-06-08',5000.00,1,'Tarjeta',1,0),(30,23,'2025-09-07','2025-06-08',5000.00,1,'Efectivo',1,1),(31,28,'2025-07-14','2025-06-14',5000.00,1,'Efectivo',1,1),(32,29,'2025-06-15','2025-05-15',5000.00,1,'Tarjeta',3,1),(33,30,'2025-06-20','2025-05-20',5000.00,1,'Tarjeta',3,1),(34,31,'2025-06-16','2025-05-16',5000.00,1,'Efectivo',1,1),(35,32,'2025-06-16','2025-05-16',5000.00,1,'Tarjeta',6,1),(36,33,'2025-07-19','2025-06-19',5000.00,1,'Efectivo',1,1),(37,34,'2025-06-17','2025-05-17',5000.00,1,'Tarjeta',1,1);
/*!40000 ALTER TABLE `cuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nosocio_actividad`
--

DROP TABLE IF EXISTS `nosocio_actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocio_actividad` (
  `idPagoActividad` int NOT NULL AUTO_INCREMENT,
  `idNoSocio` int NOT NULL,
  `idActividad` int NOT NULL,
  `fechaRegistro` datetime NOT NULL,
  `fechaVenci` datetime NOT NULL,
  `estado` tinyint NOT NULL,
  `nombreAct` varchar(45) NOT NULL,
  PRIMARY KEY (`idPagoActividad`),
  KEY `fk_nosocioactividad_nosocio` (`idNoSocio`),
  KEY `fk_nosocioactividad_actividad` (`idActividad`),
  CONSTRAINT `fk_nosocioactividad_actividad` FOREIGN KEY (`idActividad`) REFERENCES `actividad` (`idactividad`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_nosocioactividad_nosocio` FOREIGN KEY (`idNoSocio`) REFERENCES `nosocios` (`codNoSocio`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocio_actividad`
--

LOCK TABLES `nosocio_actividad` WRITE;
/*!40000 ALTER TABLE `nosocio_actividad` DISABLE KEYS */;
INSERT INTO `nosocio_actividad` VALUES (1,18,2,'2025-06-07 21:37:20','2025-06-08 21:37:20',1,'Natacion'),(2,18,2,'2025-06-07 23:02:15','2025-06-08 23:02:15',1,'Natacion'),(3,19,1,'2025-06-08 00:35:19','2025-06-09 00:35:19',1,'Futbol'),(4,20,3,'2025-06-08 00:37:25','2025-06-09 00:37:25',1,'Basquet'),(5,20,3,'2025-06-08 01:14:58','2025-06-09 01:14:58',1,'Basquet'),(6,20,3,'2025-06-08 01:16:51','2025-06-09 01:16:51',1,'Basquet');
/*!40000 ALTER TABLE `nosocio_actividad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nosocios`
--

DROP TABLE IF EXISTS `nosocios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocios` (
  `codNoSocio` int NOT NULL AUTO_INCREMENT,
  `Documento` varchar(12) NOT NULL,
  `NombreCompleto` varchar(45) NOT NULL,
  `FechaNac` date NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `FechaInscripcion` date NOT NULL,
  `FichaMedica` tinyint DEFAULT '0',
  `AptoMedico` tinyint DEFAULT '0',
  `activo` tinyint DEFAULT '1',
  PRIMARY KEY (`codNoSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocios`
--

LOCK TABLES `nosocios` WRITE;
/*!40000 ALTER TABLE `nosocios` DISABLE KEYS */;
INSERT INTO `nosocios` VALUES (18,'35593201','pipi lulu','2025-06-07','1111111','2025-06-07',1,1,1),(19,'36998888','Luciana Aimar','1990-10-27','1566666','2025-06-08',1,1,1),(20,'37996999','Ivana Gomez','2003-06-11','15242424','2025-06-08',1,1,1);
/*!40000 ALTER TABLE `nosocios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `RolUsu` int NOT NULL,
  `NomRol` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`RolUsu`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (120,'Administrador'),(121,'Empleado');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `socios`
--

DROP TABLE IF EXISTS `socios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `socios` (
  `codSocio` int NOT NULL AUTO_INCREMENT,
  `Documento` varchar(12) NOT NULL,
  `NombreCompleto` varchar(45) NOT NULL,
  `FechaNac` date NOT NULL,
  `Telefono` varchar(15) NOT NULL,
  `FechaInscripcion` date NOT NULL,
  `FichaMedica` tinyint DEFAULT '0',
  `AptoMedico` tinyint DEFAULT '0',
  `activo` tinyint DEFAULT '1',
  PRIMARY KEY (`codSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socios`
--

LOCK TABLES `socios` WRITE;
/*!40000 ALTER TABLE `socios` DISABLE KEYS */;
INSERT INTO `socios` VALUES (23,'38765432','Ana Laura González','1995-03-15','2235432109','2025-06-07',1,0,1),(24,'40123456','Martín Pérez','1999-07-22',' 2236789012','2025-06-07',1,1,1),(25,'35987654','Sofía Rodríguez','1990-11-05','112345678','2025-06-07',1,1,1),(26,'42000000','Lautaro Sánchez','2003-01-01','223 789-0123','2025-06-07',0,0,1),(27,'37555888','Florencia Gómez','1994-09-18','2231123344','2025-06-07',0,1,1),(28,'7899945','Daniel Perez','1934-06-05','15587999','2025-06-14',1,1,1),(29,'1258889','Laura Lauro','2001-05-15','20999355','2025-05-15',1,1,1),(30,'15299633','Ariana Montes','2003-11-20','152230300','2025-05-20',1,0,1),(31,'25399265','Lucas Mendez','2005-09-30','2944556325','2025-05-16',0,0,1),(32,'36999288','Gimena Serrano','1991-03-03','15228974','2025-05-16',1,1,1),(33,'22119222','Marina Tritón','1971-11-02','15299888','2025-06-19',1,1,1),(34,'49669857','Jeremias Springfield','2000-03-03','152222222','2025-05-17',1,1,1);
/*!40000 ALTER TABLE `socios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `CodUsu` int NOT NULL AUTO_INCREMENT,
  `NombreUsu` varchar(20) NOT NULL,
  `PassUsu` varchar(15) NOT NULL,
  `RolUsu` int DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`CodUsu`),
  UNIQUE KEY `NombreUsu_UNIQUE` (`NombreUsu`),
  KEY `fk_usuario` (`RolUsu`),
  CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsu`) REFERENCES `roles` (`RolUsu`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Ailen','1',120,1),(2,'Marcela','1',120,1),(3,'Neyel','1',120,1),(4,'Sebas','1',120,1),(5,'Silvia','1',120,1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'clubdeportivo'
--
/*!50003 DROP PROCEDURE IF EXISTS `IngresoLogin` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin`(in Usu varchar(20),in Pass varchar(15))
begin
  
  select NomRol	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where NombreUsu = Usu and BINARY PassUsu = Pass /* se compara con los parametros */
			and Activo = 1; /* el usuario debe estar activo */

end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `registrarNoSocio` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarNoSocio`(
    IN s_Documento VARCHAR(12),
    IN s_NombreCompleto VARCHAR(45),
    IN s_FechaNac DATE,
    IN s_Telefono VARCHAR(15),
    IN s_FechaInscripcion DATE,
    IN s_FichaMedica TINYINT,
    IN s_AptoMedico TINYINT,
    OUT rta INT
)
BEGIN
    DECLARE existe INT DEFAULT 0;

    -- Verificamos si ya existe un socio con ese documento
    SELECT COUNT(*) INTO existe FROM nosocios WHERE Documento = s_Documento;

    IF existe = 0 THEN
        -- No existe, insertamos el nuevo socio
        INSERT INTO nosocios (
            Documento, NombreCompleto, FechaNac, Telefono,
            FechaInscripcion, FichaMedica, AptoMedico, activo
        ) VALUES (
            s_Documento, s_NombreCompleto, s_FechaNac, s_Telefono,
            s_FechaInscripcion, s_FichaMedica, s_AptoMedico, 1
        );

        SET rta = LAST_INSERT_ID();
    ELSE
        -- Ya existe, devolvemos -1
        SET rta = -1;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `RegistrarNoSocioActividad` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarNoSocioActividad`(
    IN p_idNoSocio INT,
    IN p_idActividad INT,
    IN p_fechaRegistro DATETIME
)
BEGIN
    INSERT INTO nosocio_actividad (
        idNoSocio,
        idActividad,
        fechaRegistro,
        fechaVenci,
        estado,
        nombreAct
    )
    VALUES (
        p_idNoSocio,
        p_idActividad,
        p_fechaRegistro,
        DATE_ADD(p_fechaRegistro, INTERVAL 1 DAY),
        TRUE,
        (SELECT nombre FROM actividad WHERE idactividad = p_idActividad)
    );
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `registrarSocio` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `registrarSocio`(
    IN s_Documento VARCHAR(12),
    IN s_NombreCompleto VARCHAR(45),
    IN s_FechaNac DATE,
    IN s_Telefono VARCHAR(15),
    IN s_FechaInscripcion DATE,
    IN s_FichaMedica TINYINT,
    IN s_AptoMedico TINYINT,
    OUT rta INT
)
BEGIN
    DECLARE existe INT DEFAULT 0;

    -- Verificamos si ya existe un socio con ese documento
    SELECT COUNT(*) INTO existe FROM socios WHERE Documento = s_Documento;

    IF existe = 0 THEN
        -- No existe, insertamos el nuevo socio
        INSERT INTO socios (
            Documento, NombreCompleto, FechaNac, Telefono,
            FechaInscripcion, FichaMedica, AptoMedico, activo
        ) VALUES (
            s_Documento, s_NombreCompleto, s_FechaNac, s_Telefono,
            s_FechaInscripcion, s_FichaMedica, s_AptoMedico, 1
        );

        SET rta = LAST_INSERT_ID();
    ELSE
        -- Ya existe, devolvemos -1
        SET rta = -1;
    END IF;
END ;;
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

-- Dump completed on 2025-06-20 13:06:29
