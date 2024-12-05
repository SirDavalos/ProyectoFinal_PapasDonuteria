-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-12-2024 a las 00:46:43
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `papasdonuteria`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `tipo` int(11) NOT NULL COMMENT 'Aquí indica si es tipo de dona (0), tipo de masa (1), o glaseado (2)',
  `nombre` varchar(50) NOT NULL,
  `imagen` varchar(50) NOT NULL,
  `precio` double NOT NULL,
  `existencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Aquí se almacena los datos de todos los productos disponible';

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `tipo`, `nombre`, `imagen`, `precio`, `existencia`) VALUES
(0, 0, 'Dona de Anillo', 'Regular_Cut.png', 0, 100),
(1, 0, 'Dona Redonda', 'Round_Cutter.png', 0, 100),
(2, 1, 'Regular', 'Regular_Dough.png', 0, 100),
(3, 1, 'Chocolate', 'Chocolate_Dough.png', 0, 100),
(4, 2, 'Azúcar Glas', 'Powdered_Sugar.png', 0, 100),
(5, 2, 'Maple', 'Maple_Icing.png', 0, 100),
(6, 2, 'Clásico', 'Clear_Icing.png', 0, 100),
(7, 2, 'Chocolate', 'Chocolate_Icing.png', 0, 100),
(8, 2, 'Fresa', 'Strawberry_Icing.png', 0, 100),
(9, 2, 'Vainilla', 'Vanilla_Icing.png', 0, 100);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `contraseña` varchar(50) NOT NULL,
  `monto` double NOT NULL,
  `admin` tinyint(1) NOT NULL COMMENT 'Indica si el usuario tiene privilegios de administrados o no'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Esta es la tabla donde se almacenan los usuarios del sistema';

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `contraseña`, `monto`, `admin`) VALUES
(0, 'Administrador', 'SoyElAdmin1234', 0, 1),
(1, 'Elijah Dominguez', 'ContraseñaUsuario1', 0, 0),
(2, 'Fernando Davalos', 'ContraseñaUsuario2', 0, 0),
(3, 'Angel Oziel', 'ContraseñaUsuario3', 0, 0),
(4, 'Hector Guerrero', 'ContraseñaUsuario4', 0, 0),
(5, 'Diego Venegas', 'ContraseñaUsuario5', 0, 0),
(6, 'Invitado', '', 0, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
