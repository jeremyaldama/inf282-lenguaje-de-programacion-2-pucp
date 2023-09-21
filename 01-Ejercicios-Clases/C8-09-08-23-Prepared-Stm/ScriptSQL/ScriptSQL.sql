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