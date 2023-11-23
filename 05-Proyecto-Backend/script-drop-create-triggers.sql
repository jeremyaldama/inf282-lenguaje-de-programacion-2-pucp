DROP TRIGGER IF EXISTS CalcularNotaFinal;
DROP TRIGGER IF EXISTS tr_actualizacion_inicial_historial_academico;
DROP TRIGGER IF EXISTS tr_actualizacion_final_historial_academico;
DROP TRIGGER IF EXISTS incrementar_cursos_totales;
DROP TRIGGER IF EXISTS VERIFICAR_DEUDAR_TRAS_DEVOLUCION;



DELIMITER $
CREATE TRIGGER VERIFICAR_DEUDAS_TRAS_DEVOLUCION 
AFTER UPDATE ON prestamo
FOR EACH ROW
BEGIN
	DECLARE contador INT;
        DECLARE _deudor INT;
        
        IF NEW.tipo_encargado = 'D' THEN
		SELECT es_deudor_libros INTO _deudor
		FROM docente WHERE id_docente = NEW.id_encargado_libro AND activo=1;
	ELSE 
		SELECT es_deudor_libros INTO _deudor
		FROM alumno WHERE id_alumno = NEW.id_encargado_libro AND activo=1;
        END IF;
		
        IF _deudor = 1 THEN
		SELECT COUNT(*) INTO contador
            	FROM prestamo WHERE id_encargado_libro = NEW.id_encargado_libro AND activo = 1 AND
		fecha_devolucion_confirmada IS NULL AND fecha_retiro IS NOT NULL AND fecha_maxima_devolucion < CURDATE();
		IF contador = 0 THEN
			IF NEW.tipo_encargado = 'D' THEN
				UPDATE docente SET es_deudor_libros = 0 WHERE id_docente = NEW.id_encargado_libro;
			ELSE 
				UPDATE alumno SET es_deudor_libros = 0 WHERE id_alumno = NEW.id_encargado_libro;
			END IF;
        	END IF;
	END IF;
END$

DELIMITER $

CREATE TRIGGER CalcularNotaFinal
AFTER UPDATE ON evaluacion
FOR EACH ROW
BEGIN
    DECLARE asistio_not_null INT;
    -- Check if 'asistio' is not null for all rows with the same 'id_cursoxalumnoxsemestre'
    SELECT COUNT(*)
    INTO asistio_not_null
    FROM evaluacion
    WHERE fid_idcursoxalumnoxsemestre = NEW.fid_idcursoxalumnoxsemestre
    AND asistio IS NULL;
    IF asistio_not_null = 0 THEN
		-- Execute the stored procedure to calculate the weighted final grade
		CALL CALCULAR_NOTA_FINAL(NEW.fid_idcursoxalumnoxsemestre, @nota_final);
		-- Do something with the calculated final grade if needed
		UPDATE cursoxalumnoxsemestre
		SET nota_final = @nota_final
		WHERE id_cursoxalumnoxsemestre = NEW.fid_idcursoxalumnoxsemestre;
    END IF;
END$

CREATE TRIGGER tr_actualizacion_inicial_historial_academico
AFTER INSERT ON cursoxalumnoxsemestre
FOR EACH ROW
BEGIN
    DECLARE total_creditos DOUBLE;
    DECLARE r_count INT;
	DECLARE _id_curso INT;
    DECLARE _num_veces INT;
	-- Check if there's an existing row for the student in historialAcademico
    SELECT COUNT(*)
    INTO r_count
    FROM historialAcademico
    WHERE id_alumno = NEW.fid_alumno;
    
	SELECT c.creditos 
    INTO total_creditos
    FROM curso c
		JOIN cursoxsemestre m ON m.fid_curso = c.id_curso
    WHERE m.id_cursoxsemestre = NEW.fid_cursoxsemestre
		AND m.fid_curso = c.id_curso;
        
    -- If no row exists, insert a new row for the student
    IF r_count = 0 THEN
        INSERT INTO historialAcademico (id_alumno, cantidad_cursos_total, cantidad_cursos_aprobados, cantidad_creditos_total, cantidad_creditos_aprobados, nivel_academico)
        VALUES (NEW.fid_alumno, 1, 0, total_creditos, 0.0, 1);
	ELSE
		-- Update only cantidad_cursos_total and cantidad_creditos_total in historialAcademico for the student
		UPDATE historialAcademico h
		SET h.cantidad_cursos_total = h.cantidad_cursos_total + 1,
			h.cantidad_creditos_total = h.cantidad_creditos_total + total_creditos
		WHERE h.id_alumno = NEW.fid_alumno;
        
        SELECT fid_curso
        INTO _id_curso
        FROM cursoxsemestre
        WHERE id_cursoxsemestre = NEW.fid_cursoxsemestre;
        
        SELECT COUNT(*)
        INTO _num_veces
        FROM cursoxalumnoxsemestre cas
			INNER JOIN cursoxsemestre cs ON cs.id_cursoxsemestre = cas.fid_cursoxsemestre
		WHERE cas.fid_alumno = NEW.fid_alumno AND cs.fid_curso = _id_curso;
        
        UPDATE cursoxalumnoxsemestre
        SET vez = _num_veces + 1
        WHERE id_cursoxalumnoxsemestre = NEW.id_cursoxalumnoxsemestre;
    END IF;
END$

CREATE TRIGGER tr_actualizacion_final_historial_academico
AFTER UPDATE ON cursoxalumnoxsemestre
FOR EACH ROW
BEGIN
    DECLARE aprobados_cursos INT;
    DECLARE aprobados_creditos DOUBLE;

    -- Calculate the number of approved courses and credits for the updated row
    IF NEW.nota_final > 10 THEN
		SELECT c.creditos INTO aprobados_creditos
		FROM cursoxalumnoxsemestre cx
        JOIN cursoxsemestre m ON m.id_cursoxsemestre = cx.fid_cursoxsemestre
		JOIN curso c ON m.fid_curso = c.id_curso
		WHERE cx.fid_cursoxsemestre = NEW.fid_cursoxsemestre
        AND m.fid_curso = c.id_curso
        and m.id_cursoxsemestre = cx.fid_cursoxsemestre
		AND cx.nota_final > 10;
        -- Update the historialAcademico table for the student
		UPDATE historialAcademico h 
		SET 
			h.cantidad_cursos_aprobados = h.cantidad_cursos_aprobados + 1,
			h.cantidad_creditos_aprobados = h.cantidad_creditos_aprobados + aprobados_creditos,
			h.nivel_academico = CASE
				WHEN h.cantidad_cursos_aprobados >= 6 THEN 2
				WHEN h.cantidad_cursos_aprobados >= 12 THEN 3
				WHEN h.cantidad_cursos_aprobados >= 18 THEN 4
				WHEN h.cantidad_cursos_aprobados >= 24 THEN 5
				WHEN h.cantidad_cursos_aprobados >= 30 THEN 6
				WHEN h.cantidad_cursos_aprobados >= 36 THEN 7
				WHEN h.cantidad_cursos_aprobados >= 42 THEN 8
				WHEN h.cantidad_cursos_aprobados >= 48 THEN 9
				WHEN h.cantidad_cursos_aprobados >= 54 THEN 10
				ELSE 1
			END
		WHERE
			h.id_alumno = NEW.fid_alumno;
	END IF;
END$

CREATE TRIGGER incrementar_cursos_totales
AFTER INSERT ON cursoxcarrera
FOR EACH ROW
BEGIN
	DECLARE cred DOUBLE;
    
    SELECT creditos
    INTO cred
    FROM curso
    WHERE id_curso = NEW.id_curso;
    
    UPDATE carrera SET cursos_totales = cursos_totales + 1,
						creditos = creditos + cred
    WHERE id_carrera = NEW.id_carrera;
END$
