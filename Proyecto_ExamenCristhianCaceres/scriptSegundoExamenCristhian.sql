CREATE SCHEMA IF NOT EXISTS `Examen_CristhianCaceres` DEFAULT CHARACTER SET utf8 ;
USE `Examen_CristhianCaceres` ;


CREATE TABLE IF NOT EXISTS `Examen_CristhianCaceres`.`clientes` (
  `Identidad` varchar(40) NOT NULL,
  `Nombre` varchar(75) DEFAULT NULL,
  `Direccion` varchar(120) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  constraint PK_clientes_Identidad
  PRIMARY KEY (`Identidad`)
);



LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;


CREATE TABLE IF NOT EXISTS `Examen_CristhianCaceres`.`ticket` (
  `Id` int NOT NULL ,
  `Fecha` datetime DEFAULT NULL,
  `IdentidadCliente` varchar(40) DEFAULT NULL,
  `NombreCliente` varchar(45) DEFAULT NULL,
  `TipoSoporte` varchar(75) DEFAULT NULL,
  `TipoEquipo` varchar(75) DEFAULT NULL,
  `DescripcionProblema` varchar(120) DEFAULT NULL,
  `DescripcionSolucion` varchar(120) DEFAULT NULL,
  `Costo` decimal(8,2) DEFAULT NULL,
  constraint PK_ticket_Id PRIMARY KEY (`Id`)
 -- constraint FK_ticket_clientes
 -- FOREIGN KEY (`IdentidadCliente`) REFERENCES clientes(`Identidad`)
);


--
-- Dumping data for table `ticket`
--

LOCK TABLES `ticket` WRITE;
/*!40000 ALTER TABLE `ticket` DISABLE KEYS */;
/*!40000 ALTER TABLE `ticket` ENABLE KEYS */;
UNLOCK TABLES;


CREATE TABLE IF NOT EXISTS `Examen_CristhianCaceres`.`usuarios` (
  `Codigo` varchar(30) NOT NULL,
  `Nombre` varchar(60) NOT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Clave` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB;




LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES 
('Mlopez','Mario Lopez','mariol13@gmail.com','2025'),
('Bduron','Brayan','brayanduron@gmail.com','4321'),
('ccaceres','Cristhian','Caceres','1234');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;



CREATE TABLE IF NOT EXISTS `Examen_CristhianCaceres`.`tipos` (
  `Cod` varchar(30) NOT NULL,
  `Nombre` varchar(60) NOT NULL,
  PRIMARY KEY (`Cod`)
)

