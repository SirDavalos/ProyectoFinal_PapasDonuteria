-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-12-2024 a las 05:15:08
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
  `descripcion` varchar(250) NOT NULL,
  `precio` double NOT NULL,
  `existencia` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Aquí se almacena los datos de todos los productos disponible';

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `tipo`, `nombre`, `imagen`, `descripcion`, `precio`, `existencia`) VALUES
(0, 0, 'Dona de Anillo', 'Regular_Cut.png', 'Corte de anillo de dona tipico. Un circulo sin centro.', 7, 100),
(1, 0, 'Dona Redonda', 'Round_Cutter.png', 'Corte de dona completamente redondo. Circulo de dona que incluye el centro.', 8, 100),
(2, 1, 'Regular', 'Regular_Dough.png', 'Masa de dona regular, sabor natural.', 1, 100),
(3, 1, 'Chocolate', 'Chocolate_Dough.png', 'Masa de dona sabor chocolate.', 1.2, 100),
(4, 2, 'Azúcar Glas', 'Powdered_Sugar.png', 'Azucar Glas. Se espolvorea sobre la dona para darle sabor. ', 1.5, 100),
(5, 2, 'Maple', 'Maple_Icing.png', 'Jarabe de maple. Se cubre la parte superior de la dona con el jarabe.', 2.4, 100),
(6, 2, 'Clásico', 'Clear_Icing.png', 'Icing o cubiera de glaseado de azucar tipico. ', 1.5, 100),
(7, 2, 'Chocolate', 'Chocolate_Icing.png', 'Icing o cubierta de glaseado de chocolate.', 2, 100),
(8, 2, 'Fresa', 'Strawberry_Icing.png', 'Icing o cubierta de glaseado de fresa.', 2, 100),
(9, 2, 'Vainilla', 'Vanilla_Icing.png', 'Icing o cubierta de glaseado de fresa.', 1.5, 100);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `cuenta` varchar(50) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  `monto` double NOT NULL,
  `admin` tinyint(1) NOT NULL COMMENT 'Indica si el usuario tiene privilegios de administrados o no'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci COMMENT='Esta es la tabla donde se almacenan los usuarios del sistema';

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id`, `nombre`, `cuenta`, `contraseña`, `monto`, `admin`) VALUES
(0, 'Administrador', 'admin', 'SoyElAdmin1234', 0, 1),
(1, 'Elijah Dominguez', 'elijah', 'ContraseñaUsuario1', 0, 0),
(2, 'Fernando Davalos', 'fernando', 'ContraseñaUsuario2', 0, 0),
(3, 'Angel Oziel', 'oziboy', 'ContraseñaUsuario3', 51, 0),
(4, 'Hector Guerrero', 'hector', 'ContraseñaUsuario4', 0, 0),
(5, 'Diego Venegas', 'diego', 'ContraseñaUsuario5', 0, 0),
(6, 'Invitado', 'invitado', '', 0, 0);

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
