-- Eliminación de Tablas
DROP TABLE IF EXISTS cuenta_usuario;
DROP TABLE IF EXISTS linea_orden_venta;
DROP TABLE IF EXISTS orden_venta;
DROP TABLE IF EXISTS cliente;
DROP TABLE IF EXISTS empleado;
DROP TABLE IF EXISTS persona;
DROP TABLE IF EXISTS area;
DROP TABLE IF EXISTS producto;
-- Creación de Tablas
CREATE TABLE area(
	id_area INT AUTO_INCREMENT,
    nombre VARCHAR(50),
    activa TINYINT,
    PRIMARY KEY(id_area)
)ENGINE=InnoDB;
CREATE TABLE persona(
	id_persona INT AUTO_INCREMENT,
    DNI VARCHAR(8),
    nombre VARCHAR(50),
    apellido_paterno VARCHAR(50),
    genero CHAR,
    fecha_nacimiento DATE,
    PRIMARY KEY(id_persona)
)ENGINE=InnoDB;
CREATE TABLE empleado(
	id_empleado INT,
    fid_area INT,
    cargo VARCHAR(70),
    sueldo DECIMAL(10,2),
    activo TINYINT,
    PRIMARY KEY(id_empleado),
    FOREIGN KEY(id_empleado) REFERENCES persona(id_persona),
    FOREIGN KEY(fid_area) REFERENCES area(id_area)
)ENGINE=InnoDB;
CREATE TABLE cliente(
	id_cliente INT,
    linea_credito DECIMAL(10,2),
    categoria VARCHAR(50),
    PRIMARY KEY(id_cliente),
    FOREIGN KEY(id_cliente) REFERENCES persona(id_persona)
)ENGINE=InnoDB;
CREATE TABLE producto(
	id_producto INT AUTO_INCREMENT,
    nombre VARCHAR(100),
    unidad_medida VARCHAR(50),
    precio DECIMAL(10,2),
    activo TINYINT,
    PRIMARY KEY(id_producto)
)ENGINE=InnoDB;
CREATE TABLE orden_venta(
	id_orden_venta INT AUTO_INCREMENT,
    fid_cliente INT,
    fid_empleado INT,
    total DECIMAL(10,2),
    fecha_hora_registro DATETIME,
    activo TINYINT,
    PRIMARY KEY(id_orden_venta),
    FOREIGN KEY(fid_cliente) REFERENCES cliente(id_cliente),
    FOREIGN KEY(fid_empleado) REFERENCES empleado(id_empleado)
)ENGINE=InnoDB;
CREATE TABLE linea_orden_venta(
	id_linea_orden_venta INT AUTO_INCREMENT,
    fid_orden_venta INT,
    fid_producto INT,
    cantidad INT,
    subtotal DECIMAL(10,2),
    fecha_hora_registro DATETIME,
    activo TINYINT,
    PRIMARY KEY(id_linea_orden_venta),
    FOREIGN KEY(fid_orden_venta) REFERENCES orden_venta(id_orden_venta),
    FOREIGN KEY(fid_producto) REFERENCES producto(id_producto)
)ENGINE = InnoDB;
CREATE TABLE cuenta_usuario(
	id_cuenta_usuario INT PRIMARY KEY AUTO_INCREMENT,
	fid_empleado INT UNIQUE,
    username VARCHAR(100),
    password VARCHAR(100),
    FOREIGN KEY(fid_empleado) REFERENCES empleado(id_empleado)
)ENGINE = InnoDB;
-- Eliminación de Procedimientos almacenados
-- Procedimientos relacionados a areas
DROP PROCEDURE IF EXISTS INSERTAR_AREA;
DROP PROCEDURE IF EXISTS MODIFICAR_AREA;
DROP PROCEDURE IF EXISTS ELIMINAR_AREA;
DROP PROCEDURE IF EXISTS LISTAR_AREAS_TODAS;
-- Procedimientos relacionados a empleados
DROP PROCEDURE IF EXISTS INSERTAR_EMPLEADO;
DROP PROCEDURE IF EXISTS MODIFICAR_EMPLEADO;
DROP PROCEDURE IF EXISTS ELIMINAR_EMPLEADO;
DROP PROCEDURE IF EXISTS LISTAR_EMPLEADOS_TODOS;
DROP PROCEDURE IF EXISTS BUSCAR_EMPLEADO_X_ID;
-- Procedimientos relacionados a clientes
DROP PROCEDURE IF EXISTS INSERTAR_CLIENTE;
DROP PROCEDURE IF EXISTS LISTAR_CLIENTES_X_NOMBRE_DNI;
-- Procedimientos relacionados a productos
DROP PROCEDURE IF EXISTS INSERTAR_PRODUCTO;
DROP PROCEDURE IF EXISTS LISTAR_PRODUCTOS_X_NOMBRE;
-- Procedimientos relacionados a ordenes de venta
DROP PROCEDURE IF EXISTS INSERTAR_ORDEN_VENTA;
DROP PROCEDURE IF EXISTS INSERTAR_LINEA_ORDEN_VENTA;
DROP PROCEDURE IF EXISTS LISTAR_ORDENES_VENTA_X_ID_NOMBRE_DNI_CLIENTE;
DROP PROCEDURE IF EXISTS LISTAR_LINEAS_ORDEN_VENTA_X_ID_ORDEN_VENTA;
-- Procedimientos relacionados a cuentas de usuario
DROP PROCEDURE IF EXISTS INSERTAR_CUENTA_USUARIO;
DROP PROCEDURE IF EXISTS VERIFICAR_CUENTA_USUARIO;
-- Creación de Procedimientos Almacenados
DELIMITER $
-- Procedimientos relacionados a areas
CREATE PROCEDURE INSERTAR_AREA
(
	OUT _id_area INT,
	IN _nombre VARCHAR(50)
)
BEGIN
	INSERT INTO area(nombre,activa) VALUES(_nombre,1);
    SET _id_area = @@last_insert_id;
END$
CREATE PROCEDURE MODIFICAR_AREA(
	IN _id_area INT,
    IN _nombre VARCHAR(50)
)
BEGIN
	UPDATE area SET nombre = _nombre WHERE id_area = _id_area;
END$
CREATE PROCEDURE ELIMINAR_AREA(
	IN _id_area INT
)
BEGIN
	UPDATE area SET activa = 0 WHERE id_area = _id_area;
END$
CREATE PROCEDURE LISTAR_AREAS_TODAS()
BEGIN
	SELECT id_area, nombre FROM area WHERE activa = 1;
END$
-- Procedimientos relacionados a empleados
CREATE PROCEDURE INSERTAR_EMPLEADO(
	OUT _id_empleado INT,
	IN _fid_area INT,
	IN _DNI VARCHAR(8),
    IN _nombre VARCHAR(50),
    IN _apellido_paterno VARCHAR(50),
    IN _genero CHAR(1),
    IN _fecha_nacimiento DATE,
    IN _cargo VARCHAR(70),
    IN _sueldo DECIMAL(10,2)
)
BEGIN
	INSERT INTO persona(DNI,nombre,apellido_paterno,genero,fecha_nacimiento) VALUES(_DNI,_nombre,_apellido_paterno,_genero,_fecha_nacimiento);
    SET _id_empleado = @@last_insert_id;
    INSERT INTO empleado(id_empleado,fid_area,cargo,sueldo,activo) VALUES(_id_empleado,_fid_area,_cargo,_sueldo,1);
END$
DELIMITER $
CREATE PROCEDURE LISTAR_EMPLEADOS_TODOS()
BEGIN
	SELECT p.id_persona, p.DNI, p.nombre as nombre_empleado, p.apellido_paterno, p.genero, p.fecha_nacimiento, a.id_area, a.nombre as nombre_area, e.cargo, e.sueldo FROM empleado e INNER JOIN persona p ON e.id_empleado = p.id_persona INNER JOIN area a ON e.fid_area = a.id_area WHERE e.activo = 1;
END$
DELIMITER $
CREATE PROCEDURE BUSCAR_EMPLEADO_X_ID(
	IN _id_empleado INT
)
BEGIN
	SELECT p.id_persona, p.DNI, p.nombre as nombre_empleado, p.apellido_paterno, p.genero, p.fecha_nacimiento, a.id_area, a.nombre as nombre_area, e.cargo, e.sueldo FROM empleado e INNER JOIN persona p ON e.id_empleado = p.id_persona INNER JOIN area a ON e.fid_area = a.id_area WHERE e.activo = 1 AND p.id_persona = _id_empleado;
END$
CREATE PROCEDURE MODIFICAR_EMPLEADO(
	IN _id_empleado INT,
	IN _fid_area INT,
	IN _DNI VARCHAR(8),
    IN _nombre VARCHAR(50),
    IN _apellido_paterno VARCHAR(50),
    IN _genero CHAR(1),
    IN _fecha_nacimiento DATE,
    IN _cargo VARCHAR(70),
    IN _sueldo DECIMAL(10,2)
)
BEGIN
	UPDATE persona SET DNI = _DNI, nombre = _nombre, apellido_paterno = _apellido_paterno, genero = _genero, fecha_nacimiento = _fecha_nacimiento WHERE id_persona = _id_empleado;
    UPDATE empleado SET fid_area = _fid_area, cargo = _cargo, sueldo = _sueldo WHERE id_empleado = _id_empleado;
END$
CREATE PROCEDURE ELIMINAR_EMPLEADO(
	IN _id_empleado INT
)
BEGIN
	UPDATE empleado SET activo = 0 WHERE id_empleado = _id_empleado;
END$
-- Procedimientos relacionados a clientes
CREATE PROCEDURE INSERTAR_CLIENTE(
	OUT _id_cliente INT,
	IN _DNI VARCHAR(8),
    IN _nombre VARCHAR(70),
    IN _apellido_paterno VARCHAR(70),
    IN _genero CHAR,
    IN _fecha_nacimiento DATE,
    IN _linea_credito DECIMAL(10,2),
    IN _categoria VARCHAR(50)
)
BEGIN
	INSERT INTO persona(DNI,nombre,apellido_paterno,genero,fecha_nacimiento) VALUES(_DNI,_nombre,_apellido_paterno,_genero,_fecha_nacimiento);
    SET _id_cliente = @@last_insert_id;
    INSERT INTO cliente(id_cliente,linea_credito,categoria) VALUES(_id_cliente,_linea_credito,_categoria);
END$
CREATE PROCEDURE LISTAR_CLIENTES_X_NOMBRE_DNI(
	IN _nombreDNI VARCHAR(140)
)
BEGIN
	SELECT p.id_persona, p.DNI, p.nombre, p.apellido_paterno, p.genero, p.fecha_nacimiento, c.linea_credito, c.categoria FROM persona p INNER JOIN cliente c ON p.id_persona = c.id_cliente WHERE (CONCAT(p.nombre,' ',p.apellido_paterno) LIKE CONCAT('%',_nombreDNI,'%')) OR (p.DNI LIKE CONCAT('%',_nombreDNI,'%'));
END$
-- Procedimientos relacionados a productos
CREATE PROCEDURE INSERTAR_PRODUCTO(
	OUT _id_producto INT,
    IN _nombre VARCHAR(100),
    IN _unidad_medida VARCHAR(50),
    IN _precio DECIMAL(10,2)
)
BEGIN
	INSERT INTO producto(nombre,unidad_medida,precio,activo) values(_nombre,_unidad_medida,_precio,1);
    SET _id_producto = @@last_insert_id;
END$
CREATE PROCEDURE LISTAR_PRODUCTOS_X_NOMBRE(
	IN _nombre VARCHAR(100)
)
BEGIN
	SELECT id_producto, nombre, unidad_medida, precio FROM producto WHERE activo = 1 AND 
    nombre LIKE CONCAT('%',_nombre,'%');
END$

CREATE PROCEDURE INSERTAR_ORDEN_VENTA(
	OUT _id_orden_venta INT,
    IN _fid_cliente INT,
    IN _fid_empleado INT,
    IN _total DECIMAL(10,2)
)
BEGIN
	INSERT INTO orden_venta(fid_cliente,fid_empleado,total,fecha_hora_registro,activo) VALUES(_fid_cliente,_fid_empleado,_total,now() - INTERVAL 5 HOUR,1);
    SET _id_orden_venta = @@last_insert_id;
END$
DELIMITER $
CREATE PROCEDURE INSERTAR_LINEA_ORDEN_VENTA(
	OUT _id_linea_orden_venta INT,
    IN _fid_orden_venta INT,
    IN _fid_producto INT,
    IN _cantidad INT,
    IN _subtotal DECIMAL(10,2)
)
BEGIN
	INSERT INTO linea_orden_venta(fid_orden_venta,fid_producto,cantidad,subtotal,fecha_hora_registro,activo) VALUES(_fid_orden_venta,_fid_producto,_cantidad,_subtotal,now() - INTERVAL 5 HOUR,1);
    SET _id_linea_orden_venta = @@last_insert_id;
END$
DELIMITER $
CREATE PROCEDURE LISTAR_ORDENES_VENTA_X_ID_NOMBRE_DNI_CLIENTE(
	IN _id_venta_dni_nombre_cliente VARCHAR(100)
)
BEGIN
	SELECT ov.id_orden_venta, c.id_cliente, p.DNI, p.nombre,
    p.apellido_paterno, ov.fecha_hora_registro, ov.total 
    FROM orden_venta ov 
    INNER JOIN cliente c ON ov.fid_cliente = c.id_cliente 
    INNER JOIN persona p ON c.id_cliente = p.id_persona 
    WHERE ((CONCAT(p.nombre, ' ',p.apellido_paterno) 
    LIKE CONCAT('%',_id_venta_dni_nombre_cliente,'%')) OR 
		(p.DNI LIKE CONCAT('%',_id_venta_dni_nombre_cliente,'%')) OR 
        (CONVERT(ov.id_orden_venta,CHAR(100)) 
        LIKE CONCAT('%',_id_venta_dni_nombre_cliente,'%'))) AND 
        ov.activo = 1;
END$
DELIMITER $
CREATE PROCEDURE LISTAR_LINEAS_ORDEN_VENTA_X_ID_ORDEN_VENTA(
	IN _id_orden_venta INT
)
BEGIN
	SELECT lov.id_linea_orden_venta, p.id_producto, p.nombre, 
    p.unidad_medida, p.precio, lov.cantidad, lov.subtotal, 
    lov.fecha_hora_registro 
    FROM linea_orden_venta lov 
    INNER JOIN producto p ON lov.fid_producto = p.id_producto 
    WHERE lov.activo = 1 AND lov.fid_orden_venta = _id_orden_venta;
END$
DELIMITER $
CREATE PROCEDURE INSERTAR_CUENTA_USUARIO
(
	OUT _id_cuenta_usuario INT,
    IN _id_empleado INT,
	IN _username VARCHAR(100),
    IN _password VARCHAR(100)
)
BEGIN
	INSERT INTO cuenta_usuario(fid_empleado,username,password) VALUES(_id_empleado,_username,MD5(_password));
    SET _id_cuenta_usuario = @@last_insert_id;
END$
DELIMITER $
CREATE PROCEDURE VERIFICAR_CUENTA_USUARIO
(
	IN _username VARCHAR(100),
    IN _password VARCHAR(100)
)
BEGIN
	SELECT cu.id_cuenta_usuario, cu.fid_empleado, cu.username, cu.password FROM cuenta_usuario cu WHERE cu.username = _username AND
cu.password = MD5(_password);
END$
-- Insertando areas
CALL INSERTAR_AREA(@id_area1,'CONTABILIDAD');
CALL INSERTAR_AREA(@id_area2,'VENTAS');
CALL INSERTAR_AREA(@id_area3,'FINANZAS');
-- Insertando empleados
CALL INSERTAR_EMPLEADO(@id_empleado1,@id_area2,'12987109','KAREN','DIAZ','F','1986-11-01','CAJERA',1500.00);
CALL INSERTAR_EMPLEADO(@id_empleado2,@id_area2,'29121803','JUAN','ARENAS','M','1991-02-19','VENDEDOR','1750.00');
CALL INSERTAR_EMPLEADO(@id_empleado3,@id_area1,'17300362','MANUEL','CARRASCO','M','1982-07-18','ANALISTA CONTABLE','2500.00');
-- Insertando cuentas de usuario
CALL INSERTAR_CUENTA_USUARIO(@id_cuenta_usuario1,@id_empleado1,'kdiaz','123456');
CALL INSERTAR_CUENTA_USUARIO(@id_cuenta_usuario2,@id_empleado2,'jarenas','123456');
CALL INSERTAR_CUENTA_USUARIO(@id_cuenta_usuario2,@id_empleado3,'mcarrasco','123456');
-- Insertando clientes
CALL INSERTAR_CLIENTE(@id_cliente1,'13007065','CAROLINA','SALVADOR','F','1992-11-22',2500.00,'Platinum');
CALL INSERTAR_CLIENTE(@id_cliente2,'18732004','DANIELA','VILLANUEVA','F','1984-03-15',1000.00,'Clasico');
CALL INSERTAR_CLIENTE(@id_cliente3,'39871002','HUGO','VALDIVIA','M','1992-03-03',2000.00,'Clasico');
CALL INSERTAR_CLIENTE(@id_cliente4,'28709982','OSCAR','CARRANZA','M','1993-10-30',2000.00,'VIP');
CALL INSERTAR_CLIENTE(@id_cliente5,'10920091','ANGELA','GUEVARA','F','1988-03-13',3000.00,'Platinum');
CALL INSERTAR_CLIENTE(@id_cliente6,'33620929','PEDRO','MENDOZA','M','1984-10-09',3700.00,'VIP');
CALL INSERTAR_CLIENTE(@id_cliente7,'17200928','CARMEN','GAVIDIA','F','1981-02-15',1430.00,'Clasico');
CALL INSERTAR_CLIENTE(@id_cliente8,'28779283','PIERINA','RUIZ','F','1984-11-23',3345.00,'VIP');
-- Insertando productos
CALL INSERTAR_PRODUCTO(@id_producto1,'GASEOSA INKA KOLA','500 ML',2.70);
CALL INSERTAR_PRODUCTO(@id_producto2,'GASEOSA COCA COLA','1.5 LT',5.90);
CALL INSERTAR_PRODUCTO(@id_producto3,'DETERGENTE LIQUIDO BOLIVAR','940 ML',16.00);
CALL INSERTAR_PRODUCTO(@id_producto4,'LAVAVAJILLAS EN PASTA LIMON SAPOLIO','900 GR',6.10);
