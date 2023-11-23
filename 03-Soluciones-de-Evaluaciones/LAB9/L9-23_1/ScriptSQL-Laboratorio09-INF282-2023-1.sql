DROP TABLE IF EXISTS album_vinilo;
DROP TABLE IF EXISTS genero;
DROP TABLE IF EXISTS artista;
CREATE TABLE artista(
	id_artista INT AUTO_INCREMENT,
    nombre_artistico VARCHAR(300),
    pais_origen VARCHAR(300),
    PRIMARY KEY(id_artista)
)ENGINE=INNODB;
CREATE TABLE genero(
	id_genero INT AUTO_INCREMENT,
    nombre VARCHAR(150),
    activo TINYINT,
    PRIMARY KEY(id_genero)
)ENGINE=INNODB;
CREATE TABLE album_vinilo(
	id_album_vinilo INT AUTO_INCREMENT,
    fid_genero INT,
    fid_artista INT,
    nombre VARCHAR(300),
    anho YEAR,
    precio DECIMAL(10,2),
    cantidad_canciones INT,
    es_edicion_gatefold TINYINT,
    tiene_cd TINYINT,
    es_edicion_color TINYINT,
    descripcion VARCHAR(2000),
    foto LONGBLOB,
    activo TINYINT,
    PRIMARY KEY(id_album_vinilo),
    FOREIGN KEY(fid_genero) REFERENCES genero(id_genero),
    FOREIGN KEY(fid_artista) REFERENCES artista(id_artista)
)ENGINE=INNODB;
-- Insertando registros
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('LIBIDO','PERU');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('MAR DE COPAS','PERU');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('TINA TURNER','ESTADOS UNIDOS');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('ALEJANDRO SANZ','ESPAÑA');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('LUIS MIGUEL','MEXICO');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('DYANGO','ESPAÑA');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('BRITNEY SPEARS','ESTADOS UNIDOS');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('CHRISTINA AGUILERA','ESTADOS UNIDOS');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('ED SHEERAN','REINO UNIDO');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('MAROON 5','ESTADOS UNIDOS');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('TAYLOR SWIFT','ESTADOS UNIDOS');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('ADELE','REINO UNIDO');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('ARIANA GRANDE','ESTADOS UNIDOS');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('GIANMARCO','PERU');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('LOS PRISIONEROS','CHILE');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('ENANITOS VERDES','ARGENTINA');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('LA OREJA DE VAN GOGH','ESPAÑA');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('MORAT','COLOMBIA');
INSERT INTO artista(nombre_artistico,pais_origen) VALUES('MEGUMI HAYASHIBARA','JAPÓN');
INSERT INTO genero(nombre,activo) VALUES('CLÁSICA',1);
INSERT INTO genero(nombre,activo) VALUES('BLUES',1);
INSERT INTO genero(nombre,activo) VALUES('JAZZ',1);
INSERT INTO genero(nombre,activo) VALUES('RHYTHM AND BLUES',1);
INSERT INTO genero(nombre,activo) VALUES('ROCK AND ROLL',1);
INSERT INTO genero(nombre,activo) VALUES('GOSPEL',1);
INSERT INTO genero(nombre,activo) VALUES('SOUL',1);
INSERT INTO genero(nombre,activo) VALUES('BALADA',1);
INSERT INTO genero(nombre,activo) VALUES('ROCK',1);
INSERT INTO genero(nombre,activo) VALUES('METAL',1);
INSERT INTO genero(nombre,activo) VALUES('COUNTRY',1);
INSERT INTO genero(nombre,activo) VALUES('ELECTRÓNICA',1);
INSERT INTO genero(nombre,activo) VALUES('POP',1);
INSERT INTO genero(nombre,activo) VALUES('SOUNDTRACK',1);
INSERT INTO genero(nombre,activo) VALUES('SALSA',1);
INSERT INTO genero(nombre,activo) VALUES('REGGAE',1);
-- Creación de procedimientos almacenados
DROP PROCEDURE IF EXISTS LISTAR_ARTISTAS_X_NOMBRE;
DROP PROCEDURE IF EXISTS LISTAR_GENEROS_TODOS;
DROP PROCEDURE IF EXISTS INSERTAR_ALBUM_VINILO;
DROP PROCEDURE IF EXISTS LISTAR_ALBUMES_X_NOMBRE_O_ARTISTA;
DELIMITER $
CREATE PROCEDURE LISTAR_ARTISTAS_X_NOMBRE(
	_nombre_artistico VARCHAR(300)
)
BEGIN
	SELECT id_artista, nombre_artistico, pais_origen FROM artista WHERE nombre_artistico LIKE CONCAT('%',_nombre_artistico,'%') ORDER BY nombre_artistico ASC;
END$
CREATE PROCEDURE LISTAR_GENEROS_TODOS(
)
BEGIN
	SELECT id_genero, nombre FROM genero WHERE activo = 1 ORDER BY nombre ASC;
END$
CREATE PROCEDURE INSERTAR_ALBUM_VINILO(
	OUT _id_album_vinilo INT,
    IN _fid_genero INT,
    IN _fid_artista INT,
    IN _nombre VARCHAR(300),
    IN _anho YEAR,
    IN _precio DECIMAL(10,2),
    IN _cantidad_canciones INT,
    IN _es_edicion_gatefold TINYINT,
    IN _tiene_cd TINYINT,
    IN _es_edicion_color TINYINT,
    IN _descripcion VARCHAR(2000),
    IN _foto LONGBLOB
)
BEGIN
	INSERT INTO album_vinilo(fid_genero,fid_artista,nombre,anho,precio,cantidad_canciones,es_edicion_gatefold,tiene_cd,es_edicion_color,descripcion,foto,activo) VALUES(_fid_genero,_fid_artista,_nombre,_anho,_precio,_cantidad_canciones,_es_edicion_gatefold,_tiene_cd,_es_edicion_color,_descripcion,_foto,1);
    SET _id_album_vinilo = @@last_insert_id;
END$
CREATE PROCEDURE LISTAR_ALBUMES_X_NOMBRE_O_ARTISTA(
	IN _nombre_album_artista VARCHAR(300)
)
BEGIN
	SELECT av.id_album_vinilo, g.id_genero, g.nombre as nombre_genero, a.id_artista, a.nombre_artistico as nombre_artista, a.pais_origen, av.nombre as nombre_album, av.anho, av.precio, av.cantidad_canciones, av.es_edicion_gatefold, av.tiene_cd, av.es_edicion_color, av.descripcion, av.foto FROM album_vinilo av INNER JOIN genero g ON av.fid_genero = g.id_genero INNER JOIN artista a ON a.id_artista = av.fid_artista WHERE av.activo = 1 AND ((av.nombre LIKE CONCAT('%',_nombre_album_artista,'%')) OR (a.nombre_artistico LIKE CONCAT('%',_nombre_album_artista,'%')));
END$