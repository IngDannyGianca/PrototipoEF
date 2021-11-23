-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 23-11-2021 a las 18:06:38
-- Versión del servidor: 10.4.21-MariaDB
-- Versión de PHP: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sic`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `bodegas`
--

CREATE TABLE `bodegas` (
  `codigo_bodega` varchar(5) NOT NULL,
  `nombre_bodega` varchar(60) DEFAULT NULL,
  `estatus_bodega` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `bodegas`
--

INSERT INTO `bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES
('1', 'Las palmas', '1'),
('2', 'Las Manos', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `codigo_cliente` varchar(5) NOT NULL,
  `nombre_cliente` varchar(60) DEFAULT NULL,
  `direccion_cliente` varchar(60) DEFAULT NULL,
  `nit_cliente` varchar(20) DEFAULT NULL,
  `telefono_cliente` varchar(50) DEFAULT NULL,
  `codigo_vendedor` varchar(5) DEFAULT NULL,
  `estatus_cliente` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`codigo_cliente`, `nombre_cliente`, `direccion_cliente`, `nit_cliente`, `telefono_cliente`, `codigo_vendedor`, `estatus_cliente`) VALUES
('1', 'Pedro', 'Casa', '123456', '12345689', '1', '1'),
('2', 'Juan', 'xxx', '123456', '12345689', '1', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras_detalle`
--

CREATE TABLE `compras_detalle` (
  `documento_compraenca` varchar(10) NOT NULL,
  `codigo_producto` varchar(18) NOT NULL,
  `cantidad_compradet` float(10,2) DEFAULT NULL,
  `costo_compradet` float(10,2) DEFAULT NULL,
  `codigo_bodega` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `compras_detalle`
--

INSERT INTO `compras_detalle` (`documento_compraenca`, `codigo_producto`, `cantidad_compradet`, `costo_compradet`, `codigo_bodega`) VALUES
('8', '1', 1.00, 1.00, '1'),
('8', '2', 1.00, 1.00, '1'),
('3', '2', 1.00, 1.00, '1'),
('3', '2', 1.00, 1.00, '1'),
('5', '3', 1.00, 1.00, '1'),
('7', '2', 1.00, 1.00, '1'),
('7', '3', 1.00, 1.00, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras_encabezado`
--

CREATE TABLE `compras_encabezado` (
  `documento_compraenca` varchar(10) NOT NULL,
  `codigo_proveedor` varchar(5) DEFAULT NULL,
  `fecha_compraenca` date DEFAULT NULL,
  `total_compraenca` float(10,2) DEFAULT NULL,
  `estatus_compraenca` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `compras_encabezado`
--

INSERT INTO `compras_encabezado` (`documento_compraenca`, `codigo_proveedor`, `fecha_compraenca`, `total_compraenca`, `estatus_compraenca`) VALUES
('1', '1', '2006-09-28', 1000.00, '1'),
('3', '1', '2021-09-28', 500.00, '1'),
('5', '1', '2021-09-28', 500.00, '1'),
('7', '1', '2021-09-28', 500.00, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `existencias`
--

CREATE TABLE `existencias` (
  `codigo_bodega` varchar(5) NOT NULL,
  `codigo_producto` varchar(18) NOT NULL,
  `saldo_existencia` float(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `existencias`
--

INSERT INTO `existencias` (`codigo_bodega`, `codigo_producto`, `saldo_existencia`) VALUES
('1', '1', 500.00);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lineas`
--

CREATE TABLE `lineas` (
  `codigo_linea` varchar(5) NOT NULL,
  `nombre_linea` varchar(60) DEFAULT NULL,
  `estatus_linea` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `lineas`
--

INSERT INTO `lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES
('1', 'Jordan', '0'),
('2', 'Hello', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `marcas`
--

CREATE TABLE `marcas` (
  `codigo_marca` varchar(5) NOT NULL,
  `nombre_marca` varchar(60) DEFAULT NULL,
  `estatus_marca` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `marcas`
--

INSERT INTO `marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES
('1', 'Nike', '1'),
('2', 'Adida', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `codigo_producto` varchar(18) NOT NULL,
  `nombre_producto` varchar(60) DEFAULT NULL,
  `codigo_linea` varchar(5) DEFAULT NULL,
  `codigo_marca` varchar(5) DEFAULT NULL,
  `precio_producto` float(10,2) DEFAULT NULL,
  `estatus_producto` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `precio_producto`, `estatus_producto`) VALUES
('1', 'Macetas', '1', '1', 150.00, '1'),
('2', 'Abono', '1', '1', 150.00, '1'),
('3', 'Kit Manejo de cultivo', '1', '1', 150.00, '1'),
('4', 'Pelotas', '2', '2', 200.00, '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `codigo_proveedor` varchar(5) NOT NULL,
  `nombre_proveedor` varchar(60) DEFAULT NULL,
  `direccion_proveedor` varchar(60) DEFAULT NULL,
  `telefono_proveedor` varchar(50) DEFAULT NULL,
  `nit_proveedor` varchar(50) DEFAULT NULL,
  `estatus_proveedor` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`, `estatus_proveedor`) VALUES
('1', 'Andre', 'Casa de Andres', '12345678', '1234', '1'),
('2', 'Juan', 'Casa de Juan', '1234', '4321', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipomovimiento`
--

CREATE TABLE `tipomovimiento` (
  `codigo_tipomovimiento` varchar(5) NOT NULL,
  `nombre_tipomovimiento` varchar(60) DEFAULT NULL,
  `estatus_tipomovimiento` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tipomovimiento`
--

INSERT INTO `tipomovimiento` (`codigo_tipomovimiento`, `nombre_tipomovimiento`, `estatus_tipomovimiento`) VALUES
('1', 'Venta', '1'),
('2', 'Compra', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE `usuario` (
  `codigo_usuario` varchar(5) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `contrasena` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `vendedores`
--

CREATE TABLE `vendedores` (
  `codigo_vendedor` varchar(5) NOT NULL,
  `nombre_vendedor` varchar(60) DEFAULT NULL,
  `direccion_vendedor` varchar(60) DEFAULT NULL,
  `telefono_vendedor` varchar(50) DEFAULT NULL,
  `nit_vendedor` varchar(20) DEFAULT NULL,
  `estatus_vendedor` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `vendedores`
--

INSERT INTO `vendedores` (`codigo_vendedor`, `nombre_vendedor`, `direccion_vendedor`, `telefono_vendedor`, `nit_vendedor`, `estatus_vendedor`) VALUES
('1', 'Marco', 'Casa de Marco', '12345678', '1234', '1');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_detalle`
--

CREATE TABLE `ventas_detalle` (
  `documento_ventaenca` varchar(10) NOT NULL,
  `codigo_producto` varchar(18) NOT NULL,
  `cantidad_ventadet` float(10,2) DEFAULT NULL,
  `costo_ventadet` float(10,2) DEFAULT NULL,
  `precio_ventadet` float(10,2) DEFAULT NULL,
  `codigo_bodega` varchar(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas_encabezado`
--

CREATE TABLE `ventas_encabezado` (
  `documento_ventaenca` varchar(10) NOT NULL,
  `codigo_cliente` varchar(5) DEFAULT NULL,
  `fecha_ventaenca` date DEFAULT NULL,
  `total_ventaenca` float(10,2) DEFAULT NULL,
  `estatus_ventaenca` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ventas_encabezado`
--

INSERT INTO `ventas_encabezado` (`documento_ventaenca`, `codigo_cliente`, `fecha_ventaenca`, `total_ventaenca`, `estatus_ventaenca`) VALUES
('1', '1', '2021-12-23', 300.00, '1');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `bodegas`
--
ALTER TABLE `bodegas`
  ADD PRIMARY KEY (`codigo_bodega`);

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`codigo_cliente`),
  ADD KEY `codigo_vendedor` (`codigo_vendedor`);

--
-- Indices de la tabla `compras_detalle`
--
ALTER TABLE `compras_detalle`
  ADD KEY `codigo_producto` (`codigo_producto`),
  ADD KEY `codigo_bodega` (`codigo_bodega`);

--
-- Indices de la tabla `compras_encabezado`
--
ALTER TABLE `compras_encabezado`
  ADD PRIMARY KEY (`documento_compraenca`),
  ADD KEY `codigo_proveedor` (`codigo_proveedor`);

--
-- Indices de la tabla `existencias`
--
ALTER TABLE `existencias`
  ADD PRIMARY KEY (`codigo_bodega`,`codigo_producto`),
  ADD KEY `codigo_producto` (`codigo_producto`);

--
-- Indices de la tabla `lineas`
--
ALTER TABLE `lineas`
  ADD PRIMARY KEY (`codigo_linea`);

--
-- Indices de la tabla `marcas`
--
ALTER TABLE `marcas`
  ADD PRIMARY KEY (`codigo_marca`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`codigo_producto`),
  ADD KEY `codigo_linea` (`codigo_linea`),
  ADD KEY `codigo_marca` (`codigo_marca`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`codigo_proveedor`);

--
-- Indices de la tabla `tipomovimiento`
--
ALTER TABLE `tipomovimiento`
  ADD PRIMARY KEY (`codigo_tipomovimiento`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`codigo_usuario`);

--
-- Indices de la tabla `vendedores`
--
ALTER TABLE `vendedores`
  ADD PRIMARY KEY (`codigo_vendedor`);

--
-- Indices de la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  ADD PRIMARY KEY (`documento_ventaenca`,`codigo_producto`),
  ADD KEY `codigo_producto` (`codigo_producto`),
  ADD KEY `codigo_bodega` (`codigo_bodega`);

--
-- Indices de la tabla `ventas_encabezado`
--
ALTER TABLE `ventas_encabezado`
  ADD PRIMARY KEY (`documento_ventaenca`),
  ADD KEY `codigo_cliente` (`codigo_cliente`);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD CONSTRAINT `clientes_ibfk_1` FOREIGN KEY (`codigo_vendedor`) REFERENCES `vendedores` (`codigo_vendedor`);

--
-- Filtros para la tabla `compras_detalle`
--
ALTER TABLE `compras_detalle`
  ADD CONSTRAINT `compras_detalle_ibfk_1` FOREIGN KEY (`documento_compraenca`) REFERENCES `compras_encabezado` (`documento_compraenca`),
  ADD CONSTRAINT `compras_detalle_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `productos` (`codigo_producto`),
  ADD CONSTRAINT `compras_detalle_ibfk_3` FOREIGN KEY (`codigo_bodega`) REFERENCES `bodegas` (`codigo_bodega`);

--
-- Filtros para la tabla `compras_encabezado`
--
ALTER TABLE `compras_encabezado`
  ADD CONSTRAINT `compras_encabezado_ibfk_1` FOREIGN KEY (`codigo_proveedor`) REFERENCES `proveedores` (`codigo_proveedor`);

--
-- Filtros para la tabla `existencias`
--
ALTER TABLE `existencias`
  ADD CONSTRAINT `existencias_ibfk_1` FOREIGN KEY (`codigo_bodega`) REFERENCES `bodegas` (`codigo_bodega`),
  ADD CONSTRAINT `existencias_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `productos` (`codigo_producto`);

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `productos_ibfk_1` FOREIGN KEY (`codigo_linea`) REFERENCES `lineas` (`codigo_linea`),
  ADD CONSTRAINT `productos_ibfk_2` FOREIGN KEY (`codigo_marca`) REFERENCES `marcas` (`codigo_marca`);

--
-- Filtros para la tabla `ventas_detalle`
--
ALTER TABLE `ventas_detalle`
  ADD CONSTRAINT `ventas_detalle_ibfk_1` FOREIGN KEY (`documento_ventaenca`) REFERENCES `ventas_encabezado` (`documento_ventaenca`),
  ADD CONSTRAINT `ventas_detalle_ibfk_2` FOREIGN KEY (`codigo_producto`) REFERENCES `productos` (`codigo_producto`),
  ADD CONSTRAINT `ventas_detalle_ibfk_3` FOREIGN KEY (`codigo_bodega`) REFERENCES `bodegas` (`codigo_bodega`);

--
-- Filtros para la tabla `ventas_encabezado`
--
ALTER TABLE `ventas_encabezado`
  ADD CONSTRAINT `ventas_encabezado_ibfk_1` FOREIGN KEY (`codigo_cliente`) REFERENCES `clientes` (`codigo_cliente`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
