-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 21-05-2015 a las 01:30:33
-- Versión del servidor: 5.6.21
-- Versión de PHP: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `admincsy_general`
--
CREATE DATABASE IF NOT EXISTS `admincsy_general` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `admincsy_general`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `abono`
--

CREATE TABLE IF NOT EXISTS `abono` (
`id` int(11) NOT NULL,
  `venta_id` int(11) DEFAULT NULL,
  `id_trabajador` int(11) DEFAULT NULL,
  `id_cliente` int(11) DEFAULT NULL,
  `abono` decimal(10,2) DEFAULT NULL,
  `tipo_pago` int(11) DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `saldo` decimal(10,2) DEFAULT NULL,
  `folio` varchar(45) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `almacen`
--

CREATE TABLE IF NOT EXISTS `almacen` (
`id` int(11) NOT NULL,
  `id_trabajador` int(11) NOT NULL,
  `num_alm` int(11) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `sucursal_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `caja`
--

CREATE TABLE IF NOT EXISTS `caja` (
`id` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `efectivo` decimal(10,2) NOT NULL,
  `voucher` decimal(10,2) NOT NULL,
  `descripcion` varchar(255) NOT NULL,
  `tipo_movimiento` int(11) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

CREATE TABLE IF NOT EXISTS `categoria` (
`id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
`id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `cuenta_id` int(11) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `razon_social` varchar(45) DEFAULT NULL,
  `rfc` varchar(45) DEFAULT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `num_ext` varchar(15) DEFAULT NULL,
  `num_int` varchar(15) DEFAULT NULL,
  `colonia` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `cp` varchar(11) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `lada1` varchar(45) DEFAULT NULL,
  `lada2` varchar(45) DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL COMMENT 'Tipos de clientes-Cliente con crédit',
  `limite_credito` decimal(10,2) NOT NULL DEFAULT '0.00',
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra`
--

CREATE TABLE IF NOT EXISTS `compra` (
`id` int(11) NOT NULL,
  `id_proveedor` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `id_comprador` int(11) DEFAULT NULL COMMENT 'Utilizar trabajador_id',
  `estado` int(11) NOT NULL DEFAULT '0',
  `subtotal` decimal(10,2) NOT NULL DEFAULT '0.00',
  `impuesto` decimal(10,2) NOT NULL DEFAULT '0.00',
  `descuento` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total` decimal(10,2) NOT NULL DEFAULT '0.00',
  `tipo_pago` int(11) NOT NULL,
  `remision` tinyint(1) NOT NULL,
  `factura` tinyint(1) NOT NULL,
  `folio_remision` varchar(100) DEFAULT NULL,
  `folio_factura` varchar(100) DEFAULT NULL,
  `cancelada` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compra_detallada`
--

CREATE TABLE IF NOT EXISTS `compra_detallada` (
  `id_compra` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` decimal(10,2) NOT NULL,
  `unidad` int(11) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contacto_cliente`
--

CREATE TABLE IF NOT EXISTS `contacto_cliente` (
`id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `extension` varchar(45) DEFAULT NULL,
  `celular` varchar(45) DEFAULT NULL,
  `lada1` varchar(45) DEFAULT NULL,
  `lada2` varchar(45) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `contacto_proveedor`
--

CREATE TABLE IF NOT EXISTS `contacto_proveedor` (
`id` int(11) NOT NULL,
  `id_proveedor` int(11) NOT NULL,
  `nombre` varchar(75) DEFAULT NULL,
  `apellidos` varchar(75) DEFAULT NULL,
  `telefono1` varchar(50) DEFAULT NULL,
  `telefono2` varchar(50) DEFAULT NULL,
  `extension` varchar(10) DEFAULT NULL,
  `celular` varchar(50) DEFAULT NULL,
  `lada1` varchar(10) DEFAULT NULL,
  `lada2` varchar(10) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion`
--

CREATE TABLE IF NOT EXISTS `cotizacion` (
`id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `id_vendedor` int(11) DEFAULT NULL COMMENT 'Utilizar trabajador_id',
  `estado` int(11) NOT NULL DEFAULT '0',
  `abierta` tinyint(1) NOT NULL DEFAULT '1',
  `subtotal` decimal(10,2) NOT NULL DEFAULT '0.00',
  `impuesto` decimal(10,2) NOT NULL DEFAULT '0.00',
  `descuento` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total` decimal(10,2) NOT NULL DEFAULT '0.00',
  `remision` tinyint(1) DEFAULT NULL,
  `factura` tinyint(1) DEFAULT NULL,
  `folio_factura` varchar(30) DEFAULT NULL,
  `tipo_pago` int(11) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cotizacion_detallada`
--

CREATE TABLE IF NOT EXISTS `cotizacion_detallada` (
  `id_venta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` decimal(10,2) NOT NULL,
  `unidad` int(11) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta`
--

CREATE TABLE IF NOT EXISTS `cuenta` (
`id` int(11) NOT NULL,
  `clabe` varchar(50) DEFAULT NULL,
  `banco` varchar(70) DEFAULT NULL,
  `beneficiario` varchar(100) DEFAULT NULL,
  `sucursal` varchar(20) DEFAULT NULL,
  `num_cuenta` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `direccion`
--

CREATE TABLE IF NOT EXISTS `direccion` (
`id` int(11) NOT NULL,
  `calle` varchar(100) NOT NULL,
  `num_ext` varchar(30) NOT NULL,
  `num_int` varchar(30) NOT NULL,
  `cp` varchar(10) NOT NULL,
  `colonia` varchar(50) NOT NULL,
  `ciudad` varchar(75) NOT NULL,
  `estado` varchar(75) NOT NULL,
  `eliminado` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado_caja`
--

CREATE TABLE IF NOT EXISTS `estado_caja` (
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `gasto`
--

CREATE TABLE IF NOT EXISTS `gasto` (
`id` int(11) NOT NULL,
  `id_trabajador` int(11) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL,
  `folio` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `privilegios`
--

CREATE TABLE IF NOT EXISTS `privilegios` (
`id` int(11) NOT NULL,
  `id_usuario` int(11) NOT NULL,
  `caja` tinyint(1) NOT NULL,
  `abrir_cerrar_caja` tinyint(1) NOT NULL,
  `movimientos_caja` tinyint(1) NOT NULL,
  `configuracion` tinyint(1) NOT NULL,
  `correo` tinyint(1) NOT NULL,
  `base_datos` tinyint(1) NOT NULL,
  `compra` tinyint(1) NOT NULL,
  `cliente` tinyint(1) NOT NULL,
  `eliminar_cliente` tinyint(1) NOT NULL,
  `proveedor` tinyint(1) NOT NULL,
  `eliminar_proveedor` tinyint(1) NOT NULL,
  `cotizacion` tinyint(1) NOT NULL,
  `producto` tinyint(1) NOT NULL,
  `editar_producto` tinyint(1) NOT NULL,
  `eliminar_producto` tinyint(1) NOT NULL,
  `sucursal` tinyint(1) NOT NULL,
  `trabajador` tinyint(1) NOT NULL,
  `crear_trabajador` tinyint(1) NOT NULL,
  `editar_trabajador` tinyint(1) NOT NULL,
  `eliminar_trabajador` tinyint(1) NOT NULL,
  `pago_trabajador` tinyint(1) NOT NULL,
  `usuario` tinyint(1) NOT NULL,
  `venta` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE IF NOT EXISTS `producto` (
`id` int(11) NOT NULL,
  `proveedor_id` int(11) NOT NULL,
  `categoria` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `marca` varchar(45) DEFAULT NULL,
  `codigo` varchar(45) DEFAULT NULL,
  `descripcion1` varchar(45) DEFAULT NULL,
  `costo` decimal(10,2) DEFAULT NULL,
  `precio` decimal(10,2) NOT NULL DEFAULT '0.00',
  `cant` decimal(10,2) NOT NULL,
  `precio_mediomayoreo` decimal(10,2) NOT NULL DEFAULT '0.00',
  `precio_mayoreo` decimal(10,2) NOT NULL DEFAULT '0.00',
  `cant_mediomayoreo` decimal(10,2) DEFAULT NULL,
  `cant_mayoreo` decimal(10,2) DEFAULT NULL,
  `unidad` int(11) DEFAULT NULL COMMENT 'Unidades para el producto\n-Pieza\n-Paquete',
  `imagen01` longblob,
  `imagen02` longblob,
  `imagen03` longblob,
  `eliminado` tinyint(1) DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

CREATE TABLE IF NOT EXISTS `proveedor` (
`id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `cuenta_id` int(11) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `razon_social` varchar(45) DEFAULT NULL,
  `rfc` varchar(45) DEFAULT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `num_ext` varchar(20) DEFAULT NULL,
  `num_int` varchar(20) DEFAULT NULL,
  `colonia` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `cp` varchar(11) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `lada1` varchar(45) DEFAULT NULL,
  `lada2` varchar(45) DEFAULT NULL,
  `tipo` int(11) DEFAULT NULL COMMENT 'Tipos de proveedores-Proveedor con crédito-Proveedor sin crédi',
  `limite_credito` decimal(10,2) NOT NULL DEFAULT '0.00',
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puesto`
--

CREATE TABLE IF NOT EXISTS `puesto` (
`id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `departamento` varchar(45) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sucursal`
--

CREATE TABLE IF NOT EXISTS `sucursal` (
`id` int(11) NOT NULL,
  `id_domicilio` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `calle` varchar(45) DEFAULT NULL,
  `numero_ext` int(11) DEFAULT NULL,
  `numero_int` int(11) DEFAULT NULL,
  `cp` int(11) DEFAULT NULL,
  `colonia` varchar(75) NOT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `telefono1` varchar(45) DEFAULT NULL,
  `telefono2` varchar(45) DEFAULT NULL,
  `fax` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `logotipo` longblob,
  `web` varchar(45) DEFAULT NULL,
  `rfc` varchar(45) DEFAULT NULL,
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `trabajador`
--

CREATE TABLE IF NOT EXISTS `trabajador` (
`id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `puesto` int(11) NOT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `celular` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `estado` varchar(45) DEFAULT NULL,
  `cp` int(11) DEFAULT NULL,
  `sueldo` decimal(10,2) DEFAULT NULL,
  `nomina` int(11) DEFAULT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `imagen` longblob,
  `huella` longblob,
  `eliminado` tinyint(1) NOT NULL DEFAULT '0',
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

CREATE TABLE IF NOT EXISTS `usuario` (
`id` int(11) NOT NULL,
  `sucursal_id` int(11) NOT NULL,
  `username` varchar(45) DEFAULT NULL,
  `pass` varchar(150) DEFAULT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `apellidos` varchar(45) DEFAULT NULL,
  `nivel` int(11) DEFAULT NULL COMMENT 'Niveles de usuario',
  `email` varchar(100) DEFAULT NULL,
  `eliminado` tinyint(1) DEFAULT '0',
  `num_aut` int(11) DEFAULT NULL,
  `imagen` longblob,
  `huella` longblob,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `delete_user` int(11) DEFAULT NULL,
  `delete_time` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE IF NOT EXISTS `venta` (
`id` int(11) NOT NULL,
  `id_cliente` int(11) NOT NULL,
  `id_sucursal` int(11) NOT NULL,
  `id_vendedor` int(11) DEFAULT NULL COMMENT 'Utilizar trabajador_id',
  `cancelada` tinyint(1) NOT NULL DEFAULT '0',
  `abierta` tinyint(1) NOT NULL DEFAULT '1',
  `subtotal` decimal(10,2) NOT NULL DEFAULT '0.00',
  `impuesto` decimal(10,2) NOT NULL DEFAULT '0.00',
  `descuento` decimal(10,2) NOT NULL DEFAULT '0.00',
  `total` decimal(10,2) NOT NULL DEFAULT '0.00',
  `remision` tinyint(1) DEFAULT NULL,
  `factura` tinyint(1) DEFAULT NULL,
  `folio_factura` varchar(30) DEFAULT NULL,
  `tipo_pago` int(11) DEFAULT NULL,
  `create_user` int(11) DEFAULT NULL,
  `create_time` datetime DEFAULT NULL,
  `update_user` int(11) DEFAULT NULL,
  `update_time` datetime DEFAULT NULL,
  `cancel_user` int(11) DEFAULT NULL,
  `cancel_time` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta_detallada`
--

CREATE TABLE IF NOT EXISTS `venta_detallada` (
  `id_venta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cant` decimal(10,2) NOT NULL,
  `precio` decimal(10,2) NOT NULL,
  `descuento` decimal(10,2) NOT NULL,
  `unidad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `abono`
--
ALTER TABLE `abono`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `almacen`
--
ALTER TABLE `almacen`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `caja`
--
ALTER TABLE `caja`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
 ADD PRIMARY KEY (`id`,`sucursal_id`);

--
-- Indices de la tabla `compra`
--
ALTER TABLE `compra`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `compra_detallada`
--
ALTER TABLE `compra_detallada`
 ADD PRIMARY KEY (`id_compra`,`id_producto`);

--
-- Indices de la tabla `contacto_cliente`
--
ALTER TABLE `contacto_cliente`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `contacto_proveedor`
--
ALTER TABLE `contacto_proveedor`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `cotizacion_detallada`
--
ALTER TABLE `cotizacion_detallada`
 ADD PRIMARY KEY (`id_venta`,`id_producto`);

--
-- Indices de la tabla `cuenta`
--
ALTER TABLE `cuenta`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `direccion`
--
ALTER TABLE `direccion`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `gasto`
--
ALTER TABLE `gasto`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `privilegios`
--
ALTER TABLE `privilegios`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
 ADD PRIMARY KEY (`id`), ADD UNIQUE KEY `codigo` (`codigo`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
 ADD PRIMARY KEY (`id`,`sucursal_id`);

--
-- Indices de la tabla `puesto`
--
ALTER TABLE `puesto`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `sucursal`
--
ALTER TABLE `sucursal`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `trabajador`
--
ALTER TABLE `trabajador`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
 ADD PRIMARY KEY (`id`,`sucursal_id`), ADD UNIQUE KEY `username_UNIQUE` (`username`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
 ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `venta_detallada`
--
ALTER TABLE `venta_detallada`
 ADD PRIMARY KEY (`id_venta`,`id_producto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `abono`
--
ALTER TABLE `abono`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `almacen`
--
ALTER TABLE `almacen`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `caja`
--
ALTER TABLE `caja`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cliente`
--
ALTER TABLE `cliente`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `compra`
--
ALTER TABLE `compra`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `contacto_cliente`
--
ALTER TABLE `contacto_cliente`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `contacto_proveedor`
--
ALTER TABLE `contacto_proveedor`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cotizacion`
--
ALTER TABLE `cotizacion`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `cuenta`
--
ALTER TABLE `cuenta`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `direccion`
--
ALTER TABLE `direccion`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `gasto`
--
ALTER TABLE `gasto`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `privilegios`
--
ALTER TABLE `privilegios`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `puesto`
--
ALTER TABLE `puesto`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `sucursal`
--
ALTER TABLE `sucursal`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `trabajador`
--
ALTER TABLE `trabajador`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT de la tabla `venta`
--
ALTER TABLE `venta`
MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
