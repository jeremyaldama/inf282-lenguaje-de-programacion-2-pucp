DROP TABLE IF EXISTS aerolinea;
CREATE TABLE aerolinea(
	id_aerolinea INT AUTO_INCREMENT,
    nombre VARCHAR(100),
    callsign VARCHAR(100),
    tiene_programa_fidelidad TINYINT,
    fecha_fundacion DATE,
    descripcion VARCHAR(500),
    activa TINYINT,
    PRIMARY KEY(id_aerolinea)
)ENGINE=InnoDB;
INSERT INTO aerolinea(nombre,callsign,tiene_programa_fidelidad,fecha_fundacion,descripcion,activa) 
VALUES('Sky airlines','AEROSKY',false,'1987-10-19','SKY Airline es una aerolinea de bajo costo chilena',1);