-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 12-06-2024 a las 19:46:20
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
-- Base de datos: `texturas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `texturas`
--

CREATE TABLE `texturas` (
  `p_color` text NOT NULL,
  `p_r` int(11) NOT NULL,
  `p_g` int(11) NOT NULL,
  `p_b` int(11) NOT NULL,
  `s_color` text NOT NULL,
  `s_r` int(11) NOT NULL,
  `s_g` int(11) NOT NULL,
  `s_b` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `texturas`
--

INSERT INTO `texturas` (`p_color`, `p_r`, `p_g`, `p_b`, `s_color`, `s_r`, `s_g`, `s_b`) VALUES
('Celeste 1', 154, 217, 234, 'Naranja', 255, 165, 0),
('Verde 1', 35, 177, 77, 'Morado', 128, 0, 128),
('Verde 2', 151, 201, 0, 'Turquesa', 64, 224, 208),
('Verde 3', 0, 128, 0, 'Rosa', 255, 0, 255),
('Verde 4', 0, 255, 100, 'Gris', 128, 128, 128),
('Celeste 2', 0, 255, 255, 'Salmon', 250, 128, 114),
('Celeste 3', 0, 204, 255, 'Marrón', 139, 69, 19),
('Celeste 4', 127, 255, 255, 'Oro', 255, 215, 0),
('Celeste 5', 0, 128, 255, 'Beige', 245, 245, 220),
('Blanco', 255, 255, 255, 'Negro', 0, 0, 0),
('Rojo 1', 255, 0, 0, 'Amarillo', 233, 255, 72),
('Rojo 2', 204, 0, 0, 'Cyan', 0, 255, 255);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
