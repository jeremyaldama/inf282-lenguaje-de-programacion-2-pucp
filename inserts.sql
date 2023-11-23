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
                activo
        )
VALUES(
                "Daniel",
                "Castillo",
                "As",
                "daniel",
                "password123",
                "daniel.castillo@example.com",
                'M',
                STR_TO_DATE('2000-02-23', '%Y-%m-%d'),
                'A',
                1
        );
DECLARE @id_usuario INT;
SET @id_usuario = @@last_insert_id;
insert into alumno(id_Alumno, estado, codigo_Alumno,es_deudor_libros,fid_carrera)
values(7, 1, "20206228",0,2);

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
                1,
                "0781",
                STR_TO_DATE('08:00', '%H:%i'),
                STR_TO_DATE('10:00', '%H:%i'),
                "LUNES",
                40,
                35,
                15,
                'C',
                1
        );
        
INSERT INTO alumnoxhorario(id_alumno, id_horario) VALUES (7, 3);