-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 31-07-2022 a las 00:50:17
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `eval4_db`
--

--
-- Volcado de datos para la tabla `autor`
--

INSERT INTO `autor` (`Id`, `Nombre`, `FechaNacimiento`, `EstaVivo`) VALUES
(1, 'Mario Vargas Llosa', '1936-03-28', 1),
(2, 'Gabriel García Márquez', '1927-03-06', 0),
(3, 'Paulo Coelho', '1947-08-24', 1),
(4, 'Charles Dickens', '1812-02-07', 0);

--
-- Volcado de datos para la tabla `libro`
--

INSERT INTO `libro` (`Id`, `AutorId`, `Titulo`, `Paginas`) VALUES
(1, 1, 'Conversación en La Catedral', 736),
(2, 1, 'Pantaleon y las visitadoras VOL2', 600),
(3, 1, 'La guerra del fin del mundo', 720),
(4, 1, 'La verdad de las mentiras', 316),
(5, 1, 'La fiesta del chivo', 520),
(6, 1, 'El Paraíso en la otra esquina', 528),
(7, 1, 'El sueño del celta', 464),
(8, 1, 'Conversación en Princeton', 288),
(9, 2, 'Cien años de soledad', 496),
(10, 2, 'El amor en los tiempos del cólera', 461),
(11, 2, 'Crónica de una muerte anunciada ', 128),
(12, 2, 'El coronel no tiene quien le escriba', 112),
(13, 2, 'La hojarasca ', 144),
(14, 2, 'Relato De Un Naufrago ', 176),
(15, 2, 'El otoño del patriarca', 304),
(16, 2, 'Doce cuentos peregrinos', 192),
(17, 3, 'El Don Supremo ', 128),
(18, 3, 'Aleph', 288),
(19, 3, 'Manual del guerrero de la luz', 149),
(20, 3, 'Once minutos', 304),
(21, 3, 'El manuscrito encontrado en Accra ', 192),
(22, 3, 'Adulterio', 304),
(23, 3, 'El Alquimista', 192),
(24, 4, 'Canción de Navidad ', 128),
(25, 4, 'David Copperfield', 1024),
(26, 4, 'Oliver Twist', 608),
(27, 4, 'Tiempos Difíciles', 281),
(28, 4, 'Cancion De Nadal', 64),
(29, 4, 'Grandes esperanzas', 308);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
