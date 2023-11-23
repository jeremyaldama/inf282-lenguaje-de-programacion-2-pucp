drop procedure if exists ACTUALIZAR_ADMINISTRADOR;
drop procedure if exists ACTUALIZAR_ALUMNO;
drop procedure if exists ACTUALIZAR_DOCENTE;
drop procedure if exists ACTUALIZAR_ENCARGADO;
drop procedure if exists AGREGAR_ALUMNO_HORARIO;
drop procedure if exists AGREGAR_AUTOR_RECURSO;
drop procedure if exists AGREGAR_CURSO_CARRERA;
drop procedure if exists AGREGAR_CURSO_SEMESTRE;
drop procedure if exists AGREGAR_DOCENTE_HORARIO;
drop procedure if exists ANULAR_PRESTAMO;
drop procedure if exists ASOCIAR_AULA_A_HORARIO;
drop procedure if exists BUSCAR_FOTO_PERFIL;
drop procedure if exists CALCULAR_NOTA_FINAL;
drop procedure if exists DESASOCIAR_AULA_DE_HORARIO;
drop procedure if exists ELIMINAR_AULA;
drop procedure if exists ELIMINAR_AUTOR;
drop procedure if exists ELIMINAR_BIBLIOTECA;
drop procedure if exists ELIMINAR_CARRERA;
drop procedure if exists ELIMINAR_CHARLA;
drop procedure if exists ELIMINAR_DIGITAL;
drop procedure if exists ELIMINAR_EVALUACION;
drop procedure if exists ELIMINAR_FACULTAD;
drop procedure if exists ELIMINAR_HORARIO;
drop procedure if exists ELIMINAR_INSTITUCION;
drop procedure if exists ELIMINAR_LIBRO;
drop procedure if exists ELIMINAR_PRESTAMO;
drop procedure if exists ELIMINAR_RECLAMO;
drop procedure if exists ELIMINAR_SALA;
drop procedure if exists ELIMINAR_SEMESTRE;
drop procedure if exists ELIMINAR_TALLER;
drop procedure if exists HALLAR_ADMINISTRADOR_ID;
drop procedure if exists HALLAR_ALUMNO_ID;
drop procedure if exists HALLAR_DOCENTE_ID;
drop procedure if exists HALLAR_ENCARGADO_BIBLIOTECA_ID;
drop procedure if exists HALLAR_SALT;
drop procedure if exists INICIAR_SESION;
drop procedure if exists INSCRIBIRSE;
drop procedure if exists INSERTAR_ADMINISTRADOR;
drop procedure if exists INSERTAR_ALUMNO;
drop procedure if exists INSERTAR_AULA;
drop procedure if exists INSERTAR_AUTOR;
drop procedure if exists INSERTAR_BIBLIOTECA;
drop procedure if exists INSERTAR_CARRERA;
drop procedure if exists INSERTAR_CHARLA;
drop procedure if exists INSERTAR_CURSO;
drop procedure if exists INSERTAR_DIGITAL;
drop procedure if exists INSERTAR_DOCENTE;
drop procedure if exists INSERTAR_ENCARGADOBIBLIOTECA;
drop procedure if exists INSERTAR_EVALUACION;
drop procedure if exists INSERTAR_FACULTAD;
drop procedure if exists INSERTAR_HORARIO;
drop procedure if exists INSERTAR_INSTITUCION;
drop procedure if exists INSERTAR_LIBRO;
drop procedure if exists INSERTAR_PRESTAMO;
drop procedure if exists INSERTAR_RECLAMO;
drop procedure if exists INSERTAR_SALA;
drop procedure if exists INSERTAR_SEMESTRE;
drop procedure if exists INSERTAR_TALLER;
drop procedure if exists LISTAR_ADMINISTRADORES;
drop procedure if exists LISTAR_ALUMNOS_HORARIO;
drop procedure if exists LISTAR_ALUMNOS_X_CODIGO_NOMBRE;
drop procedure if exists LISTAR_AULAS_TODAS;
drop procedure if exists LISTAR_AUTORES_RECURSO;
drop procedure if exists LISTAR_AUTORES_TODOS;
drop procedure if exists LISTAR_AUTORES_X_NOMBRE;
drop procedure if exists LISTAR_BIBLIOTECAS_TODAS;
drop procedure if exists LISTAR_BIBLIOTECAS_X_ID_ENCARGADO;
drop procedure if exists LISTAR_CARRERAS_FACULTAD;
drop procedure if exists LISTAR_CARRERAS_TODAS;
drop procedure if exists LISTAR_CASS_X_ALUMNO_SEMESTRE;
drop procedure if exists LISTAR_CHARLAS_TODAS;
drop procedure if exists LISTAR_CURSOS_CODIGO_NOMBRE;
drop procedure if exists LISTAR_CURSOS_TODOS;
drop procedure if exists LISTAR_DIGITAL_TODOS;
drop procedure if exists LISTAR_DOCENTES_HORARIO;
drop procedure if exists LISTAR_DOCENTES_TODOS;
drop procedure if exists LISTAR_DOCENTES_X_NOMBRE;
drop procedure if exists LISTAR_ENCARGADOS;
drop procedure if exists LISTAR_ENCARGADO_USUARIONOMBRE;
drop procedure if exists LISTAR_ESPACIOS_POR_EVENTO;
drop procedure if exists LISTAR_ESTUDIANTES_X_NOMBRE;
drop procedure if exists LISTAR_EVALUACION_CURSO_SEMESTRE;
drop procedure if exists LISTAR_FACULTAD_TODAS;
drop procedure if exists LISTAR_HISTORIAL_X_ALUMNO;
drop procedure if exists LISTAR_HORARIOS_ALUMNO;
drop procedure if exists LISTAR_HORARIOS_CURSO;
drop procedure if exists LISTAR_HORARIOS_DOCENTE;
drop procedure if exists LISTAR_HORARIOS_POR_AULA;
drop procedure if exists LISTAR_HORARIOS_TODOS;
drop procedure if exists LISTAR_INSTITUCIONES_TODAS;
drop procedure if exists LISTAR_LIBROS_TODOS;
drop procedure if exists LISTAR_PRESTAMOS_CON_FILTROS;
drop procedure if exists LISTAR_PRESTAMOS_X_LIBRO;
drop procedure if exists LISTAR_RECLAMO_ALUMNO_SEMESTRE;
drop procedure if exists LISTAR_RECLAMO_CURSO_SEMESTRE;
drop procedure if exists LISTAR_RECURSOS_AUTOR;
drop procedure if exists LISTAR_RECURSOS_X_TITULO_AUTOR_DISPONIBILIDAD_BIBLIOTECA_TIPO;
drop procedure if exists LISTAR_SALAS_TODAS;
drop procedure if exists LISTAR_SEMESTRES_TODOS;
drop procedure if exists LISTAR_SEMESTRES_X_ALUMNO;
drop procedure if exists LISTAR_TALLERES_TODOS;
drop procedure if exists LLENAR_MEDIA_APROBADOS_HORARIO;
drop procedure if exists ListarEvaluacionesxAlumno;
drop procedure if exists MODIFICAR_AULA;
drop procedure if exists MODIFICAR_AUTOR;
drop procedure if exists MODIFICAR_BIBLIOTECA;
drop procedure if exists MODIFICAR_CARRERA;
drop procedure if exists MODIFICAR_CHARLA;
drop procedure if exists MODIFICAR_CURSO;
drop procedure if exists MODIFICAR_DIGITAL;
drop procedure if exists MODIFICAR_EVALUACION;
drop procedure if exists MODIFICAR_FACULTAD;
drop procedure if exists MODIFICAR_HORARIO;
drop procedure if exists MODIFICAR_INSTITUCION;
drop procedure if exists MODIFICAR_LIBRO;
drop procedure if exists MODIFICAR_NOMBRE_CURSO;
drop procedure if exists MODIFICAR_PERFIL;
drop procedure if exists MODIFICAR_PRESTAMO;
drop procedure if exists MODIFICAR_RECLAMO;
drop procedure if exists MODIFICAR_SALA;
drop procedure if exists MODIFICAR_SEMESTRE;
drop procedure if exists MODIFICAR_TALLER;
drop procedure if exists REGISTRAR_DEVOLUCION;
drop procedure if exists REGISTRAR_RETIRO;
drop procedure if exists REVISAR_PRESTAMOS_X_ANULAR;
drop procedure if exists REVISAR_USUARIOS_DEUDORES;
drop procedure if exists actualizar_contrasenha;
drop procedure if exists actualizar_correo;
drop procedure if exists actualizar_tipoDocente;
drop procedure if exists actualizar_usuario;
drop procedure if exists eliminar_Administrador;
drop procedure if exists eliminar_Alumno;
drop procedure if exists eliminar_Curso;
drop procedure if exists eliminar_Docente;
drop procedure if exists eliminar_ENCARGADOBIBLIOTECA;
drop procedure if exists infoAlumno;
drop procedure if exists listarAlumnosCursos;
drop procedure if exists listarCharlaXFecha;
drop procedure if exists listarCursosAlumnos;
drop procedure if exists listarCursosDocente;
drop procedure if exists listarTallerXFECHA;

DELIMITER $ 

CREATE PROCEDURE INICIAR_SESION(
	IN _usuario VARCHAR(100),
	IN _pass VARCHAR(100)
)BEGIN
	SELECT u.id_usuario, u.tipo_usuario, u.nombre, u.apellido_paterno,
	u.apellido_materno, u.correo_electronico
	FROM usuario u
	WHERE u.usuario = _usuario
	and u.pass = _pass
	and u.activo = 1;
END$


CREATE PROCEDURE HALLAR_SALT(
	IN _username VARCHAR(100)
)
BEGIN
	SELECT u.salt
    FROM usuario u
    WHERE u.usuario = _username
    LIMIT 1;
END$

CREATE PROCEDURE CALCULAR_NOTA_FINAL(
    IN _fid_idcursoxalumnoxsemestre INT,
    OUT nota_final DECIMAL(6,2)
)
BEGIN
    DECLARE total_value DECIMAL(6,2) DEFAULT 0;

    -- Calculate the total value considering conditions like attendance and weights
    SELECT COALESCE(SUM(
        CASE 
            WHEN asistio = 'A' AND nombreEvaluacion LIKE CONCAT('%','EX','%') THEN valorNota * 0.3 -- 30% cada examen
            WHEN asistio = 'A' AND nombreEvaluacion LIKE CONCAT('%','PC','%') THEN valorNota * 0.1 -- 40% pcs por 4 pcs 10% por pc
            ELSE 0 -- Other assessments not considered in this calculation
        END
    ), 0) INTO total_value
    FROM evaluacion
    WHERE fid_idcursoxalumnoxsemestre = _fid_idcursoxalumnoxsemestre
    AND activo = 1; -- Assuming an active flag

    -- Set the calculated total_value as nota_final
    SET nota_final = total_value;

END$

DELIMITER $
CREATE PROCEDURE HALLAR_DOCENTE_ID(IN _id_docente INT)
BEGIN
SELECT p.id_Usuario,
	p.foto_perfil,
        p.nombre as nombre_Docente,
        p.apellido_Paterno,
        p.apellido_Materno,
        p.usuario,
        p.pass,
		p.salt,
        p.correo_Electronico,
        e.hora_Entrada,
        e.hora_Salida,
        e.fecha_Contratacion,
        p.fecha_nacimiento,
        d.tipo_Docente,
		p.telefono,
		p.sexo,
        d.grado_academico,
        d.intereses_investigacion,
        d.oficina,
	d.fid_facultad,
	d.es_deudor_libros
FROM docente d
        INNER JOIN usuario p ON d.id_Docente = p.id_Usuario
        INNER JOIN empleado e ON d.id_Docente = e.id_Empleado
        WHERE  d.activo = 1 and d.id_docente = _id_docente;
END$

DELIMITER $
CREATE PROCEDURE HALLAR_ADMINISTRADOR_ID(
IN _id_administrador INT
)
BEGIN
SELECT p.id_Usuario,
        p.nombre as nombre_Administrador,
        p.apellido_Paterno,
        p.apellido_Materno
FROM usuario p
        INNER JOIN administrador a ON a.id_administrador = p.id_Usuario
        WHERE p.activo = 1 and a.id_administrador = _id_administrador;
END$

delimiter $
CREATE PROCEDURE ACTUALIZAR_DOCENTE(
	in _id_usuario INT,
	IN _nombre VARCHAR(100),
	in _apellidoPaterno varchar(100),
	in _apellidoMaterno varchar(100),
	in _usuario varchar(100),
	in _password varchar(100),
	in _correo varchar(100),
	in _grado_academico varchar(70),
    in _oficina varchar(20),
    in _intereses_investigacion varchar(100),
    in _tipo_docente varchar(50),
    in _fid_facultad int,
    in _salt VARCHAR(12),
	in _sexo CHAR(1),
	in _fecha_nacimiento DATE,
	in _horaEntrada time,
        in _horaSalida time,
        in _fechaContratacion date
)
BEGIN
UPDATE usuario set nombre = _nombre,
apellido_paterno = _apellidoPaterno,
apellido_materno = _apellidoMaterno,
salt = _salt,
usuario = _usuario, pass = _password, correo_electronico = _correo where id_usuario = _id_usuario;
update empleado set hora_entrada = _horaEntrada, hora_salida = _horaSalida, fecha_contratacion = _fechaContratacion
where id_empleado = _id_usuario;
UPDATE docente SET
grado_academico =  _grado_academico,
oficina = _oficina,
intereses_investigacion = _intereses_investigacion,
tipo_docente = _tipo_docente,
fid_facultad = _fid_facultad
WHERE id_docente = _id_usuario;
END$
DELIMITER $ 
CREATE PROCEDURE HALLAR_ALUMNO_ID(IN _id_alumno INT)
BEGIN
	SELECT u.id_usuario, u.sexo, u.nombre, u.apellido_paterno, u.apellido_materno, u.correo_electronico, u.pass, u.telefono, u.fecha_nacimiento, 
		u.usuario, u.salt, u.foto_perfil, a.fid_carrera, a.codigo_alumno, a.es_deudor_libros, c.creditos, c.cursos_totales, ha.cantidad_creditos_aprobados, ha.cantidad_creditos_total,
        ha.cantidad_cursos_aprobados, ha.cantidad_cursos_total, ha.nivel_academico
	FROM usuario u 
		INNER JOIN alumno a ON u.id_usuario = a.id_alumno 
        INNER JOIN carrera c ON a.fid_carrera = c.id_carrera
        INNER JOIN historialAcademico ha ON ha.id_alumno = a.id_alumno
	WHERE a.estado = 1 and u.id_usuario = _id_alumno;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_CURSOS_CODIGO_NOMBRE(
	in _nombre varchar(500)
)
BEGIN
 
	SELECT id_curso, codigo_curso, es_electivo, creditos, nombre
	FROM curso c
    WHERE activo = 1 and (c.nombre LIKE CONCAT('%',_nombre,'%') or
    c.codigo_curso like CONCAT('%',_nombre,'%'));
END$

CREATE PROCEDURE LISTAR_ENCARGADOS() BEGIN
SELECT p.id_Usuario,
        p.nombre as nombre_Encargado,
        p.apellido_Paterno,
        p.apellido_Materno,
        p.usuario,
        p.pass,
        p.correo_Electronico,
        e.hora_Entrada,
        e.hora_Salida,
        e.fecha_Contratacion,
        p.sexo
FROM encargadoBiblioteca d
        INNER JOIN usuario p ON d.id_encargado_biblioteca = p.id_Usuario
        INNER JOIN empleado e ON d.id_encargado_biblioteca = e.id_Empleado
WHERE d.activo = 1;
END $ 

Create procedure LISTAR_ENCARGADO_USUARIONOMBRE(
	in _usuarionombre varchar(50)
)
BEGIN
SELECT p.id_Usuario,
        p.nombre as nombre_Encargado,
        p.apellido_Paterno,
        p.apellido_Materno,
        p.usuario,
        p.pass,
        p.sexo,
        p.correo_Electronico,
        e.hora_Entrada,
        e.hora_Salida,
        e.fecha_Contratacion,
        d.titulo_trabajo,
        p.fecha_nacimiento
FROM encargadoBiblioteca d
        INNER JOIN usuario p ON d.id_encargado_biblioteca = p.id_Usuario
        INNER JOIN empleado e ON d.id_encargado_biblioteca = e.id_Empleado
WHERE d.activo = 1 and (p.usuario LIKE CONCAT('%',_usuarionombre,'%')) 
OR (p.nombre LIKE CONCAT('%',_usuarionombre,'%'));
END$

DELIMITER $ 
create procedure eliminar_ENCARGADOBIBLIOTECA(in _idencargadobiblioteca int) BEGIN
update encargadoBiblioteca
set activo = 0
where id_encargado_biblioteca = _idencargadobiblioteca;
END $ 

DROP PROCEDURE INSERTAR_ENCARGADOBIBLIOTECA;
DELIMITER $ 
CREATE PROCEDURE INSERTAR_ENCARGADOBIBLIOTECA(
        OUT _id_usuario INT,
        IN _nombre VARCHAR(100),
        in _apellidoPaterno varchar(100),
        in _apellidoMaterno varchar(100),
        in _usuario varchar(100),
        in _password varchar(100),
        in _correo varchar(100),
        in _horaEntrada time,
        in _horaSalida time,
        in _fechaContratacion date,
        in _sexo CHAR(1),
        in _salt varchar(12),
        in _fecha_nacimiento DATE,
        in _titulo_trabajo VARCHAR(50)
) BEGIN
INSERT INTO usuario(
                nombre,
                apellido_Paterno,
                apellido_Materno,
                usuario,
                pass,
                correo_Electronico,
                sexo,
                fecha_nacimiento,
                tipo_usuario,
		salt,
                activo
        )
VALUES(
                _nombre,
                _apellidoPaterno,
                _apellidoMaterno,
                _usuario,
                _password,
                _correo,
                _sexo,
                _fecha_nacimiento,
                'B',
		_salt,
                1
        );
SET _id_usuario = @@last_insert_id;
insert into empleado(
                id_Empleado,
                hora_Entrada,
                hora_Salida,
                fecha_Contratacion
        )
values (
                _id_usuario,
                _horaEntrada,
                _horaSalida,
                _fechaContratacion
        );
insert into encargadoBiblioteca(id_Encargado_Biblioteca,titulo_trabajo, activo)
values(_id_usuario,_titulo_trabajo, 1);
END $ 

DELIMITER $ 
CREATE PROCEDURE MODIFICAR_NOMBRE_CURSO(
        in _id_curso int,
        in _nombre date
) BEGIN
update curso
set nombre = _nombre
where id_curso = _id_curso;
END $ 


DELIMITER $ 
CREATE PROCEDURE MODIFICAR_PRESTAMO(
        in _id_prestamo int,
        in _fecha_registro date,
        in _fecha_maxima_devolucion date,
        in _fecha_retiro date,
        in _fecha_devolucion_confirmada date,
        in _anulado tinyint
)
BEGIN
	update PRESTAMO
	set fecha_registro = _fecha_registro, fecha_maxima_devolucion = _fecha_maxima_devolucion, fecha_retiro = _fecha_retiro, fecha_devolucion_confirmada = _fecha_devolucion_confirmada, anulado = _anulado
	where id_prestamo = _id_prestamo;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_PRESTAMOS_CON_FILTROS(
    IN _id_biblioteca INT,
    IN _id_responsable INT,
    IN _fecha_lim_inferior DATE,
    IN _fecha_lim_superior DATE,
    IN _anulado TINYINT,
    IN _devuelto TINYINT,
    IN _con_retraso TINYINT
)
BEGIN
    SELECT p.id_prestamo, p.id_libro, p.id_encargado_libro, p.tipo_encargado, p.fecha_retiro,p.fecha_devolucion_confirmada,p.fecha_maxima_devolucion,p.fecha_registro,p.anulado,
	r.titulo,r.disponible,r.fecha_publicacion as fecha_publicacion_libro,r.ISBN,r.foto_portada,
        b.id_biblioteca, b.nombre as nombre_biblioteca,
        l.nroCopias, l.nroPaginas
    FROM prestamo p
    INNER JOIN libro l ON p.id_libro = l.id_libro
    INNER JOIN recursoBiblioteca r ON p.id_libro = r.id_recurso
    INNER JOIN biblioteca b ON b.id_biblioteca = r.fid_biblioteca
    WHERE p.activo = 1 AND (_id_biblioteca = -1 OR p.id_biblioteca = _id_biblioteca) 
	AND (_id_responsable = -1 OR p.id_encargado_libro = _id_responsable)
        AND p.fecha_registro >= _fecha_lim_inferior AND p.fecha_registro <= _fecha_lim_superior
        AND (_anulado = 2 OR p.anulado = _anulado)
        AND (_devuelto = 2 OR (_devuelto = 0 AND p.fecha_devolucion_confirmada IS NULL) OR (_devuelto=1 AND p.fecha_devolucion_confirmada IS NOT NULL))
        AND (_con_retraso = 2 OR (_con_retraso = 0 AND ((p.fecha_devolucion_confirmada IS NULL AND p.fecha_maxima_devolucion >= CURDATE()) OR (p.fecha_devolucion_confirmada IS NOT NULL AND p.fecha_devolucion_confirmada <= p.fecha_maxima_devolucion)))
		OR (_con_retraso = 1 AND ((p.fecha_devolucion_confirmada IS NULL AND p.fecha_maxima_devolucion < CURDATE()) OR (p.fecha_devolucion_confirmada IS NOT NULL AND p.fecha_devolucion_confirmada > p.fecha_maxima_devolucion))))
    ORDER BY p.fecha_registro DESC;
END$

DELIMITER $ 
CREATE PROCEDURE ELIMINAR_PRESTAMO(
	in _id_prestamo int
)
BEGIN
update prestamo set activo = 0 where id_Prestamo = _id_prestamo;
update recursoBiblioteca r inner join prestamo p on r.id_recurso = p.id_libro
set r.disponible = 1 where p.id_prestamo = _id_prestamo;
END$ 


DELIMITER $ 
CREATE PROCEDURE INSERTAR_PRESTAMO(
        OUT _id_prestamo INT,
	in _dias_prestamo INT,
        in _id_libro int,
        in _id_encargado_libro int,
	in _tipo_encargado char(1),
        in _id_biblioteca int
) BEGIN
DECLARE _lib_disponible TINYINT;

SELECT disponible INTO _lib_disponible
FROM recursoBiblioteca WHERE id_recurso = _id_libro;

IF _lib_disponible = 1 THEN
	INSERT INTO prestamo(
		fecha_registro,
		fecha_maxima_devolucion,
		id_libro,
		id_encargado_libro,
		tipo_encargado,
		id_biblioteca,
		anulado,
		activo
	)
	VALUES(
		CURDATE(),
		DATE_ADD(CURDATE(),INTERVAL _dias_prestamo DAY),
		_id_libro,
		_id_encargado_libro,
		_tipo_encargado,
		_id_biblioteca,
		0,
		1
	);
	SET _id_prestamo = @@last_insert_id;
	UPDATE recursoBiblioteca SET disponible = 0 WHERE id_recurso = _id_libro;
ELSE
	SET _id_prestamo = 0;
	SIGNAL SQLSTATE '45000'
	SET MESSAGE_TEXT = 'El libro no se encuentra disponible para prestamos';
END IF;
END$

DELIMITER $ 
CREATE PROCEDURE LISTAR_ADMINISTRADORES() BEGIN
SELECT u.apellido_Paterno,
        u.apellido_Materno,
        u.nombre
from administrador a
        inner join usuario u on a.id_Administrador = u.id_Usuario;
END $ 

delimiter $ 
create procedure eliminar_Administrador(in _idAdministrador int) begin
UPDATE administrador
set activo = 0
where id_Administrador = _idAdministrador;
end $ 
create procedure listarAlumnosCursos(in _idCurso int) begin -- MODIFICAR PARA SEMESTRE
select u.nombre,
        u.apellido_paterno,
        a.codigo_alumno
from cursoxalumno l
        inner join alumno a on l.id_Alumno = a.idAlumno
        inner join usuario u ON u.id_usuario = a.id_alumno
WHERE l.id_Curso = _idCurso;
end $ 

create procedure eliminar_Curso(in _idCurso int) BEGIN
update curso
set activo = 0
where id_curso = _idCurso;
END $ 

DELIMITER $ 
CREATE PROCEDURE INSERTAR_CURSO(
        OUT _id_Curso INT,
        IN _codCurso VARCHAR(100),
        in _nombre varchar(50),
        in _es_electivo tinyint,
        in _creditos double
) BEGIN
INSERT INTO curso(codigo_curso, nombre, es_electivo, creditos, activo)
VALUES(_codCurso, _nombre, _es_electivo, _creditos, 1);
SET _id_Curso = @@last_insert_id;
END $ 

DELIMITER $ 
CREATE PROCEDURE MODIFICAR_CURSO(
        IN _id_Curso INT,
        IN _codCurso VARCHAR(100),
        in _nombre varchar(50),
        in _es_electivo tinyint,
        in _creditos double
)BEGIN
UPDATE curso
SET codigo_curso = _codCurso,
nombre = _nombre,
es_electivo = _es_electivo,
creditos = _creditos
WHERE id_curso = _id_Curso;
END $ 

DELIMITER $ 
create procedure eliminar_Alumno(in _idAlumno int) BEGIN
update alumno
set estado = 0
where id_Alumno = _idAlumno;
END $ 

DELIMITER $ 
CREATE PROCEDURE INSERTAR_ALUMNO(
        OUT _id_usuario INT,
        IN _nombre VARCHAR(100),
        in _apellidoPaterno varchar(100),
        in _apellidoMaterno varchar(100),
        in _usuario varchar(100),
        in _password varchar(100),
        in _correo varchar(100),
        IN _codigoAlumno varchar(100),
        in _sexo CHAR(1),
        in _fecha_nacimiento DATE,
	in _id_carrera INT,
	in _salt VARCHAR(12)
) BEGIN
INSERT INTO usuario(
                nombre,
                apellido_Paterno,
                apellido_Materno,
                usuario,
                pass,
                correo_Electronico,
                sexo,
                fecha_nacimiento,
                tipo_usuario,
		salt,
                activo
        )
VALUES(
                _nombre,
                _apellidoPaterno,
                _apellidoMaterno,
                _usuario,
                _password,
                _correo,
                _sexo,
                _fecha_nacimiento,
                'E',
		_salt,
                1
        );
SET _id_usuario = @@last_insert_id;
insert into alumno(id_Alumno, estado, codigo_Alumno,es_deudor_libros,fid_carrera)
values(_id_usuario, 1, _codigoAlumno,0,_id_carrera);
UPDATE facultad
SET inscritos = inscritos + 1
WHERE id_facultad = (SELECT fid_facultad FROM carrera WHERE id_carrera = _id_carrera);
END $ 
delimiter $
create procedure listarCursosAlumnos(in _idAlumno int) begin -- MODIFICAR
select c.codigo_curso,
        c.nombre,
        c.id_curso,
        c.creditos,
        s.id_semestre,
        s.semestre
from curso c
        inner join cursoxsemestre l on l.fid_Curso = c.id_curso
        inner join cursoxalumnoxsemestre m on m.fid_cursoxsemestre = l.id_cursoxsemestre
        inner join semestre s on s.id_semestre = l.fid_semestre
		where m.fid_Alumno = _idAlumno;
end $ 

delimiter $ 
create procedure listarCursosDocente(in _idDocente int) begin -- MODIFICAR
select c.codigo_Curso,
		c.id_curso,
        c.nombre,
        c.creditos,
        s.id_semestre,
        s.semestre
from curso c
inner join cursoxsemestre l on l.fid_Curso = c.id_curso
inner join cursoxdocentexsemestre m on l.id_cursoxsemestre = m.fid_cursoxsemestre
inner join semestre s on s.id_semestre = l.fid_semestre
where m.fid_docente = _idDocente;
end $ 

delimiter $ 
create procedure actualizar_tipoDocente(
        in _tipoDocente varchar(100),
        in _idDocente int
) begin
update docente
set tipoDocente = _tipoDocente
where id_Docente = _idDocente;
end $ 

delimiter $ 
create procedure actualizar_usuario(
        in _usuario varchar(100),
        in _idDocente int
) begin
update usuario
set usuario = _usuario
where id_Usuario = _idDocente;
end $ 

delimiter $ 
create procedure actualizar_contrasenha(
        in _password varchar(100),
        in _idDocente int
) begin
update usuario
set pass = _password
where id_Usuario = _idDocente;
end $ 

delimiter $ 
create procedure actualizar_correo(
        in _correo varchar(100),
        in _idDocente int
) begin
update usuario
set correoElectronico = _correo
where id_Usuario = _idDocente;
end $ 

CREATE PROCEDURE LISTAR_DOCENTES_X_NOMBRE(IN _nombre VARCHAR(100)) BEGIN
SELECT p.id_Usuario,
        p.nombre as nombre_Docente,
        p.apellido_Paterno,
        p.apellido_Materno,
        p.usuario,
        p.pass,
        p.correo_Electronico,
        e.hora_Entrada,
        e.hora_Salida,
        e.fecha_Contratacion,
        p.fecha_nacimiento,
        d.tipo_Docente,
		p.sexo,
        d.grado_academico,
        d.intereses_investigacion,
        d.oficina,
	d.es_deudor_libros,
        p.telefono,
	d.fid_facultad,
    f.nombre as nombre_facultad
FROM docente d
        INNER JOIN usuario p ON d.id_Docente = p.id_Usuario
        INNER JOIN empleado e ON d.id_Docente = e.id_Empleado
        INNER JOIN facultad f ON d.fid_facultad = f.id_facultad
        WHERE d.activo = 1
		and (p.nombre LIKE CONCAT('%',_nombre,'%') OR (CONCAT(p.nombre,' ',p.apellido_paterno) LIKE CONCAT('%',_nombre,'%')) OR (p.apellido_paterno LIKE CONCAT('%',_nombre,'%'))) and d.fid_facultad = f.id_facultad;
END $ 

CREATE PROCEDURE LISTAR_DOCENTES_TODOS() BEGIN
SELECT p.id_Usuario,
        p.nombre as nombre_Docente,
        p.apellido_Paterno,
        p.apellido_Materno,
        p.usuario,
        p.pass,
        p.correo_Electronico,
        e.hora_Entrada,
        e.hora_Salida,
        e.fecha_Contratacion,
        p.fecha_nacimiento,
        d.tipo_Docente,
		p.sexo,
        p.telefono,
        d.grado_academico,
        d.intereses_investigacion,
        d.oficina,
	d.fid_facultad
FROM docente d
        INNER JOIN usuario p ON d.id_Docente = p.id_Usuario
        INNER JOIN empleado e ON d.id_Docente = e.id_Empleado
        WHERE d.activo = 1;
END $ 

DELIMITER $ 
create procedure eliminar_Docente(in _idDocente int) BEGIN
update docente
set activo = 0
where id_Docente = _idDocente;
END $ 

DELIMITER $ 
CREATE PROCEDURE INSERTAR_ADMINISTRADOR(
        OUT _id_usuario INT,
        IN _nombre VARCHAR(100),
        in _apellidoPaterno varchar(100),
        in _apellidoMaterno varchar(100),
        in _usuario varchar(100),
        in _password varchar(100),
        in _correo varchar(100),
	in _salt varchar(12)
) BEGIN
INSERT INTO usuario(
                nombre,
                apellido_Paterno,
                apellido_Materno,
                usuario,
                pass,
                correo_Electronico,
                tipo_usuario,
		salt,
                activo
        )
VALUES(
                _nombre,
                _apellidoPaterno,
                _apellidoMaterno,
                _usuario,
                _password,
                _correo,
                'A',
		_salt,
                1
        );
SET _id_usuario = @@last_insert_id;
insert into administrador(id_Administrador, activo)
values(_id_usuario, 1);
END $ 

DELIMITER $ 
CREATE PROCEDURE INSERTAR_DOCENTE(
        OUT _id_usuario INT,
        IN _nombre VARCHAR(100),
        in _apellidoPaterno varchar(100),
        in _apellidoMaterno varchar(100),
        in _usuario varchar(100),
        in _password varchar(100),
        in _correo varchar(100),
        in _horaEntrada time,
        in _horaSalida time,
        in _fechaContratacion date,
        in _tipoDocente varchar(50),
        in _grado_academico varchar(70),
        in _oficina VARCHAR(20),
        in _intereses_investigacion VARCHAR(100),
        in _sexo CHAR(1),
        in _fecha_nacimiento DATE,
	in _id_facultad INT,
	in _salt varchar(12)
) BEGIN
INSERT INTO usuario(
                nombre,
                apellido_paterno,
                apellido_materno,
                usuario,
                pass,
                correo_electronico,
                sexo,
                fecha_nacimiento,
                tipo_usuario,
		salt,
                activo
        )
VALUES(
                _nombre,
                _apellidoPaterno,
                _apellidoMaterno,
                _usuario,
                _password,
                _correo,
                _sexo,
                _fecha_nacimiento,
                'D',
		_salt,
                1
        );
SET _id_usuario = @@last_insert_id;
insert into empleado(
                id_Empleado,
                hora_Entrada,
                hora_Salida,
                fecha_Contratacion
        )
values (
                _id_usuario,
                _horaEntrada,
                _horaSalida,
                _fechaContratacion
        );
insert into docente(id_docente, tipo_docente,grado_academico,oficina,intereses_investigacion,fid_facultad, activo, es_deudor_libros)
values(_id_usuario, _tipoDocente,_grado_academico,_oficina,_intereses_investigacion,_id_facultad, 1, 0);
END $ 

CREATE PROCEDURE INSERTAR_FACULTAD(
        OUT _id_facultad INT,
        IN _nombre VARCHAR(100),
        IN _anexo VARCHAR(100),
        IN _inscritos INT
) BEGIN
INSERT INTO facultad(nombre, anexo, inscritos,fid_institucion, activa)
VALUES (_nombre, _anexo, 0,1, 1);
SET _id_facultad = @@last_insert_id;
END $ 

CREATE PROCEDURE INSERTAR_INSTITUCION(
        OUT _id_institucion INT,
        IN _direccion VARCHAR(100),
        IN _nombre VARCHAR(100),
        IN _telefono VARCHAR(100),
        IN _aforo INT
) BEGIN
INSERT INTO institucion(direccion, nombre, telefono, aforo, activa)
VALUES(_direccion, _nombre, _telefono, _aforo, 1);
SET _id_institucion = @@last_insert_id;
END $ 
CREATE PROCEDURE AGREGAR_CURSO_CARRERA(
        IN _id_curso INT,
        IN _id_carrera INT
) BEGIN
INSERT INTO cursoxcarrera(id_curso, id_carrera)
VALUES(_id_curso, _id_carrera);
END $ 
CREATE PROCEDURE INSERTAR_HORARIO(
        OUT _id_horario INT,
        IN _id_curso INT,
        IN _codigo_horario VARCHAR(10),
        IN _hora_inicio TIME,
        IN _hora_fin TIME,
        IN _dia_semana VARCHAR(15),
        IN _vacantes INT,
        IN _matriculados INT,
        IN _tiempo_tolerancia INT,
        IN _tipo_horario CHAR(1)
) BEGIN
INSERT INTO horario(
                id_curso,
                codigo_horario,
                hora_inicio,
                hora_fin,
                dia_semana,
                vacantes,
                matriculados,
                tiempo_tolerancia,
                tipo_horario,
                activo
        )
VALUES(
                _id_curso,
                _codigo_horario,
                _hora_inicio,
                _hora_fin,
                _dia_semana,
                _vacantes,
                _matriculados,
                _tiempo_tolerancia,
                _tipo_horario,
                1
        );
SET _id_horario = @@last_insert_id;
END $

DELIMITER $
CREATE PROCEDURE MODIFICAR_PERFIL(
	IN _id_usuario INT,
	IN _correo_electronico VARCHAR(100),
    IN _telefono VARCHAR(100),
    IN _contrasenia VARCHAR(100),
    IN _foto_perfil LONGBLOB
) BEGIN
UPDATE usuario
SET correo_electronico = _correo_electronico,
	telefono = _telefono,
    pass = _contrasenia,
    foto_perfil = _foto_perfil
WHERE id_usuario = _id_usuario;
END$


CREATE PROCEDURE MODIFICAR_HORARIO(
        IN _id_horario INT,
        IN _hora_inicio TIME,
        IN _hora_fin TIME,
        IN _dia_semana VARCHAR(15),
        IN _vacantes INT,
        IN _matriculados INT
) BEGIN
UPDATE horario
SET hora_inicio = _hora_inicio,
        hora_fin = _hora_fin,
        dia_semana = _dia_semana,
        vacantes = _vacantes,
        matriculados = _matriculados
WHERE id_horario = _id_horario;
END $ 
CREATE PROCEDURE ELIMINAR_HORARIO(IN _id_horario INT) BEGIN
UPDATE horario
SET activo = 0
WHERE id_horario = _id_horario;
END $ 
CREATE PROCEDURE INSERTAR_CARRERA(
        OUT _id_carrera INT,
        IN _id_facultad INT,
        IN _nombre VARCHAR(30),
        IN _acreditada TINYINT,
        IN _ultimo_cambio_malla DATE,
        IN _creditos DECIMAL
) BEGIN
INSERT INTO carrera(
                fid_facultad,
                nombre,
                acreditada,
                ultimo_cambio_malla,
                creditos,
                activo
        )
VALUES(
                _id_facultad,
                _nombre,
                _acreditada,
                _ultimo_cambio_malla,
                _creditos,
                1
        );
SET _id_carrera = @@last_insert_id;
END $ 

DELIMITER $
CREATE PROCEDURE MODIFICAR_CARRERA(
        IN _id_carrera INT,
        IN _ultimo_cambio_malla DATE,
        IN _acreditada TINYINT,
        IN _creditos DECIMAL,
        IN _nombre VARCHAR(30)
) BEGIN
UPDATE carrera
SET ultimo_cambio_malla = _ultimo_cambio_malla,
        acreditada = _acreditada,
        nombre = _nombre,
        creditos = _creditos
WHERE id_carrera = _id_carrera;
END $ 
CREATE PROCEDURE ELIMINAR_CARRERA(IN _id_carrera INT) BEGIN
UPDATE carrera
SET activo = 0
WHERE id_carrera = _id_carrera;
END $ 
CREATE PROCEDURE LISTAR_CARRERAS_TODAS() BEGIN
SELECT c.id_carrera,
        c.nombre as nombre_carrera,
        c.ultimo_cambio_malla,
        c.acreditada,
        c.creditos,
        f.id_facultad,
        f.nombre as nombre_facultad
FROM carrera c
        INNER JOIN facultad f ON c.fid_facultad = f.id_facultad
WHERE c.activo = 1;
END $ 
CREATE PROCEDURE LISTAR_CARRERAS_FACULTAD(IN _id_facultad int) BEGIN
SELECT c.id_carrera,
        c.nombre as nombre_carrera,
        c.ultimo_cambio_malla,
        c.acreditada,
        f.id_facultad,
        c.creditos,
        f.nombre as nombre_facultad
FROM carrera c
INNER JOIN facultad f ON f.id_facultad = c.fid_facultad
WHERE c.activo = 1
        and c.fid_facultad = _id_facultad;
END $ 
CREATE PROCEDURE LISTAR_HORARIOS_CURSO(IN _id_curso INT) BEGIN
SELECT id_horario,
        codigo_horario,
        tipo_horario,
        dia_semana,
        hora_inicio,
        hora_fin,
        matriculados,
        tiempo_tolerancia
FROM horario h
WHERE id_curso = _id_curso;
END $ 

CREATE PROCEDURE LISTAR_HORARIOS_TODOS() BEGIN
SELECT id_horario,
        codigo_horario,
        tipo_horario,
        dia_semana,
        hora_inicio,
        hora_fin,
        matriculados,
        vacantes,
        tiempo_tolerancia,
        c.id_curso
FROM horario h, curso c
WHERE h.activo = 1 and c.id_curso = h.id_curso;
END$

DELIMITER $
CREATE PROCEDURE AGREGAR_ALUMNO_HORARIO(
		OUT _id_alumnoxcursoxsemestre INT, -- retornaaa
        IN _id_alumno INT,
        IN _id_horario INT
) BEGIN -- Verify if the horario is active
SELECT COUNT(*) INTO @count
FROM horario
WHERE id_horario = _id_horario
        AND activo = 1;
IF @count = 1 THEN
INSERT INTO alumnoxhorario(id_alumno, id_horario)
VALUES (_id_alumno, _id_horario);
INSERT INTO cursoxalumnoxsemestre(fid_cursoxsemestre, fid_alumno,vez) 
SELECT c.id_cursoxsemestre, a.id_alumno, 1
FROM cursoxsemestre c, alumnoxhorario a, horario h
WHERE h.id_curso = c.fid_curso and a.id_horario = h.id_horario
and a.id_alumno = _id_alumno and h.id_horario = _id_horario;
SET _id_alumnoxcursoxsemestre = @@last_insert_id;
update horario
set matriculados = (select count(*) from alumnoxhorario where id_horario = _id_horario)
where id_horario = _id_horario;
END IF;
END $ 

CREATE PROCEDURE AGREGAR_DOCENTE_HORARIO(
        IN _id_docente INT,
        IN _id_horario INT
) BEGIN -- Verify if the horario is active
SELECT COUNT(*) INTO @count
FROM horario
WHERE id_horario = _id_horario
        AND activo = 1;
IF @count = 1 THEN
INSERT INTO docentexhorario(id_docente, id_horario)
VALUES (_id_docente, _id_horario);
INSERT INTO cursoxdocentexsemestre(fid_cursoxsemestre, fid_docente) 
SELECT c.id_cursoxsemestre, a.id_docente
FROM cursoxsemestre c, docentexhorario a, horario h
WHERE h.id_curso = c.fid_curso and a.id_horario = h.id_horario
and a.id_horario = _id_horario and a.id_docente = _id_docente;
END IF;
END $

CREATE PROCEDURE LISTAR_HORARIOS_ALUMNO(
	IN _id_alumno INT
) BEGIN
	SELECT h.id_horario,
        codigo_horario,
        c.id_curso,
        c.codigo_curso,
        c.nombre as nombre_curso,
        tipo_horario,
        dia_semana,
        hora_inicio,
        hora_fin,
        matriculados,
        tiempo_tolerancia,
        s.semestre
	FROM horario h
		INNER JOIN alumnoxhorario ah ON ah.id_horario = h.id_horario
		INNER JOIN curso c ON h.id_curso = c.id_curso
		INNER JOIN cursoxsemestre cs ON cs.fid_curso = c.id_curso
		INNER JOIN semestre s ON s.id_semestre = cs.fid_semestre
	WHERE ah.id_alumno = _id_alumno AND s.semestre = (SELECT MAX(s2.semestre) FROM semestre s2) AND 
		h.activo = 1 AND c.activo = 1 AND s.activo = 1;
END $ 

DELIMITER $
CREATE PROCEDURE LISTAR_HORARIOS_DOCENTE(IN _id_docente INT) BEGIN
SELECT h.id_horario,
        codigo_horario,
        c.nombre as nombre_curso,
        c.id_curso,
        tipo_horario,
        dia_semana,
        hora_inicio,
        hora_fin,
        matriculados,
        tiempo_tolerancia
FROM horario h
inner join docentexhorario d on d.id_horario = h.id_horario 
inner join curso c on h.id_curso = c.id_curso
where d.id_docente = _id_docente;
END $ 
-- procedures de sala
DELIMITER ;

DELIMITER $ 
CREATE PROCEDURE INSERTAR_SALA(
        OUT _id_sala INT,
        IN _tipo_sala VARCHAR(70),
        IN _tiene_sistema_audio TINYINT,
        IN _fid_institucion INT,
        IN _aforo INT,
        IN _nombre VARCHAR(70)
) BEGIN
INSERT INTO espacio(fid_institucion, aforo, nombre)
VALUES(_fid_institucion, _aforo, _nombre);
SET _id_sala = @@last_insert_id;
INSERT INTO sala(id_sala, tipo_sala, tiene_sistema_audio, activo)
VALUES (_id_sala, _tipo_sala, _tiene_sistema_audio, 1);
END $ 

DELIMITER $ 
CREATE PROCEDURE MODIFICAR_SALA(
        IN _id_sala INT,
        IN _tipo_sala VARCHAR(70),
        IN _tiene_sistema_audio TINYINT,
        IN _fid_institucion INT,
        IN _aforo INT,
        IN _nombre VARCHAR(70)
) BEGIN
UPDATE espacio
SET aforo = _aforo,
        nombre = _nombre,
        fid_institucion = _fid_institucion
WHERE id_espacio = _id_sala;
UPDATE sala
SET tipo_sala = _tipo_sala,
        tiene_sistema_audio = _tiene_sistema_audio
WHERE id_sala = _id_sala;
END $ 

DELIMITER $ 
CREATE PROCEDURE ELIMINAR_SALA(IN _id_sala INT) BEGIN
UPDATE sala
SET activo = 0
WHERE id_sala = _id_sala;
END $ DELIMITER $ 
CREATE PROCEDURE LISTAR_SALAS_TODAS() BEGIN
SELECT e.id_espacio,
        e.nombre,
        e.fid_institucion,
        s.tipo_sala,
        s.tiene_sistema_audio,
        e.aforo
FROM sala s
        INNER JOIN espacio e ON s.id_sala = e.id_espacio
WHERE s.activo = 1;
END $ 

-- procedures de aula 
DELIMITER $ 
CREATE PROCEDURE INSERTAR_AULA(
        OUT _id_aula INT,
        IN _tiene_pizarra_inteligente TINYINT,
        IN _tiene_proyector TINYINT,
        IN _fid_institucion INT,
        IN _aforo INT,
        IN _nombre VARCHAR(70)
) BEGIN
INSERT INTO espacio(fid_institucion, aforo, nombre)
VALUES(_fid_institucion, _aforo, _nombre);
SET _id_aula = @@last_insert_id;
INSERT INTO aula(
                id_aula,
                tiene_pizarra_inteligente,
                tiene_proyector,
                activo
        )
VALUES (
                _id_aula,
                _tiene_pizarra_inteligente,
                _tiene_proyector,
                1
        );
END $ 

DELIMITER $ 
CREATE PROCEDURE MODIFICAR_AULA(
        IN _id_aula INT,
        IN _tiene_pizarra_inteligente TINYINT,
        IN _tiene_proyector TINYINT,
        IN _fid_institucion INT,
        IN _aforo INT,
        IN _nombre VARCHAR(70)
) BEGIN
UPDATE espacio
SET aforo = _aforo,
        nombre = _nombre,
        fid_institucion = _fid_institucion
WHERE id_espacio = _id_aula;
UPDATE aula
SET tiene_pizarra_inteligente = _tiene_pizarra_inteligente,
        tiene_proyector = _tiene_proyector
WHERE id_aula = _id_aula;
END $ 

DELIMITER $ 
CREATE PROCEDURE ELIMINAR_AULA(IN _id_aula INT) BEGIN
UPDATE aula
SET activo = 0
WHERE id_aula = _id_aula;
END $ 

DELIMITER $ 
CREATE PROCEDURE LISTAR_AULAS_TODAS() BEGIN
SELECT e.id_espacio,
        e.nombre,
        e.fid_institucion,
        a.tiene_pizarra_inteligente,
        a.tiene_proyector,
        e.aforo
FROM aula a
        INNER JOIN espacio e ON a.id_aula = e.id_espacio
WHERE a.activo = 1;
END $ 

-- procedures de charla  
DELIMITER $ 
CREATE PROCEDURE INSERTAR_CHARLA(
        OUT _id_charla INT,
        IN _fid_espacio INT,
        IN _ponente VARCHAR(150),
        IN _organizador VARCHAR(70),
        IN _nombre VARCHAR(150),
        IN _fecha DATE,
        IN _hora_inicio TIME,
        IN _hora_fin TIME,
        IN _es_gratuito TINYINT
) BEGIN
INSERT INTO evento(
                nombre,
                fid_espacio,
                organizador,
                fecha,
                hora_inicio,
                hora_fin,
                es_gratuito,
                inscritos
        )
VALUES(
                _nombre,
                _fid_espacio,
                _organizador,
                _fecha,
                _hora_inicio,
                _hora_fin,
                _es_gratuito,
				0
        );
SET _id_charla = @@last_insert_id;
INSERT INTO charla(id_charla, ponente, activo)
VALUES (_id_charla, _ponente, 1);
END $ 

DELIMITER $ 
CREATE PROCEDURE MODIFICAR_CHARLA(
        IN _id_charla INT,
        IN _fid_espacio INT,
        IN _ponente VARCHAR(150),
        IN _organizador VARCHAR(70),
        IN _nombre VARCHAR(150),
        IN _fecha DATE,
        IN _hora_inicio TIME,
        IN _hora_fin TIME,
        IN _es_gratuito TINYINT,
	IN _inscritos INT
) BEGIN
UPDATE evento
SET fid_espacio = _fid_espacio,
        nombre = _nombre,
        organizador = _organizador,
        fecha = _fecha,
        hora_inicio = _hora_inicio,
        hora_fin = _hora_fin,
        es_gratuito = _es_gratuito,
	inscritos = _inscritos
WHERE id_evento = _id_charla;
UPDATE charla
SET ponente = _ponente
WHERE id_charla = _id_charla;
END $ 

DELIMITER $ 
CREATE PROCEDURE ELIMINAR_CHARLA(IN _id_charla INT) BEGIN
UPDATE charla
SET activo = 0
WHERE id_charla = _id_charla;
END $

CREATE PROCEDURE LISTAR_CHARLAS_TODAS() BEGIN
SELECT ev.id_evento,
        ev.nombre AS nombre_evento,
        ev.organizador,
        ev.fecha,
        ev.hora_inicio,
        ev.hora_fin,
        ev.es_gratuito,
        ch.ponente,
        ev.inscritos,
        es.id_espacio,
        es.nombre AS nombre_espacio
FROM charla ch
        INNER JOIN evento ev ON ch.id_charla = ev.id_evento
        INNER JOIN espacio es ON ev.fid_espacio = es.id_espacio
WHERE ch.activo = 1;
END $ 

CREATE PROCEDURE listarCharlaXFecha(
	IN _fecha date
)
BEGIN
SELECT ev.id_evento,
        ev.nombre AS nombre_evento,
        ev.organizador,
        ev.fecha,
        ev.hora_inicio,
        ev.hora_fin,
        ev.es_gratuito,
        ch.ponente,
        es.id_espacio,
        es.nombre AS nombre_espacio,
        ev.inscritos
FROM charla ch
        INNER JOIN evento ev ON ch.id_charla = ev.id_evento
        INNER JOIN espacio es ON ev.fid_espacio = es.id_espacio
WHERE ch.activo = 1 and ev.fecha >= _fecha;
END$
-- procedures de taller

CREATE PROCEDURE INSCRIBIRSE(
	in _id_evento int
)
BEGIN

	Update evento set inscritos = inscritos + 1 where id_evento = _id_evento;


END$

DELIMITER $ 
CREATE PROCEDURE INSERTAR_TALLER(
        OUT _id_taller INT,
        IN _fid_espacio INT,
        IN _organizador VARCHAR(70),
        IN _nombre VARCHAR(150),
        IN _fecha DATE,
        IN _hora_inicio TIME,
        IN _hora_fin TIME,
        IN _es_gratuito TINYINT,
        IN _area_interes VARCHAR(150)
) BEGIN
INSERT INTO evento(
                nombre,
                fid_espacio,
                organizador,
                fecha,
                hora_inicio,
                hora_fin,
                es_gratuito,
                inscritos
        )
VALUES(
                _nombre,
                _fid_espacio,
                _organizador,
                _fecha,
                _hora_inicio,
                _hora_fin,
                _es_gratuito,
                0
        );
SET _id_taller = @@last_insert_id;
INSERT INTO taller(id_taller, area_interes, activo)
VALUES (_id_taller, _area_interes, 1);
END $ 

DELIMITER $ 
CREATE PROCEDURE MODIFICAR_TALLER(
        IN _id_taller INT,
        IN _fid_espacio INT,
        IN _organizador VARCHAR(70),
        IN _nombre VARCHAR(150),
        IN _fecha DATE,
        IN _hora_inicio TIME,
        IN _hora_fin TIME,
        IN _es_gratuito TINYINT,
        IN _area_interes VARCHAR(150),
	IN _inscritos INT
) BEGIN
UPDATE evento
SET fid_espacio = _fid_espacio,
        nombre = _nombre,
        organizador = _organizador,
        fecha = _fecha,
        hora_inicio = _hora_inicio,
        hora_fin = _hora_fin,
        es_gratuito = _es_gratuito,
	inscritos = _inscritos
WHERE id_evento = _id_taller;
UPDATE taller
SET area_interes = _area_interes
WHERE id_taller = _id_taller;
END $ DELIMITER $ 
CREATE PROCEDURE ELIMINAR_TALLER(IN _id_taller INT) BEGIN
UPDATE taller
SET activo = 0
WHERE id_taller = _id_taller;
END $ 

DELIMITER $ 
CREATE PROCEDURE LISTAR_TALLERES_TODOS() BEGIN
SELECT ev.id_evento,
        ev.nombre AS nombre_evento,
        ev.organizador,
        ev.fecha,
        ev.hora_inicio,
        ev.hora_fin,
        ev.es_gratuito,
        ta.area_interes,
        es.id_espacio,
        ev.inscritos,
        es.nombre AS nombre_espacio
FROM taller ta
        INNER JOIN evento ev ON ta.id_taller = ev.id_evento
        INNER JOIN espacio es ON ev.fid_espacio = es.id_espacio
WHERE ta.activo = 1;
END $ 

CREATE PROCEDURE listarTallerXFECHA(
	in _fecha date
)
BEGIN
SELECT ev.id_evento,
        ev.nombre AS nombre_evento,
        ev.organizador,
        ev.fecha,
        ev.hora_inicio,
        ev.hora_fin,
        ev.es_gratuito,
        ta.area_interes,
        es.id_espacio,
        es.nombre AS nombre_espacio,
        ev.inscritos
FROM taller ta
        INNER JOIN evento ev ON ta.id_taller = ev.id_evento
        INNER JOIN espacio es ON ev.fid_espacio = es.id_espacio
WHERE ta.activo = 1 and ev.fecha >= _fecha;
END$

-- procedure espacioxevento
DELIMITER $ 
CREATE PROCEDURE LISTAR_ESPACIOS_POR_EVENTO(IN _id_espacio INT) BEGIN
SELECT ev.organizador,
        es.nombre,
        ev.fecha,
        ev.hora_inicio,
        ev.hora_fin,
        es.aforo,
        ev.es_gratuito
FROM evento ev
        INNER JOIN espacio es ON es.id_espacio = ev.fid_espacio
WHERE ev.fid_espacio = _id_espacio;
END $ 

-- procedure aulaxhorario
DELIMITER $ 
CREATE PROCEDURE LISTAR_HORARIOS_POR_AULA(IN _id_aula INT) BEGIN
SELECT h.id_horario,
        a.id_aula,
        h.codigo_horario,
        h.dia_semana,
        h.hora_inicio,
        h.hora_fin,
        h.tipo_horario,
        a.tiene_pizarra_inteligente,
        a.tiene_proyector
FROM aula a
        INNER JOIN aulaxhorario ON a.id_aula = aulaxhorario.id_aula
        INNER JOIN horario h ON h.id_horario = aulaxhorario.id_horario
WHERE a.id_aula = _id_aula
        AND aulaxhorario.activo = 1;
END $ 

DELIMITER $ 
CREATE PROCEDURE ASOCIAR_AULA_A_HORARIO(IN _id_horario INT, IN _id_aula INT) BEGIN
INSERT INTO aulaxhorario (id_horario, id_aula, activo)
VALUES (_id_horario, _id_aula, 1);
END $ 
CREATE PROCEDURE DESASOCIAR_AULA_DE_HORARIO(IN _id_horario INT, IN _id_aula INT) BEGIN
UPDATE aulaxhorario
SET activo = 0
WHERE id_horario = _id_horario
        AND id_aula = _id_aula;
END $ 

-- procedure biblioteca

DELIMITER $ 
CREATE PROCEDURE INSERTAR_BIBLIOTECA(
		OUT _id_biblioteca INT,
        IN _fid_encargado_biblioteca INT,
        IN _nombre VARCHAR(100),
        IN _capacidad INT,
        IN _fid_institucion INT
) BEGIN
INSERT INTO biblioteca(fid_encargado_biblioteca, nombre, capacidad,fid_institucion, activo)
VALUES(_fid_encargado_biblioteca, _nombre, _capacidad,_fid_institucion, 1);
SET _id_biblioteca = @@last_insert_id;
END $ 

DELIMITER $ 
CREATE PROCEDURE MODIFICAR_BIBLIOTECA(
        IN _id_biblioteca INT,
        IN _fid_encargado_biblioteca INT,
        IN _nombre VARCHAR(100),
        IN _capacidad INT
) BEGIN
UPDATE biblioteca
SET fid_encargado_biblioteca = _fid_encargado_biblioteca,
        nombre = _nombre,
        capacidad = _capacidad
WHERE id_biblioteca = _id_biblioteca;
END $ 

DELIMITER $ 
CREATE PROCEDURE ELIMINAR_BIBLIOTECA(IN _id_biblioteca INT) BEGIN
UPDATE biblioteca
SET activo = 0
WHERE id_biblioteca = _id_biblioteca;
END $ 

DELIMITER $ 
CREATE PROCEDURE LISTAR_BIBLIOTECAS_TODAS() BEGIN
SELECT b.id_biblioteca,
        b.nombre AS nombre_biblioteca,
        e.id_encargado_biblioteca,
        u.nombre AS nombre_encargado,
        u.apellido_paterno,
        b.capacidad
FROM biblioteca b
        INNER JOIN encargadoBiblioteca e ON b.fid_encargado_biblioteca = e.id_encargado_biblioteca
        INNER JOIN usuario u ON u.id_usuario = e.id_encargado_biblioteca
WHERE b.activo = 1;
END $ 
 
-- Procedures libro
DELIMITER $
CREATE PROCEDURE INSERTAR_LIBRO(
        OUT _id_libro INT,
        IN _fid_biblioteca INT,
        IN _titulo VARCHAR(60),
	IN _disponible TINYINT,
        IN _nroCopias INT,
        IN _nroPaginas INT,
        IN _ISBN VARCHAR(20),
        IN _fecha_publicacion DATE,
	IN _tipo_recurso CHAR(1),
        IN _foto_portada LONGBLOB
)
BEGIN
	INSERT INTO recursoBiblioteca(fid_biblioteca, disponible, titulo,fecha_publicacion,tipo_recurso,ISBN,foto_portada) VALUES(_fid_biblioteca, _disponible, _titulo,_fecha_publicacion,_tipo_recurso,_ISBN,_foto_portada);
	SET _id_libro = @@last_insert_id;
	INSERT INTO libro(id_libro, nroCopias, nroPaginas, activo) VALUES(_id_libro, _nroCopias, _nroPaginas, 1);
END$

DELIMITER $
CREATE PROCEDURE MODIFICAR_LIBRO(
        IN _id_libro INT,
        IN _fid_biblioteca INT,
        IN _disponible TINYINT,
        IN _titulo VARCHAR(60),
	IN _fecha_publicacion DATE,
        IN _nroCopias INT,
        IN _nroPaginas INT,
        IN _ISBN VARCHAR(20),
        IN _foto_portada LONGBLOB
)
BEGIN
	UPDATE recursoBiblioteca SET fid_biblioteca = _fid_biblioteca, disponible = _disponible, titulo = _titulo, fecha_publicacion = _fecha_publicacion, ISBN = _ISBN, foto_portada = _foto_portada
	WHERE id_recurso = _id_libro;
	UPDATE libro SET nroCopias = _nroCopias, nroPaginas = _nroPaginas
	WHERE id_libro = _id_libro;
    UPDATE recursoxautor SET activo = 0 WHERE id_recurso = _id_libro;
END$

CREATE PROCEDURE LISTAR_AUTORES_RECURSO(
	IN _id_recurso INT
)
BEGIN 
	SELECT a.id_autor,a.nombre,a.nacionalidad  FROM autor a, recursoxautor x
    WHERE a.id_autor = x.id_autor and x.id_recurso = _id_recurso and x.activo = 1;
END$

CREATE PROCEDURE LISTAR_RECURSOS_AUTOR(
	IN _id_autor INT
)
BEGIN 
	SELECT r.id_recurso, r.titulo, r.fecha_publicacion, r.disponible FROM recursoBiblioteca r, recursoxautor x
    WHERE _id_autor = x.id_autor and x.id_recurso = r.id_recurso;
END$

CREATE PROCEDURE ELIMINAR_LIBRO(
	IN _id_libro INT
)
BEGIN
	UPDATE libro SET activo = 0 WHERE id_libro = _id_libro;
    UPDATE recursoxautor SET activo = 0 WHERE id_recurso = _id_libro;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_LIBROS_TODOS()
BEGIN
	SELECT l.id_libro,
		r.titulo,
		r.fecha_publicacion,
		r.tipo_recurso,
		l.nroCopias,
		l.nroPaginas,
		r.ISBN,
		b.id_biblioteca,
		b.nombre AS nombre_biblioteca,
		r.disponible,
            	r.foto_portada
	FROM libro l
	INNER JOIN recursoBiblioteca r ON l.id_libro = r.id_recurso
	INNER JOIN biblioteca b ON r.fid_biblioteca = b.id_biblioteca
	WHERE l.activo = 1;
END$

-- Procedures digital

DELIMITER $
CREATE PROCEDURE INSERTAR_DIGITAL(
        OUT _id_digital INT,
        IN _fid_biblioteca INT,
	IN _disponible TINYINT,
        IN _titulo VARCHAR(60),
        IN _repositorio VARCHAR(50),
        IN _fecha_publicacion DATE,
        IN _descargable TINYINT,
        IN _tipo_recurso CHAR(1),
        IN _foto_portada LONGBLOB,
        IN _ISBN VARCHAR(20),
        IN _URL VARCHAR(300)
)
BEGIN
	INSERT INTO recursoBiblioteca(fid_biblioteca, disponible, titulo,fecha_publicacion,tipo_recurso,foto_portada,ISBN) VALUES(_fid_biblioteca, _disponible, _titulo,_fecha_publicacion,_tipo_recurso,_foto_portada,_ISBN);
	SET _id_digital = @@last_insert_id;
	INSERT INTO digital(id_digital, repositorio, descargable,URL, activo) VALUES(_id_digital, _repositorio, _descargable,_URL,1);
END$

DELIMITER $
CREATE PROCEDURE MODIFICAR_DIGITAL(
        IN _id_digital INT,
        IN _fid_biblioteca INT,
        IN _disponible TINYINT,
        IN _titulo VARCHAR(60),
	IN _fecha_publicacion DATE,
        IN _repositorio VARCHAR(50),
        IN _descargable TINYINT,
        IN _foto_portada LONGBLOB,
        IN _ISBN VARCHAR(20),
        IN _URL VARCHAR(300)
)
BEGIN
	UPDATE recursoBiblioteca SET fid_biblioteca = _fid_biblioteca, disponible = _disponible, titulo = _titulo, fecha_publicacion = _fecha_publicacion, ISBN = _ISBN, foto_portada = _foto_portada
	WHERE id_recurso = _id_digital;
	UPDATE digital SET repositorio = _repositorio, descargable = _descargable, URL = _URL
	WHERE id_digital = _id_digital;
    UPDATE recursoxautor SET activo = 0 WHERE id_recurso = _id_digital;
END$

DELIMITER $
CREATE PROCEDURE ELIMINAR_DIGITAL(
	IN _id_digital INT
)
BEGIN
	UPDATE digital SET activo = 0 WHERE id_digital = _id_digital;
    UPDATE recursoxautor SET activo = 0 WHERE id_recurso = _id_digital;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_DIGITAL_TODOS()
BEGIN
SELECT d.id_digital,
        r.titulo,
	r.fecha_publicacion,
        r.tipo_recurso,
        d.repositorio,
        d.descargable,
        b.id_biblioteca,
        b.nombre AS nombre_biblioteca,
        r.disponible,
        r.ISBN,
        r.foto_portada,
        d.URL
FROM digital d
        INNER JOIN recursoBiblioteca r ON d.id_digital = r.id_recurso
        INNER JOIN biblioteca b ON r.fid_biblioteca = b.id_biblioteca
WHERE d.activo = 1;
END$
 
-- Procedures evaluacion
DELIMITER $ 
CREATE PROCEDURE INSERTAR_EVALUACION(
        OUT _id_evaluacion INT,
        IN _fid_cursoxalumnoxsemestre INT,
        IN _nombreEvaluacion VARCHAR(20),
        IN _valorNota DECIMAL(6, 2),
        IN _asistio CHAR(1)
) BEGIN
INSERT INTO evaluacion(
                fid_idcursoxalumnoxsemestre,
                nombreEvaluacion,
                valorNota,
                asistio,
                activo
        )
VALUES(
                _fid_cursoxalumnoxsemestre,
                _nombreEvaluacion,
                _valorNota,
                _asistio,
                1
        );
SET _id_evaluacion = @@last_insert_id;
END $ 

delimiter $
CREATE PROCEDURE MODIFICAR_EVALUACION(
        IN _id_evaluacion INT,
        IN _nombreEvaluacion VARCHAR(20),
        IN _valorNota DECIMAL(6, 2),
        IN _asistio CHAR(1)
) BEGIN
UPDATE evaluacion
SET 
        nombreEvaluacion = _nombreEvaluacion,
        valorNota = _valorNota,
        asistio = _asistio
WHERE id_evaluacion = _id_evaluacion;
END $ 
CREATE PROCEDURE ELIMINAR_EVALUACION(IN _id_evaluacion INT) BEGIN
UPDATE evaluacion
SET activo = 0
WHERE id_evaluacion = _id_evaluacion;
END $ 

CREATE PROCEDURE ListarEvaluacionesxAlumno(
          IN _id_alumno INT
)
BEGIN
SELECT s.semestre AS semestre,
        c.codigo_curso,
        c.nombre AS nombre_curso,
        a.codigo_alumno,
        u.nombre,
        u.apellido_paterno,
        u.apellido_materno,
        e.id_evaluacion,
        e.nombreEvaluacion,
        e.asistio,
        e.valorNota
FROM cursoxalumnoxsemestre cas
        INNER JOIN evaluacion e ON e.fid_idcursoxalumnoxsemestre = cas.id_cursoxalumnoxsemestre
        INNER JOIN cursoxsemestre m ON m.id_cursoxsemestre = cas.fid_cursoxsemestre
        INNER JOIN curso c ON c.id_curso = m.fid_curso
        INNER JOIN semestre s ON s.id_semestre = m.fid_semestre
        INNER JOIN alumno a ON a.id_alumno = cas.fid_alumno
        INNER JOIN usuario u ON u.id_usuario = a.id_alumno
WHERE e.activo = 1
        AND cas.fid_alumno = _id_alumno;
        
        
END$

DELIMITER $
CREATE PROCEDURE LISTAR_EVALUACION_CURSO_SEMESTRE(
        IN _id_curso INT,
        IN _id_semestre INT
) BEGIN
SELECT s.semestre AS semestre,
        c.codigo_curso,
        c.nombre AS nombre_curso,
        a.codigo_alumno,
        u.nombre,
        u.apellido_paterno,
        u.apellido_materno,
        e.id_evaluacion,
        e.nombreEvaluacion,
        e.asistio,
        e.valorNota
FROM evaluacion e
        INNER JOIN cursoxalumnoxsemestre cas ON e.fid_idcursoxalumnoxsemestre = cas.id_cursoxalumnoxsemestre
        INNER JOIN cursoxsemestre m ON m.id_cursoxsemestre = cas.fid_cursoxsemestre
        INNER JOIN curso c ON c.id_curso = m.fid_curso
        INNER JOIN semestre s ON s.id_semestre = m.fid_semestre
        INNER JOIN alumno a ON a.id_alumno = cas.fid_alumno
        INNER JOIN usuario u ON u.id_usuario = a.id_alumno
WHERE e.activo = 1
        AND m.fid_curso = _id_curso
        AND m.fid_semestre = _id_semestre;
END $ 

-- Procedures reclamo
DELIMITER $ 
CREATE PROCEDURE INSERTAR_RECLAMO(
        OUT _id_reclamo INT,
        IN _id_evaluacion INT,
        IN _fecha DATE,
        IN _descripcion VARCHAR(70)
) BEGIN
INSERT INTO reclamo(id_reclamo, fecha, es_valido, descripcion, activo)
VALUES(_id_evaluacion, _fecha, 0, _descripcion, 1);
SET _id_reclamo = _id_evaluacion;
END $ 

delimiter $
CREATE PROCEDURE MODIFICAR_RECLAMO(
        IN _id_reclamo INT,
        IN _fecha DATE,
        IN _es_valido TINYINT,
        IN _descripcion VARCHAR(70),
	IN _respuesta VARCHAR(70)
) BEGIN
UPDATE reclamo
SET fecha = _fecha,
        es_valido = _es_valido,
        descripcion = _descripcion,
	respuesta = _respuesta
WHERE id_reclamo = _id_reclamo;
END $ 

CREATE PROCEDURE ELIMINAR_RECLAMO(IN _id_reclamo INT) BEGIN
UPDATE reclamo
SET activo = 0
WHERE id_reclamo = _id_reclamo;
END $ 

CREATE PROCEDURE LISTAR_RECLAMO_CURSO_SEMESTRE(
	IN _id_curso INT,
	IN _id_semestre INT
) BEGIN
SELECT s.semestre AS semestre,
		c.codigo_curso,
        c.nombre AS nombre_curso,
        a.codigo_alumno,
        u.nombre,
        u.apellido_paterno,
        u.apellido_materno,
        e.id_evaluacion,
        e.nombreEvaluacion,
        e.asistio,
        e.valorNota,
        r.id_reclamo,
        r.fecha AS fecha_registro,
        r.descripcion,
        r.respuesta,
        r.es_valido
FROM reclamo r
		INNER JOIN evaluacion e ON r.id_reclamo = e.id_evaluacion
        INNER JOIN cursoxalumnoxsemestre cas ON e.fid_idcursoxalumnoxsemestre = cas.id_cursoxalumnoxsemestre
        INNER JOIN cursoxsemestre m ON m.id_cursoxsemestre = cas.fid_cursoxsemestre
        INNER JOIN curso c ON c.id_curso = m.fid_curso
        INNER JOIN semestre s ON s.id_semestre = m.fid_semestre
        INNER JOIN alumno a ON a.id_alumno = cas.fid_alumno
        INNER JOIN usuario u ON u.id_usuario = a.id_alumno
WHERE e.activo = 1 and r.activo = 1
        AND m.fid_curso = _id_curso
        AND m.fid_semestre = _id_semestre;
END $ 

DELIMITER $
CREATE PROCEDURE LISTAR_RECLAMO_ALUMNO_SEMESTRE(
        IN _id_alumno INT
)
BEGIN
SELECT s.semestre AS semestre,
        c.codigo_curso,
        c.nombre AS nombre_curso,
        a.codigo_alumno,
        u.nombre,
        u.apellido_paterno,
        u.apellido_materno,
        e.id_evaluacion,
        e.nombreEvaluacion,
        e.asistio,
        r.id_reclamo,
        r.fecha AS fecha_registro,
        r.descripcion,
        r.respuesta,
        r.es_valido
FROM reclamo r
        INNER JOIN evaluacion e ON e.id_evaluacion = r.id_reclamo
        INNER JOIN cursoxalumnoxsemestre cas ON e.fid_idcursoxalumnoxsemestre = cas.id_cursoxalumnoxsemestre
        INNER JOIN cursoxsemestre m ON m.id_cursoxsemestre = cas.fid_cursoxsemestre
        INNER JOIN curso c ON c.id_curso = m.fid_curso
        INNER JOIN semestre s ON s.id_semestre = m.fid_semestre
        INNER JOIN alumno a ON a.id_alumno = cas.fid_alumno
        INNER JOIN usuario u ON u.id_usuario = a.id_alumno
        
WHERE r.activo = 1
        AND cas.fid_alumno = _id_alumno;
END $

DELIMITER $ 
CREATE PROCEDURE ELIMINAR_FACULTAD(in _idFacultad int) 
BEGIN
	UPDATE facultad
	SET activa = 0
	WHERE id_facultad = _idFacultad;
END $
DELIMITER $
CREATE PROCEDURE LISTAR_FACULTAD_TODAS() BEGIN
SELECT id_facultad, nombre, anexo, inscritos
FROM facultad f
WHERE f.activa = 1;
END $
DELIMITER $
CREATE PROCEDURE MODIFICAR_FACULTAD(
	IN _id_facultad INT,
	IN _nombre VARCHAR(100),
	IN _anexo VARCHAR(100),
    IN _inscritos INT
) BEGIN
UPDATE facultad
SET nombre = _nombre,
    anexo = _anexo,
    inscritos = _inscritos
WHERE id_facultad = _id_facultad;
END $
DELIMITER $
CREATE PROCEDURE LISTAR_INSTITUCIONES_TODAS() BEGIN
SELECT i.id_institucion,
        i.direccion,
        i.nombre,
        i.telefono,
        i.aforo
FROM institucion i
WHERE i.activa = 1;
END $
DELIMITER $
CREATE PROCEDURE ELIMINAR_INSTITUCION(
	IN _id_institucion INT
) 
BEGIN
	UPDATE institucion
    SET activa = 0
    WHERE id_institucion = _id_institucion;
END$
DELIMITER $
CREATE PROCEDURE MODIFICAR_INSTITUCION(
        IN _id_institucion INT,
        IN _direccion VARCHAR(100),
        IN _nombre VARCHAR(100),
        IN _telefono VARCHAR(100),
        IN _aforo INT
) BEGIN
UPDATE institucion
SET direccion = _direccion,
        nombre = _nombre,
        telefono = _telefono,
        aforo = _aforo
WHERE id_institucion = _id_institucion;
END $
-- SEMESTRE
DELIMITER $
CREATE PROCEDURE INSERTAR_SEMESTRE(
        OUT _id_semestre INT,
        IN _semestre VARCHAR(50),
        IN _es_regular TINYINT,
        IN _fecha_inicio DATE,
        IN _fecha_fin DATE
) BEGIN
INSERT INTO semestre(semestre, es_regular, fecha_inicio, fecha_fin, activo)
VALUES(_semestre, _es_regular, _fecha_inicio, _fecha_fin, 1);
SET _id_semestre = @@last_insert_id;
END $

CREATE PROCEDURE LISTAR_SEMESTRES_TODOS() BEGIN
SELECT s.es_regular,
	s.fecha_inicio,
    s.fecha_fin,
    s.semestre,
    s.id_semestre
FROM semestre s
WHERE s.activo = 1;
END $
DELIMITER $
CREATE PROCEDURE ELIMINAR_SEMESTRE(
	IN _id_semestre INT
) 
BEGIN
	UPDATE semestre
    SET activo = 0
    WHERE id_semestre = _id_semestre;
END$
DELIMITER $
CREATE PROCEDURE MODIFICAR_SEMESTRE(
        IN _id_semestre INT,
        IN _es_regular TINYINT,
        IN _fecha_inicio DATE,
        IN _fecha_fin DATE
) BEGIN
UPDATE semestre
SET es_regular = _es_regular,
        fecha_inicio = _fecha_inicio,
        fecha_fin = _fecha_fin
WHERE id_semestre = _id_semestre;
END $

CREATE PROCEDURE INSERTAR_AUTOR(
	OUT _id_autor INT,
	IN _nombre VARCHAR(50),
    IN _nacionalidad VARCHAR(30)
)
BEGIN 
	INSERT INTO autor(nombre,nacionalidad,activo) VALUES(_nombre,_nacionalidad,1);
    SET _id_autor = @@last_insert_id;
END$

CREATE PROCEDURE ELIMINAR_AUTOR(
	in _id_autor INT
)
BEGIN
	UPDATE autor 
    SET activo = 0
    WHERE id_autor = _id_autor;
END$

CREATE PROCEDURE LISTAR_AUTORES_TODOS()
BEGIN
SELECT a.id_autor,a.nombre, a.nacionalidad 
FROM autor a
WHERE a.activo = 1;
END$
CREATE PROCEDURE AGREGAR_AUTOR_RECURSO(
	IN _id_autor INT,
    IN _id_recurso INT)
BEGIN
	INSERT INTO recursoxautor(id_autor,id_recurso,activo) VALUES(_id_autor,_id_recurso,1);
END$

CREATE PROCEDURE AGREGAR_CURSO_SEMESTRE(
	IN _id_curso INT,
    IN _id_semestre INT
)
BEGIN 
	INSERT INTO cursoxsemestre(fid_curso,fid_semestre) VALUES (_id_curso,_id_semestre);
END$

CREATE PROCEDURE REGISTRAR_RETIRO(
	IN _id_prestamo INT
) 
BEGIN
	DECLARE _anulado INT;
    SELECT anulado INTO _anulado
    FROM prestamo WHERE id_prestamo = _id_prestamo;

    IF _anulado = 0 THEN
		UPDATE prestamo SET fecha_retiro = CURDATE() WHERE id_prestamo = _id_prestamo;
	ELSE
		SIGNAL SQLSTATE '46000'
		SET MESSAGE_TEXT = 'El prestamo ha sido anulado por exceder el tiempo para retirar el libro';
	END IF;
END$

DELIMITER $
CREATE PROCEDURE REGISTRAR_DEVOLUCION(
	IN _id_prestamo INT
)
BEGIN
	DECLARE _id_libro INT;
    	SELECT id_libro FROM prestamo WHERE id_prestamo = _id_prestamo AND activo = 1 INTO _id_libro;
    
	UPDATE prestamo SET fecha_devolucion_confirmada = CURDATE() WHERE id_prestamo = _id_prestamo AND activo = 1;
    	UPDATE recursoBiblioteca SET disponible = 1 WHERE id_recurso = _id_libro;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_RECURSOS_X_TITULO_AUTOR_DISPONIBILIDAD_BIBLIOTECA_TIPO(
	IN _titulo_autor VARCHAR(100),
	IN _disponibilidad TINYINT,
    	IN _id_biblioteca INT,
    	IN _tipo_recurso CHAR(1)
)
BEGIN
	SELECT DISTINCT r.id_recurso, r.disponible, r.fecha_publicacion, r.titulo,r.tipo_recurso,r.ISBN,r.foto_portada,
	    b.nombre as nombre_biblioteca, b.id_biblioteca,
	    rd.repositorio, rd.descargable,rd.URL,
	    rl.nroCopias, rl.nroPaginas
	    FROM recursoBiblioteca r
	    INNER JOIN biblioteca b ON r.fid_biblioteca = b.id_biblioteca
	    INNER JOIN recursoxautor rxa ON r.id_recurso = rxa.id_recurso
	    INNER JOIN autor a ON rxa.id_autor = a.id_autor
	    LEFT JOIN digital rd ON rd.id_digital = r.id_recurso
	    LEFT JOIN libro rl ON rl.id_libro = r.id_recurso
	    WHERE (rd.activo = 1 OR rl.activo = 1) AND (r.titulo LIKE CONCAT('%',_titulo_autor,'%')
			OR a.nombre LIKE CONCAT('%',_titulo_autor,'%')) AND rxa.activo = 1
	        AND (_id_biblioteca = -1 OR _id_biblioteca = b.id_biblioteca) AND (_disponibilidad = 2 OR _disponibilidad = r.disponible)
	        AND (_tipo_recurso = 'Z' OR r.tipo_recurso = _tipo_recurso);
END$


DELIMITER $
CREATE PROCEDURE LISTAR_BIBLIOTECAS_X_ID_ENCARGADO(
	IN _id_encargado INT
)
BEGIN
	SELECT id_biblioteca, fid_encargado_biblioteca, fid_institucion,nombre,capacidad FROM biblioteca 
    WHERE fid_encargado_biblioteca = _id_encargado AND activo = 1;
END$

DELIMITER $
CREATE PROCEDURE MODIFICAR_AUTOR(
	IN _id_autor INT,
    IN _nombre VARCHAR(50),
    IN _nacionalidad VARCHAR(30)
)
BEGIN 
UPDATE autor SET nombre = _nombre, nacionalidad = _nacionalidad
WHERE id_autor = _id_autor;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_AUTORES_X_NOMBRE(
	IN _nombre VARCHAR(50)
)
BEGIN 
	SELECT id_autor,nombre,nacionalidad FROM autor
    WHERE  (nombre LIKE CONCAT('%',_nombre,'%')) AND activo = 1;
END$

CREATE PROCEDURE LISTAR_ESTUDIANTES_X_NOMBRE(
	IN _nombre VARCHAR(100)
)
BEGIN
	SELECT a.id_alumno, a.codigo_alumno, u.nombre, u.apellido_paterno,u.apellido_materno from alumno a INNER JOIN usuario u ON a.id_alumno = u.id_usuario WHERE (u.nombre LIKE CONCAT('%',_nombre,'%')) OR (CONCAT(u.nombre,' ',u.apellido_paterno) LIKE CONCAT('%',_nombre,'%'));
END$

DELIMITER $
CREATE PROCEDURE LISTAR_CURSOS_TODOS() 
BEGIN
	SELECT id_curso, codigo_curso, es_electivo, creditos, nombre
	FROM curso c
    WHERE activo = 1;
END$

delimiter $
CREATE PROCEDURE ACTUALIZAR_ENCARGADO(
		in _id_usuario INT,
        IN _nombre VARCHAR(100),
        in _apellidoPaterno varchar(100),
        in _apellidoMaterno varchar(100),
        in _usuario varchar(100),
        in _password varchar(100),
        in _correo varchar(100),
        in _horaEntrada time,
        in _horaSalida time,
        in _fechaContratacion date,
        in _sexo CHAR(1),
        in _salt varchar(12),
        in _fecha_nacimiento DATE,
        IN  _titulo_trabajo VARCHAR(50)
)
BEGIN
	UPDATE usuario set nombre = _nombre,apellido_paterno = _apellidoPaterno, apellido_materno = _apellidoMaterno,
    usuario = _usuario, pass = _password, correo_electronico = _correo, salt = _salt,
    fecha_nacimiento = _fecha_nacimiento
    where id_usuario = _id_usuario;
    update empleado set hora_entrada = _horaEntrada, hora_salida = _horaSalida, fecha_contratacion = _fechaContratacion
    where id_empleado = _id_usuario;
	update encargadoBiblioteca
	set titulo_trabajo = _titulo_trabajo
	where id_encargado_biblioteca = _id_usuario;
END$

CREATE PROCEDURE LISTAR_ALUMNOS_X_CODIGO_NOMBRE(
	IN _codigo_nombre VARCHAR(500)
)
BEGIN
	SELECT u.id_usuario, u.sexo, u.nombre, u.apellido_paterno, u.apellido_materno,
    u.fecha_nacimiento, u.usuario, a.fid_carrera,c.nombre as nombre_carrera,
    f.id_facultad, f.nombre as nombre_facultad ,u.pass, u.correo_electronico,
    a.codigo_alumno,a.es_deudor_libros
    from usuario u INNER JOIN alumno a ON u.id_usuario = a.id_alumno 
    INNER JOIN carrera c ON c.id_carrera = a.fid_carrera
    INNER JOIN facultad f ON f.id_facultad = c.fid_facultad
    WHERE a.estado = 1
    and (a.codigo_alumno LIKE CONCAT('%',_codigo_nombre,'%') OR (u.nombre LIKE CONCAT('%',_codigo_nombre,'%')) OR (u.apellido_paterno LIKE CONCAT('%',_codigo_nombre,'%')) ) and c.id_carrera = fid_carrera and f.id_facultad = c.fid_facultad;
END$

CREATE PROCEDURE ACTUALIZAR_ADMINISTRADOR(
	in _id_usuario int,
    IN _nombre VARCHAR(100),
	in _apellidoPaterno varchar(100),
	in _apellidoMaterno varchar(100),
	in _usuario varchar(100),
	in _password varchar(100),
	in _correo varchar(100)
)
BEGIN
	UPDATE usuario set nombre = _nombre,apellido_paterno = _apellidoPaterno, apellido_materno = _apellidoMaterno,
    usuario = _usuario, pass = _password, correo_electronico = _correo where id_usuario = _id_usuario;
END$

CREATE PROCEDURE ACTUALIZAR_ALUMNO(
		in _id_usuario INT,
        IN _nombre VARCHAR(100),
        in _apellidoPaterno varchar(100),
        in _apellidoMaterno varchar(100),
        in _usuario varchar(100),
        in _password varchar(100),
        in _correo varchar(100),
        IN _codigoAlumno varchar(100),
        in _sexo CHAR(1),
        in _fecha_nacimiento DATE,
        in _fid_carrera INT,
        in _salt VARCHAR(12)
)
BEGIN
update usuario set
                nombre = _nombre,
                apellido_Paterno = _apellidoPaterno,
                apellido_Materno = _apellidoMaterno,
                usuario = _usuario,
                pass = _password,
                correo_Electronico = _correo,
                sexo = _sexo,
                salt = _salt,
                fecha_nacimiento = _fecha_nacimiento
where id_usuario = _id_usuario;
update alumno
	set fid_carrera = _fid_carrera
where id_alumno = _id_usuario;
END$
delimiter $
CREATE PROCEDURE LISTAR_HISTORIAL_X_ALUMNO(
	IN _alumno_id INT
) BEGIN
	SELECT nota_final, vez, codigo_curso, c.nombre "nombre_curso", semestre, CONCAT(u.nombre, ' ', u.apellido_paterno) "nombre_docente"
    FROM cursoxalumnoxsemestre cas
		INNER JOIN cursoxsemestre cs ON cs.id_cursoxsemestre = cas.fid_cursoxsemestre
        INNER JOIN curso c ON c.id_curso = fid_curso
        INNER JOIN semestre s ON cs.fid_semestre = s.id_semestre
        INNER JOIN cursoxdocentexsemestre cds ON cds.fid_cursoxsemestre = cs.id_cursoxsemestre
        INNER JOIN docente d ON d.id_docente = cds.fid_docente
        INNER JOIN empleado e ON e.id_empleado = d.id_docente
        INNER JOIN usuario u ON e.id_empleado = u.id_usuario
	WHERE cas.fid_alumno = _alumno_id
    ORDER BY 5 DESC;
END$    

delimiter $
CREATE PROCEDURE infoAlumno(
        IN _id_alumno int
)
BEGIN
SELECT concat(u.apellido_paterno, ' ' , u.apellido_materno , ' ' , u.nombre) as nombre_alumno,
a.codigo_alumno,a.id_alumno
from usuario u,alumno a
where _id_alumno = a.id_alumno and u.id_usuario = a.id_alumno;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_ALUMNOS_HORARIO(IN _id_horario INT)
BEGIN
	select u.nombre,
	u.id_usuario,
        u.apellido_paterno,
	u.apellido_materno,
        a.codigo_alumno,
	u.correo_electronico,
	a.fid_carrera,
	c.nombre as nombre_carrera
from carrera c JOIN 
        alumno a ON c.id_carrera = a.fid_carrera
    JOIN 
        alumnoxhorario l ON l.id_alumno = a.id_alumno
    JOIN 
        usuario u ON u.id_usuario = l.id_alumno
where a.estado = 1 and u.activo = 1 and c.id_carrera = a.fid_carrera
and l.id_horario = _id_horario;	
END$

delimiter $
CREATE PROCEDURE LISTAR_DOCENTES_HORARIO(IN _id_horario INT)
BEGIN
	select distinct u.nombre,
	u.id_usuario,
        u.apellido_paterno,
	u.apellido_materno,
        d.grado_academico,
	d.tipo_docente,
	u.correo_electronico,
	d.oficina,
	d.fid_facultad,
    u.telefono
from docente d
join docentexhorario l on l.id_horario = _id_horario
join usuario u ON u.id_usuario = l.id_docente
where d.activo = 1 and l.id_horario = _id_horario
and d.id_docente = l.id_docente;	
END$

DELIMITER $
CREATE PROCEDURE LISTAR_SEMESTRES_X_ALUMNO (
	IN _id_alumno INT
) BEGIN
	SELECT s.id_semestre, s.semestre, s.fecha_inicio, s.fecha_fin
    FROM alumno a
		INNER JOIN cursoxalumnoxsemestre cas ON cas.fid_alumno = a.id_alumno
        INNER JOIN cursoxsemestre cs ON cas.fid_cursoxsemestre = cs.id_cursoxsemestre
        INNER JOIN semestre s ON cs.fid_semestre = s.id_semestre
	WHERE a.id_alumno = _id_alumno
    GROUP BY s.id_semestre
    ORDER BY 2 ASC;
END$

CREATE PROCEDURE LISTAR_CASS_X_ALUMNO_SEMESTRE(
	IN _alumno_id INT,
    IN _semestre_id INT
) BEGIN
	SELECT cas.nota_final, cas.vez, c.codigo_curso, c.es_electivo, c.creditos, c.nombre
    FROM cursoxsemestre a
		INNER JOIN cursoxalumnoxsemestre cas ON cas.fid_cursoxsemestre = id_cursoxsemestre
		INNER JOIN curso c ON a.fid_curso = c.id_curso
    WHERE cas.fid_alumno = _alumno_id AND a.fid_semestre = _semestre_id;
END$

DELIMITER $
CREATE PROCEDURE ANULAR_PRESTAMO(
	IN _id_prestamo INT
)
BEGIN
	DECLARE _id_libro INT;
    SELECT id_libro FROM prestamo WHERE id_prestamo = _id_prestamo AND activo = 1 INTO _id_libro;
    
    UPDATE prestamo SET anulado = 1 WHERE id_prestamo = _id_prestamo AND activo = 1;
    UPDATE recursoBiblioteca SET disponible = 1 WHERE id_recurso = _id_libro;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_PRESTAMOS_X_LIBRO(
	IN _id_libro INT
)
BEGIN
    SELECT p.id_prestamo, p.id_libro,p.id_biblioteca,p.id_encargado_libro, p.tipo_encargado, p.fecha_retiro,p.fecha_devolucion_confirmada,p.fecha_maxima_devolucion,p.fecha_registro,p.anulado
    FROM prestamo p 
    WHERE p.activo = 1 AND p.id_libro = _id_libro
    ORDER BY p.fecha_registro DESC;
END$

CREATE PROCEDURE HALLAR_ENCARGADO_BIBLIOTECA_ID(
	IN _id_usuario INT
)
BEGIN
	SELECT u.id_usuario, u.sexo, u.nombre, u.apellido_paterno, u.apellido_materno, u.fecha_nacimiento, u.usuario, u.pass, b.titulo_trabajo, e.hora_entrada, e.hora_salida, e.fecha_contratacion
    FROM usuario u INNER JOIN encargadoBiblioteca b ON u.id_usuario = b.id_encargado_biblioteca INNER JOIN empleado e ON e.id_empleado = u.id_usuario
    WHERE u.id_usuario = _id_usuario;
END$

CREATE PROCEDURE LLENAR_MEDIA_APROBADOS_HORARIO(
    IN _id_horario INT,
    IN _id_curso INT,
    IN _id_semestre INT,
    OUT media DECIMAL(10,2),
    OUT aprobados INT
)
BEGIN
	DECLARE idcxm INT;
	SELECT cm.id_cursoxsemestre INTO idcxm
    FROM cursoxsemestre cm
	WHERE cm.fid_curso = _id_curso AND cm.fid_semestre = _id_semestre;
    
	SELECT  AVG(m.nota_final) INTO media
    FROM cursoxalumnoxsemestre m
    JOIN alumnoxhorario ah ON ah.id_alumno = m.fid_alumno
    JOIN horario h ON h.id_horario = ah.id_horario
    WHERE h.id_horario = _id_horario
    and ah.id_alumno = m.fid_alumno
    and m.fid_cursoxsemestre = idcxm;
    
    SELECT COUNT(m.fid_alumno) INTO aprobados
    FROM cursoxalumnoxsemestre m
    JOIN alumnoxhorario ah ON ah.id_alumno = m.fid_alumno
    JOIN horario h ON h.id_horario = ah.id_horario
    WHERE h.id_horario = _id_horario
    and ah.id_alumno = m.fid_alumno
    and m.nota_final > 10
    and m.fid_cursoxsemestre = idcxm;
END$

DELIMITER $
CREATE PROCEDURE BUSCAR_FOTO_PERFIL(
	IN _id_usuario INT
)
BEGIN
	SELECT foto_perfil FROM usuario WHERE id_usuario = _id_usuario;
END$

DELIMITER $
CREATE PROCEDURE REVISAR_PRESTAMOS_X_ANULAR()
BEGIN
	DECLARE done INT DEFAULT FALSE;
    DECLARE _id_prestamo INT;
    
    DECLARE cur CURSOR FOR
		SELECT p.id_prestamo FROM prestamo p
        WHERE p.fecha_retiro is null AND p.fecha_registro < DATE_SUB(CURDATE(),INTERVAL 2 DAY)
			AND p.activo = 1 AND p.anulado = 0;
		
        DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;
        
        OPEN cur;

    read_loop: LOOP
        FETCH cur INTO _id_prestamo;
        IF done THEN
            LEAVE read_loop;
        END IF;
        
        CALL ANULAR_PRESTAMO(_id_prestamo);
    END LOOP;

    CLOSE cur;
END$

DELIMITER $
CREATE PROCEDURE REVISAR_USUARIOS_DEUDORES()
BEGIN
	DECLARE done INT DEFAULT FALSE;
    DECLARE _id_usuario INT;
    DECLARE _tipo CHAR(1);
    
    -- Seleccionar los préstamos que han superado su fecha de devolución máxima
    DECLARE cur CURSOR FOR
        SELECT p.id_encargado_libro, p.tipo_encargado
        FROM prestamo p
        WHERE p.fecha_devolucion_confirmada IS NULL AND p.fecha_retiro IS NOT NULL AND p.activo = 1
        AND p.fecha_maxima_devolucion < CURDATE();
    
    -- Handler para el final del cursor
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;
    
    OPEN cur;
    
    read_loop: LOOP
        FETCH cur INTO _id_usuario, _tipo;
        IF done THEN
            LEAVE read_loop;
        END IF;
        
        -- Marcar al usuario como deudor actualizando el flag_deudor a 1
        IF _tipo = 'D' THEN
			UPDATE docente SET es_deudor_libros = 1 WHERE id_docente = _id_usuario;
		ELSE
			UPDATE alumno SET es_deudor_libros = 1 WHERE id_alumno = _id_usuario;
		END IF;
    END LOOP;
    CLOSE cur;
END$

