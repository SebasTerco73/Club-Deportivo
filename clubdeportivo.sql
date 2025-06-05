-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: localhost    Database: clubdeportivo
-- ------------------------------------------------------
-- Server version	8.0.42

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
  PRIMARY KEY (`idCuota`),
  KEY `codSocio` (`codSocio`),
  CONSTRAINT `cuota_ibfk_1` FOREIGN KEY (`codSocio`) REFERENCES `socios` (`codSocio`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuota`
--

LOCK TABLES `cuota` WRITE;
/*!40000 ALTER TABLE `cuota` DISABLE KEYS */;
INSERT INTO `cuota` VALUES (15,17,'2025-06-01','2025-05-01',5000.00,1,'Efectivo',1),(16,12,'2025-06-30','2025-05-30',5000.00,1,'Efectivo',1),(17,12,'2025-06-30','2025-05-30',5000.00,1,'Efectivo',1),(18,12,'2025-06-30','2025-05-30',5000.00,1,'Efectivo',1),(19,12,'2025-07-05','2025-06-05',5000.00,1,'Efectivo',1),(20,18,'2025-07-05','2025-06-05',5000.00,1,'Tarjeta',6);
/*!40000 ALTER TABLE `cuota` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nosocio_actividad`
--

DROP TABLE IF EXISTS `nosocio_actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosocio_actividad` (
  `idNoSocio` int NOT NULL,
  `idActividad` int NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `fechaRegistro` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`idNoSocio`,`idActividad`),
  KEY `idActividad` (`idActividad`),
  CONSTRAINT `nosocio_actividad_ibfk_1` FOREIGN KEY (`idNoSocio`) REFERENCES `nosocios` (`codNoSocio`),
  CONSTRAINT `nosocio_actividad_ibfk_2` FOREIGN KEY (`idActividad`) REFERENCES `actividad` (`idactividad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocio_actividad`
--

LOCK TABLES `nosocio_actividad` WRITE;
/*!40000 ALTER TABLE `nosocio_actividad` DISABLE KEYS */;
INSERT INTO `nosocio_actividad` VALUES (8,2,'dasd','2025-06-05 16:42:50'),(9,3,'Basquet','2025-06-05 16:45:52');
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosocios`
--

LOCK TABLES `nosocios` WRITE;
/*!40000 ALTER TABLE `nosocios` DISABLE KEYS */;
INSERT INTO `nosocios` VALUES (1,'111','Seqqeq','2025-05-29','1664','2025-05-29',1,1,1),(2,'111222','qqeert','2025-05-29','166441','2025-05-29',1,1,1),(3,'42615619','juan ignacio rodriguez','1990-01-31','11662696496','2025-06-05',1,1,1),(4,'161616','el diablo','1895-07-24','666','2025-06-05',1,1,1),(5,'666','diablilla','2025-06-05','666','2025-06-05',1,1,1),(6,'999','noventay  nueve','2025-06-05','9898','2025-06-05',1,1,1),(7,'46546468','no sepo','2025-06-05','12645','2025-06-05',1,1,1),(8,'123','dasd','2025-06-05','1234','2025-06-05',1,1,1),(9,'456154645','sebas puche','2000-03-01','123456','2025-06-05',1,1,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `socios`
--

LOCK TABLES `socios` WRITE;
/*!40000 ALTER TABLE `socios` DISABLE KEYS */;
INSERT INTO `socios` VALUES (11,'666','Sebas Puche','1993-06-18','1234567890','2025-05-23',1,1,1),(12,'123456','Sebas','2025-05-29','123456','2025-05-29',1,1,1),(13,'1','Seeeeeeeebas','2025-05-29','12456','2025-05-29',0,0,1),(14,'12345566','Sebasty','2025-05-29','123','2025-05-29',1,1,1),(15,'12311111','aaqeqadq','2025-05-29','1234','2025-05-29',1,1,1),(16,'6666','Sergio Orlando','2025-05-29','666','2025-05-29',1,1,1),(17,'123456789','Elisabeth Torner','1990-02-07','1163033656','2025-05-01',1,1,1),(18,'426156126','juan rodriguez','1990-01-31','11662696496','2025-06-05',1,1,1);
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Ailen','1',120,1),(2,'Marcela','1',120,1),(3,'Neyel','1',120,1),(4,'Sebas','1',120,1);
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
/*!50003 DROP PROCEDURE IF EXISTS `ObtenerDetallesNoSocioActividad` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ObtenerDetallesNoSocioActividad`(
    IN p_idNoSocio INT,
    IN p_idActividad INT
)
BEGIN
    SELECT 
        n.NombreCompleto AS NombreNoSocio,
        a.nombre AS NombreActividad,
        na.fechaRegistro
    FROM 
        nosocio n
    JOIN 
        nosocio_actividad na ON n.codNoSocio = na.idNoSocio
    JOIN 
        actividad a ON na.idActividad = a.idActividad
    WHERE 
        n.codNoSocio = p_idNoSocio AND 
        na.idActividad = p_idActividad;
END ;;
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
    IN p_idActividad INT
)
BEGIN
    INSERT INTO nosocio_actividad (idNoSocio, idActividad, nombre, fechaRegistro)
    VALUES (p_idNoSocio, p_idActividad, (SELECT nombre FROM actividad WHERE idactividad = p_idActividad), NOW());
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
/*!50003 DROP PROCEDURE IF EXISTS `RegistrarUser` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegistrarUser`(in Usu varchar(15),in Pass varchar(15))
BEGIN
    -- Validar si el usuario ya existe
    IF NOT EXISTS (
        SELECT 1 FROM usuario WHERE NombreUsu = Usu
    ) THEN
	 -- Insertar nuevo usuario
        INSERT INTO usuario (NombreUsu, PassUsu, RolUsu, Activo)
        VALUES (Usu, Pass, 120, 1);
    END IF;
end ;;
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

-- Dump completed on 2025-06-05 16:56:25
