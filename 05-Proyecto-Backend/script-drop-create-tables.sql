SET FOREIGN_KEY_CHECKS = 0;
SET GROUP_CONCAT_MAX_LEN = 10000;
SET SESSION group_concat_max_len = 10000;
SELECT GROUP_CONCAT('`', table_name, '`') INTO @tables_to_drop
FROM information_schema.tables
WHERE table_schema = 'ulearn_db';
SET @tables_to_drop = CONCAT('DROP TABLE IF EXISTS ', @tables_to_drop);
PREPARE stmt FROM @tables_to_drop;
EXECUTE stmt;
DEALLOCATE PREPARE stmt;
SET FOREIGN_KEY_CHECKS = 1;

CREATE TABLE usuario(
    id_usuario int auto_increment,
	nombre varchar(100),
    apellido_paterno varchar(100),
    apellido_materno varchar(100),
    usuario varchar(100),
    pass varchar(100),
    correo_electronico varchar(100),
    foto_perfil LONGBLOB,
    telefono varchar(100),
    sexo char(1),
    fecha_nacimiento DATE,
    activo TINYINT,
    tipo_usuario CHAR(1),
    salt varchar(12),
    primary key(id_usuario)
)ENGINE=InnoDB;

CREATE TABLE empleado(
    id_empleado int,
    hora_entrada time,
    hora_salida time,
    fecha_contratacion date,
    primary key(id_empleado),
    foreign key(id_empleado) references usuario(id_usuario)
)ENGINE=InnoDB;

CREATE TABLE facultad(
	id_facultad INT AUTO_INCREMENT,
    nombre VARCHAR(100),
    anexo VARCHAR(100),
    inscritos INT,
    fid_institucion INT,
    activa TINYINT,
    PRIMARY KEY (id_facultad)
) ENGINE=InnoDB;

CREATE TABLE docente(
    id_docente int,
    fid_facultad int,
    tipo_docente varchar(50),
    activo tinyint,
    grado_academico varchar(70),
    oficina VARCHAR(20),
    intereses_investigacion VARCHAR(100),
    es_deudor_libros tinyint,
    primary key(id_docente),
    foreign key(id_docente) references empleado(id_empleado),
    foreign key(fid_facultad) references facultad(id_facultad)
)ENGINE = InnoDB;


CREATE TABLE carrera(
	id_carrera INT AUTO_INCREMENT,
    fid_facultad INT,
    nombre VARCHAR(70),
    acreditada TINYINT,
    ultimo_cambio_malla DATE,
    creditos DECIMAL,
    cursos_totales INT,
    activo TINYINT,
    PRIMARY KEY(id_carrera),
    FOREIGN KEY(fid_facultad) REFERENCES facultad(id_facultad)
)ENGINE = InnoDB;

CREATE TABLE administrador(
    id_administrador int,
    activo tinyint,
    primary key(id_administrador),
    foreign key(id_administrador) references usuario(id_usuario)
)ENGINE = InnoDB;

create table encargadoBiblioteca(
	id_encargado_biblioteca int,
    activo tinyint,
    titulo_trabajo VARCHAR(50),
    primary key(id_encargado_biblioteca),
    foreign key(id_encargado_biblioteca) references empleado(id_empleado)
)ENGINE = InnoDB;

create table alumno(
    id_alumno int,
    fid_carrera int,
    estado tinyint,
    codigo_alumno varchar(20),
    es_deudor_libros tinyint,
    primary key(id_alumno),
    foreign key(id_alumno) references usuario(id_usuario),
    foreign key(fid_carrera) references carrera(id_carrera)
)ENGINE = InnoDB;

CREATE TABLE institucion (
	id_institucion INT AUTO_INCREMENT,
    direccion VARCHAR(100),
    nombre VARCHAR(100),
    telefono VARCHAR(100),
    aforo INT,
    activa TINYINT,
    PRIMARY KEY(id_institucion)
) ENGINE=InnoDB;



CREATE TABLE semestre(
	id_semestre INT PRIMARY KEY AUTO_INCREMENT,
    semestre VARCHAR(50),
    es_regular TINYINT,
    activo TINYINT,
    fecha_inicio DATE,
    fecha_fin DATE
) ENGINE=InnoDB;


create table curso(
	id_curso int auto_increment,
	codigo_curso varchar(10),
    es_electivo tinyint,
    creditos double,
    activo tinyint,
    nombre VARCHAR(50),
    primary key(id_curso)
)ENGINE = InnoDB;

create table cursoxcarrera(
	id_curso int,
    id_carrera int,
    foreign key(id_curso) references curso(id_curso),
    foreign key(id_carrera) references carrera(id_carrera)
)engine = InnoDB;

create table cursoxsemestre(
	id_cursoxsemestre int auto_increment,
    fid_curso int,
    fid_semestre int,
    PRIMARY KEY(id_cursoxsemestre),
    FOREIGN KEY(fid_curso) REFERENCES curso(id_curso),
    FOREIGN KEY(fid_semestre) REFERENCES semestre(id_semestre),
    constraint curso_semestre_unico unique(fid_curso, fid_semestre)
)ENGINE = InnoDB;

create table cursoxalumnoxsemestre(
	id_cursoxalumnoxsemestre INT AUTO_INCREMENT,
    fid_alumno int,
    fid_cursoxsemestre INT,
    nota_final DECIMAL(5,1),
    vez int,
    primary key(id_cursoxalumnoxsemestre),
    foreign key(fid_alumno) references alumno(id_alumno),
    foreign key(fid_cursoxsemestre) references cursoxsemestre(id_cursoxsemestre),
    CONSTRAINT unica_vez_semestre UNIQUE (fid_alumno, fid_cursoxsemestre)
)engine = InnoDB;

create table cursoxdocentexsemestre(
    id_cursoxdocentexsemestre int auto_increment,
    fid_docente int,
    fid_cursoxsemestre int,
    media decimal,
    primary key(id_cursoxdocentexsemestre),
    foreign key(fid_cursoxsemestre) references cursoxsemestre(id_cursoxsemestre),
    foreign key(fid_docente) references docente(id_docente),
    constraint unica_vez_docente_semestre unique(fid_docente, fid_cursoxsemestre)
)engine = InnoDB;

CREATE TABLE biblioteca(
    id_biblioteca INT AUTO_INCREMENT,
	fid_encargado_biblioteca INT,
	fid_institucion INT, 
    nombre VARCHAR(100),
    capacidad INT,
	activo TINYINT, 
	PRIMARY KEY(id_biblioteca),
	FOREIGN KEY(fid_encargado_biblioteca) REFERENCES encargadoBiblioteca(id_encargado_biblioteca),
	FOREIGN KEY(fid_institucion) REFERENCES institucion(id_institucion)
)ENGINE = InnoDB;

CREATE TABLE recursoBiblioteca(
	id_recurso INT AUTO_INCREMENT,
    fid_biblioteca INT,
	disponible TINYINT,
	fecha_publicacion DATE,
    titulo VARCHAR(100),
    tipo_recurso CHAR(1),
    foto_portada LONGBLOB,
    ISBN VARCHAR(20),
    PRIMARY KEY(id_recurso),
    FOREIGN KEY(fid_biblioteca) REFERENCES biblioteca(id_biblioteca)
)ENGINE=InnoDB;

CREATE TABLE libro(
	id_libro INT,
    nroCopias INT,
    nroPaginas INT,
	activo TINYINT,
    PRIMARY KEY(id_libro),
    FOREIGN KEY(id_libro) REFERENCES recursoBiblioteca(id_recurso)
)ENGINE=InnoDB;

CREATE TABLE digital(
	id_digital INT,
	repositorio VARCHAR(50),
	descargable TINYINT,
    	URL VARCHAR(300),
	activo TINYINT,
	PRIMARY KEY(id_digital),
	FOREIGN KEY(id_digital) REFERENCES recursoBiblioteca(id_recurso)
)ENGINE=InnoDB;

CREATE TABLE horario(
	id_horario INT auto_increment,
    id_curso INT,
	codigo_horario VARCHAR(10),
    hora_inicio TIME,
    hora_fin TIME,
    dia_semana VARCHAR(15),
    vacantes INT,
    matriculados INT,
    tiempo_tolerancia INT,
    tipo_horario CHAR(1),
    activo TINYINT,
    PRIMARY KEY(id_horario),
    FOREIGN KEY(id_curso) REFERENCES curso(id_curso)
)ENGINE = InnoDB;

CREATE TABLE alumnoxhorario(
	id_alumno INT,
	id_horario INT,
	FOREIGN KEY(id_alumno) REFERENCES alumno(id_alumno),
	FOREIGN KEY(id_horario) REFERENCES horario(id_horario),
	constraint unica_vez_alumno_horario unique(id_alumno, id_horario)
)ENGINE = InnoDB;

CREATE TABLE espacio (
    id_espacio INT AUTO_INCREMENT, 
    fid_institucion INT,
    aforo INT,
    nombre VARCHAR(70),
    PRIMARY KEY(id_espacio), 
    FOREIGN KEY(fid_institucion) REFERENCES institucion(id_institucion)
)ENGINE = InnoDB;


CREATE TABLE aula (
	id_aula INT, 
	tiene_pizarra_inteligente TINYINT,
	tiene_proyector TINYINT, 
	activo TINYINT, 
	PRIMARY KEY(id_aula),
	FOREIGN KEY(id_aula) REFERENCES espacio(id_espacio)
)ENGINE = InnoDB;

CREATE TABLE sala (
    id_sala INT, 
	tipo_sala VARCHAR(70),
	tiene_sistema_audio TINYINT,
	activo TINYINT, 
	PRIMARY KEY(id_sala),
	FOREIGN KEY(id_sala) REFERENCES espacio(id_espacio)
)ENGINE = InnoDB;

CREATE TABLE aulaxhorario (
    id_horario INT,
    id_aula INT,
	activo INT, 
    FOREIGN KEY (id_horario) REFERENCES horario(id_horario),
    FOREIGN KEY (id_aula) REFERENCES aula(id_aula)
)ENGINE = InnoDB;

CREATE TABLE evento (
    id_evento INT AUTO_INCREMENT,
	nombre VARCHAR(150), 
	fid_espacio INT, 
	organizador VARCHAR(70), 
	fecha Date, 
	hora_inicio TIME, 
	hora_fin TIME,
	es_gratuito TINYINT, 
    inscritos INT,
	PRIMARY KEY(id_evento),
	FOREIGN KEY(fid_espacio) REFERENCES espacio(id_espacio) 
)ENGINE = InnoDB;

CREATE TABLE charla (
	id_charla INT,
	ponente VARCHAR(150), 
	activo TINYINT, 
	PRIMARY KEY(id_charla),
	FOREIGN KEY(id_charla) REFERENCES evento(id_evento)
)ENGINE = InnoDB;

CREATE TABLE taller (
    id_taller INT,
	area_interes VARCHAR(150), 
	activo TINYINT, 
	PRIMARY KEY(id_taller),
	FOREIGN KEY(id_taller) REFERENCES evento(id_evento)
)ENGINE = InnoDB;

CREATE TABLE evaluacion(
	id_evaluacion INT AUTO_INCREMENT,
	nombreEvaluacion VARCHAR(20),
	fid_idcursoxalumnoxsemestre INT,
	valorNota DECIMAL(6,2),
	asistio CHAR(1), -- F o A
	activo TINYINT,
	PRIMARY KEY(id_evaluacion),
	FOREIGN KEY(fid_idcursoxalumnoxsemestre) REFERENCES cursoxalumnoxsemestre(id_cursoxalumnoxsemestre),
	constraint unica_instancia_evaluacion_curso_alumno unique(nombreEvaluacion, fid_idcursoxalumnoxsemestre)
)ENGINE=InnoDB;

CREATE TABLE reclamo(
	id_reclamo INT,
	fecha DATE,
	es_valido TINYINT,
	descripcion VARCHAR(70),
	respuesta VARCHAR(70),
	activo TINYINT,
	PRIMARY KEY(id_reclamo),
	FOREIGN KEY(id_reclamo) REFERENCES evaluacion(id_evaluacion)
)ENGINE=InnoDB;

CREATE TABLE pago( 
	id_pago INT AUTO_INCREMENT,
	fid_alumno INT,
	DNI_responsable VARCHAR(9),
	nombre_responsable VARCHAR(50),
	PRIMARY KEY(id_pago),
	FOREIGN KEY(fid_alumno) REFERENCES alumno(id_alumno)
)ENGINE = InnoDB;

CREATE TABLE prestamo(

    id_prestamo int auto_increment,
    fecha_registro date,
    fecha_retiro date,
    fecha_maxima_devolucion date,
    fecha_devolucion_confirmada date,
    id_libro int,
    id_encargado_libro int,
    tipo_encargado char(1),
    id_biblioteca int,
    anulado tinyint,
    activo int,
    primary key(id_prestamo),
    foreign key(id_libro) references libro(id_libro),
    foreign key(id_encargado_libro) references usuario(id_usuario),
    foreign key(id_biblioteca) references biblioteca(id_biblioteca)

)ENGINE = INNODB;

CREATE TABLE historialAcademico(
	id_alumno INT,
    cantidad_cursos_total INT,
    cantidad_cursos_aprobados INT,
    cantidad_creditos_total DOUBLE,
    cantidad_creditos_aprobados DOUBLE,
    nivel_academico int,
    PRIMARY KEY(id_alumno),
    FOREIGN KEY(id_alumno) REFERENCES alumno(id_alumno)
)ENGINE = InnoDB;

create table docentexhorario(
	id_docente INT,
    id_horario INT,
    foreign key(id_docente) REFERENCES docente(id_docente),
    foreign key(id_horario) REFERENCES horario(id_horario),
    constraint unica_vez_docente_horario unique(id_docente, id_horario)
)engine = InnoDB;


create table autor(
	id_autor INT AUTO_INCREMENT,
	nombre VARCHAR(50),
    nacionalidad VARCHAR(30),
    activo TINYINT,
    PRIMARY KEY(id_autor)
)engine = InnoDB;

create table recursoxautor(
	id_recurso INT,
    id_autor INT,
    activo TINYINT,
    FOREIGN KEY(id_recurso) REFERENCES recursoBiblioteca(id_recurso),
    FOREIGN KEY(id_autor) REFERENCES autor(id_autor)
)ENGINE = InnoDB;


