DROP TABLE IF EXISTS cliente;
DROP TABLE IF EXISTS empleado;
DROP TABLE IF EXISTS persona;
DROP TABLE IF EXISTS area;
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
INSERT INTO area(nombre,activa) VALUES('CONTABILIDAD',1);
INSERT INTO area(nombre,activa) VALUES('VENTAS',1);
-- Procedimientos almacenados
DROP PROCEDURE IF EXISTS INSERTAR_AREA;
DROP PROCEDURE IF EXISTS MODIFICAR_AREA;
DROP PROCEDURE IF EXISTS ELIMINAR_AREA;
DROP PROCEDURE IF EXISTS LISTAR_AREAS_TODAS;
DROP PROCEDURE IF EXISTS INSERTAR_EMPLEADO;
DROP PROCEDURE IF EXISTS MODIFICAR_EMPLEADO;
DROP PROCEDURE IF EXISTS ELIMINAR_EMPLEADO;
DROP PROCEDURE IF EXISTS LISTAR_EMPLEADOS_TODOS;
DELIMITER $
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