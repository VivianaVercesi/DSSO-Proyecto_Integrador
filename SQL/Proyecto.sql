-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2023 at 03:54 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `proyecto`
--

CREATE DATABASE IF NOT EXISTS `proyecto` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `proyecto`;

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `BuscarClientePorId` (IN `Id` INT)   BEGIN
SELECT * FROM cliente
WHERE id = idCliente;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CrearCliente` (IN `DNI` VARCHAR(10), IN `Nombre` VARCHAR(50), IN `Apellido` VARCHAR(50), IN `Tipo` VARCHAR(50), OUT `id` INT)   BEGIN
	DECLARE existe INT DEFAULT 0;
	SET existe = (SELECT count(*) from cliente where dniCliente = DNI);
	IF existe = 0 THEN
		INSERT INTO cliente (dniCliente, nombreCliente, apellidoCliente,tipoCliente) VALUES (DNI, Nombre, Apellido, Tipo);
		set id = (select max(idCliente) from cliente);
	ELSE SET id = -1;
	END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CrearPago` (IN `Id` INT, IN `Monto` INT, IN `Tipo` VARCHAR(10), OUT `ID_Pago` INT, IN `Fecha` DATE)   BEGIN
	DECLARE existe INT DEFAULT 0;
	SET existe = (SELECT count(*) from cliente where idCliente = Id);
	IF existe = 1 THEN
		INSERT INTO pago (idCliente, monto, fecha, tipo) VALUES (Id, Monto, Fecha, Tipo);
		SET ID_Pago = (select max(idPago) from pago);
	ELSE SET 
                ID_Pago = -1;
	END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CrearUsuario` (IN `Usu` VARCHAR(30), IN `Pass` VARCHAR(30), IN `Rol` INT)   BEGIN
  INSERT INTO usuario (usuario, clave, RolUsu, Activo) VALUES (Usu, Pass, Rol, 1);
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin` (IN `Usu` VARCHAR(30), IN `Pass` VARCHAR(30))   begin
 select NomRol
	from usuario u inner join roles r on u.RolUsu = r.RolUsu
		where usuario = Usu and clave = Pass 
			and Activo = 1 ;
end$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `VencimientosDiarios` ()   BEGIN
    DECLARE fecha_actual DATE;
    DECLARE fecha_anterior DATE;

    -- Obtener la fecha actual
    SET fecha_actual = CURDATE();

    -- Calcular la fecha anterior
    SET fecha_anterior = DATE_SUB(fecha_actual, INTERVAL 30 DAY);

    -- Consulta para obtener los registros
    SELECT nombreCliente as Nombre, apellidoCliente as Apellido, c.idCliente as id, monto as Monto
    FROM cliente c
    JOIN pago p
    WHERE DATE_FORMAT(fecha, '%d-%m') = DATE_FORMAT(fecha_anterior, '%d-%m')
    AND tipo = "cuota"
    AND c.idCliente = p.idCliente;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `cliente`
--

CREATE TABLE `cliente` (
  `idCliente` int(11) NOT NULL,
  `dniCliente` varchar(10) DEFAULT NULL,
  `nombreCliente` varchar(50) DEFAULT NULL,
  `apellidoCliente` varchar(50) DEFAULT NULL,
  `tipoCliente` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cliente`
--

INSERT INTO `cliente` (`idCliente`, `dniCliente`, `nombreCliente`, `apellidoCliente`, `tipoCliente`) VALUES
(1, '34389692', 'Carlos', 'Garcia', 'Socio'),
(2, '34389693', 'Luis Alberto', 'Spinetta', 'Socio'),
(3, '34389687', 'Pedro', 'Aznar', 'Socio'),
(4, '38389672', 'Carlos', 'Solari', 'Socio'),
(5, '42389672', 'Fabiana', 'Cantilo', 'Socio'),
(6, '42159672', 'Rodolfo', 'Paez', 'Socio'),
(7, '42159678', 'Hilda', 'Lizarazu', 'Socio');

-- --------------------------------------------------------

--
-- Table structure for table `pago`
--

CREATE TABLE `pago` (
  `idPago` int(11) NOT NULL,
  `idCliente` int(11) DEFAULT NULL,
  `monto` int(11) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `tipo` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pago`
--

INSERT INTO `pago` (`idPago`, `idCliente`, `monto`, `fecha`, `tipo`) VALUES
(1, 1, 123, '2023-11-22', 'cuota'),
(2, 1, 333, '2023-11-22', 'unico'),
(3, 1, 444, '2023-11-22', 'unico'),
(4, 1, 555, '2023-11-22', 'unico'),
(5, 4, 444, '2023-11-22', 'cuota'),
(6, 1, 34534, DATE_SUB(CURDATE(), INTERVAL 30 DAY), 'cuota'),
(7, 5, 213, DATE_SUB(CURDATE(), INTERVAL 30 DAY), 'cuota'),
(8, 1, 100, '2023-11-23', 'unico'),
(9, 1, 987, '2023-11-23', 'unico'),
(10, 6, 133, DATE_SUB(CURDATE(), INTERVAL 30 DAY), 'cuota'),
(11, 1, 1231, '2023-11-27', 'unico'),
(12, 1, 123, '2023-11-27', 'unico');

-- --------------------------------------------------------

--
-- Table structure for table `roles`
--

CREATE TABLE `roles` (
  `RolUsu` int(11) NOT NULL,
  `NomRol` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `roles`
--

INSERT INTO `roles` (`RolUsu`, `NomRol`) VALUES
(120, 'Administrador'),
(121, 'Empleado');

-- --------------------------------------------------------

--
-- Table structure for table `usuario`
--

CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL,
  `usuario` varchar(30) DEFAULT NULL,
  `clave` varchar(30) DEFAULT NULL,
  `RolUsu` int(11) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `usuario`
--

INSERT INTO `usuario` (`idUsuario`, `usuario`, `clave`, `RolUsu`, `Activo`) VALUES
(1, 'admin', '1234', 120, 1),
(2, 'administra', '12345', 120, 1),
(3, 'adm', '1234', 120, 1),
(4, 'administrador1', '123456', 120, 1),
(5, 'administrador2', '123456', 120, 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`idCliente`);

--
-- Indexes for table `pago`
--
ALTER TABLE `pago`
  ADD PRIMARY KEY (`idPago`),
  ADD KEY `fk_cuota` (`idCliente`);

--
-- Indexes for table `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`RolUsu`);

--
-- Indexes for table `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`idUsuario`),
  ADD KEY `fk_usuario` (`RolUsu`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cliente`
--
ALTER TABLE `cliente`
  MODIFY `idCliente` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `pago`
--
ALTER TABLE `pago`
  MODIFY `idPago` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `usuario`
--
ALTER TABLE `usuario`
  MODIFY `idUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsu`) REFERENCES `roles` (`RolUsu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
