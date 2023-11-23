/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/WebServices/WebService.java to edit this template
 */
package ulearn.web.webservices;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import ulearn.academic.dao.AlumnoDAO;
import ulearn.academic.dao.CarreraDAO;
import ulearn.academic.dao.CursoDAO;
import ulearn.academic.dao.CursoXAlumnoXSemestreDAO;
import ulearn.academic.dao.DocenteDAO;
import ulearn.academic.dao.EvaluacionDAO;
import ulearn.academic.dao.HorarioDAO;
import ulearn.academic.dao.ReclamoDAO;
import ulearn.academic.dao.SemestreDAO;
import ulearn.academic.model.Alumno;
import ulearn.academic.model.Carrera;
import ulearn.academic.model.Curso;
import ulearn.academic.model.CursoXAlumnoXSemestre;
import ulearn.academic.model.Docente;
import ulearn.academic.model.Evaluacion;
import ulearn.academic.model.Horario;
import ulearn.academic.model.NombreEvaluacion;
import ulearn.academic.model.Reclamo;
import ulearn.academic.model.Semestre;
import ulearn.academic.mysql.AlumnoMySQL;
import ulearn.academic.mysql.CarreraMySQL;
import ulearn.academic.mysql.CursoMySQL;
import ulearn.academic.mysql.CursoXAlumnoXSemestreMySQL;
import ulearn.academic.mysql.DocenteMySQL;
import ulearn.academic.mysql.EvaluacionMySQL;
import ulearn.academic.mysql.HorarioMySQL;
import ulearn.academic.mysql.ReclamoMySQL;
import ulearn.academic.mysql.SemestreMySQL;
import ulearn.staff.dao.UsuarioDAO;
import ulearn.staff.model.Usuario;
import ulearn.staff.mysql.UsuarioMySQL;

/**
 *
 * @author Danie
 */
@WebService(serviceName = "AcademicsWS")
public class AcademicsWS {
    
    private CarreraDAO daoCarrera = new CarreraMySQL();
    private CursoDAO daoCurso = new CursoMySQL();
    private SemestreDAO daoSemestre = new SemestreMySQL();
    private AlumnoDAO daoAlumno = new AlumnoMySQL();
    private DocenteDAO daoDocente= new DocenteMySQL();
    private HorarioDAO daoHorario = new HorarioMySQL();
    private EvaluacionDAO daoEvaluacion = new EvaluacionMySQL();
    private ReclamoDAO daoReclamo = new ReclamoMySQL();
    private UsuarioDAO daoUsuario = new UsuarioMySQL();
    private CursoXAlumnoXSemestreDAO daoCAS = new CursoXAlumnoXSemestreMySQL();
    
    @WebMethod(operationName = "eliminarHorario")
    public int eliminarHorario(@WebParam(name = "idHorario") int idHorario){
        int resultado = 0;
        try{
            resultado = daoHorario.eliminar(idHorario);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarAlumno")
    public int eliminarAlumno(@WebParam(name = "idAlumno") int id) {
        int resultado = 0;
        try{
            resultado = daoAlumno.eliminarAlumno(id);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarAlumno")
    public int actualizarAlumno(@WebParam(name = "alumno") Alumno alumno) {
        int resultado = 0;
        try{
            String salt = daoUsuario.hallarSalt(alumno.getUsuario());
            if(!"".equals(salt) && salt != null){
                String hash = Usuario.generarHashInicioSesion(alumno.getPassword(), salt);
                alumno.setPassword(hash);
            }else{
                alumno.generarEncriptacionConSalt();
            }
            resultado=daoAlumno.modificar(alumno);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarAlumnoPerfil")
    public int actualizarAlumnoPerfil(@WebParam(name = "alumno") Alumno alumno) {
        int resultado = 0;
        try{
            String salt = daoUsuario.hallarSalt(alumno.getUsuario());
            if(!"".equals(salt) && salt != null){
                String hash = Usuario.generarHashInicioSesion(alumno.getPassword(), salt);
                alumno.setPassword(hash);
            }else{
                alumno.generarEncriptacionConSalt();
            }
            resultado=daoAlumno.modificarPerfil(alumno);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarDocentePerfil")
    public int actualizarDocentePerfil(@WebParam(name = "docente") Docente docente) {
        int resultado = 0;
        try{
            String salt = daoUsuario.hallarSalt(docente.getUsuario());
            if(!"".equals(salt) && salt != null){
                String hash = Usuario.generarHashInicioSesion(docente.getPassword(), salt);
                docente.setPassword(hash);
            }else{
                docente.generarEncriptacionConSalt();
            }
            resultado=daoDocente.modificarPerfil(docente);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarDocente")
    public int actualizarDocente(@WebParam(name = "docente") Docente docente) {
        int resultado = 0;
        try{
            String salt = daoUsuario.hallarSalt(docente.getUsuario());
            if(!"".equals(salt) && salt != null){
                String hash = Usuario.generarHashInicioSesion(docente.getPassword(), salt);
                docente.setPassword(hash);
            }else{
                docente.generarEncriptacionConSalt();
            }
            resultado=daoDocente.modificar(docente);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "hallarDocentePorId")
    public Docente hallarDocentePorId(@WebParam(name = "idDocente") int idDocente){
        Docente docente = new Docente();
        try{
            docente = daoDocente.hallarDocentePorId(idDocente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return docente;
    }
    
    @WebMethod(operationName = "hallarAlumnoPorId")
    public Alumno hallarAlumnoPorId(@WebParam(name = "idAlumno")int idAlumno){
        Alumno alumno = new Alumno();
        try{
            alumno = daoAlumno.hallarAlumnoPorId(idAlumno);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return alumno;
    }
    
    @WebMethod(operationName = "modificarHorario")
    public int modificarHorario(@WebParam(name = "horario")Horario horario){
        int resultado = 0;
        try{
            resultado = daoHorario.modificar(horario);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarHorario")
    public int insertarHorario(@WebParam(name = "horario")Horario horario){
        int resultado = 0;
        try{
            resultado = daoHorario.insertar(horario);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarHorariosTodos")
    public ArrayList<Horario> listarHorariosTodos(){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            horarios = daoHorario.listarTodos();
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return horarios;
    }
    
    @WebMethod(operationName = "listarHorariosPorAlumno")
    public ArrayList<Horario> listarHorariosPorAlumno(@WebParam(name = "idAlumno") int idAlumno){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            horarios = daoHorario.listarPorAlumno(idAlumno);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return horarios;
    }
    
    @WebMethod(operationName = "listarSemestresPorAlumno")
    public ArrayList<Semestre> listarSemestresPorAlumno(@WebParam(name = "idAlumno") int idAlumno){
        ArrayList<Semestre> semestres = new ArrayList<>();
        try{
            semestres = daoSemestre.listarPorAlumno(idAlumno);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return semestres;
    }
    
    @WebMethod(operationName = "listarCASSPorAlumnoSemestre")
    public ArrayList<CursoXAlumnoXSemestre> listarCASSPorAlumnoSemestre(
            @WebParam(name = "idAlumno") int idAlumno,
            @WebParam(name = "idSemestre") int idSemestre){
        ArrayList<CursoXAlumnoXSemestre> cass = new ArrayList<>();
        try{
            cass = daoCAS.listarPorAlumnoSemestre(idAlumno, idSemestre);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return cass;
    }
    
    @WebMethod(operationName = "listarHorariosPorDocente")
    public ArrayList<Horario> listarHorariosPorDocente(@WebParam(name = "idDocente")int idDocente){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            horarios = daoHorario.listarPorDocente(idDocente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return horarios;
    }
    
    @WebMethod(operationName = "listarHorariosPorCurso")
    public ArrayList<Horario> listarHorariosPorCurso(@WebParam(name = "idCurso")int idCurso){
        ArrayList<Horario> horarios = new ArrayList<>();
        try{
            horarios = daoHorario.listarPorCurso(idCurso);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return horarios;
    }
    
    @WebMethod(operationName = "listarAlumnosDeHorario")
    public ArrayList<Alumno> listarAlumnosDeHorario(@WebParam(name = "idHorario") int idHorario){
        ArrayList<Alumno> alumnos = new ArrayList<>();
        try{
            alumnos = daoHorario.listarAlumnosDeHorario(idHorario);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return alumnos;
    }
    
    @WebMethod(operationName = "listarDocentesDeHorario")
    public ArrayList<Docente> listarDocentesDeHorario(@WebParam(name = "idHorario") int idHorario){
        ArrayList<Docente> docentes = new ArrayList<>();
        try{
            docentes = daoHorario.listarDocentesDeHorario(idHorario);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return docentes;
    }
    
    
    @WebMethod(operationName = "insertarDocente")
    public int insertarDocente(@WebParam(name = "docente")Docente docente){
        int resultado = 0;
        try{
           docente.generarEncriptacionConSalt();
           resultado =  daoDocente.agregarDocente(docente);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarDocentePorId")
    public int eliminarDocente(@WebParam(name = "idDocente") int idDocente) {
        int resultado = 0;
        try {
            resultado = daoDocente.eliminarDocente(idDocente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarDocentesPorNombre")
    public ArrayList<Docente> listarDocentesPorNombre(String nombre){
        ArrayList<Docente> docentes = new ArrayList<>();
        try{
            docentes =  daoDocente.listarDocentesXNombre(nombre); 
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return docentes;
    }
    
    @WebMethod(operationName = "listarDocentesTodos")
    public ArrayList<Docente> listarDocentesTodos(){
        ArrayList<Docente> docentes = new ArrayList<>();
        try{
            docentes =  daoDocente.listarDocentes(); 
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return docentes;
    }
    
    @WebMethod(operationName = "actualizarCorreoDocente")
    public int actualizarCorreoDocente(@WebParam(name = "correo") String correo, @WebParam(name = "idDocente") int idDocente) {
        int resultado = 0;
        try {
            resultado = daoDocente.actualizarCorreo(correo, idDocente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "actualizarContrasenhaDocente")
    public int actualizarContrasenhaDocente(@WebParam(name = "password") String password, @WebParam(name = "idDocente") int idDocente) {
        int resultado = 0;
        try {
            resultado = daoDocente.actualizarContrasenha(password, idDocente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "actualizarUsuarioDocente")
    public int actualizarUsuario(@WebParam(name = "user") String user, @WebParam(name = "idDocente") int idDocente) {
        int resultado = 0;
        try {
            resultado = daoDocente.actualizarUsuario(user, idDocente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }

    @WebMethod (operationName = "actualizarTipoDocentePorId")
    public int actualizarTipoDocente(@WebParam(name = "tipoDocente") String tipoDocente, @WebParam(name = "idDocente") int idDocente) {
        int resultado = 0;
        try {
            resultado = daoDocente.actualizarTipoDocente(tipoDocente, idDocente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarCursosDocentePorId")
    public ArrayList<Curso> listarCursosDocente(@WebParam(name = "idDocente") int idDocente) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            cursos = daoDocente.listarCursosDocente(idDocente);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "listarCursosCodigoNombre")
    public ArrayList<Curso> listarCursosCodigoNombre(@WebParam(name = "codigoNombre") String codigoNombre) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try{
            cursos = daoCurso.listarCursosCodigoNombre(codigoNombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "listarCursosAlumnoPorId")
    public ArrayList<Curso> listarCursosAlumno(@WebParam(name = "idDocente") int idAlumno) {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            cursos = daoAlumno.listarCursosAlumnos(idAlumno);
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "insertarAlumno")
    public int insertarAlumno(@WebParam(name = "alumno") Alumno alumno) {
        int resultado = 0;
        try{
            alumno.generarEncriptacionConSalt();
            resultado=daoAlumno.insertarAlumno(alumno);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "actualizarContrasenha")
    public int actualizarContrasenhaAlumno(@WebParam(name = "password") String password,@WebParam(name = "idAlumno") int id) {
        int resultado = 0;
        try{
            resultado=daoAlumno.actualizarContrasenha(password,id);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarAlumnosXCodigoNombre")
    public ArrayList<Alumno> listarAlumnosXCodigoNombre(@WebParam(name = "codigoNombre") String codigoNombre) {
        ArrayList<Alumno> alumnos = new ArrayList<>();
        try{
            alumnos = daoAlumno.listarAlumnosXCodigoNombre(codigoNombre);
        }
        catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return alumnos;
    }
    
    @WebMethod(operationName = "listarTodasCarreras")
    public ArrayList<Carrera> listarTodasCarreras() {
        ArrayList<Carrera> carreras = new ArrayList<>();
        try {
            carreras = daoCarrera.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return carreras;
    }
    
    @WebMethod(operationName = "listarCarrerasPorFacultad")
    public ArrayList<Carrera> listarCarrerasPorFacultad(@WebParam(name = "idFacultad")
                            int idFacultad) {
        ArrayList<Carrera> carreras = new ArrayList<>();
        try {
            carreras = daoCarrera.listarPorFacultad(idFacultad);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return carreras;
    }
    
    @WebMethod(operationName = "insertarCarrera")
    public int insertarCarrera(@WebParam(name = "carrera")
                            Carrera carrera) {
        int resultado = 0;
        try {
            resultado = daoCarrera.insertar(carrera);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarCarrera")
    public int eliminarCarrera(@WebParam(name = "idCarrera")
                            int idCarrera) {
        int resultado = 0;
        try {
            resultado = daoCarrera.eliminar(idCarrera);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarCarrera")
    public int modificarCarrera(@WebParam(name = "carrera")
                            Carrera carrera) {
        int resultado = 0;
        try {
            resultado = daoCarrera.modificar(carrera);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "listarTodosCursos")
    public ArrayList<Curso> listarTodosCursos() {
        ArrayList<Curso> cursos = new ArrayList<>();
        try {
            cursos = daoCurso.listarTodos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cursos;
    }
    
    @WebMethod(operationName = "eliminarCurso")
    public int eliminarCurso(@WebParam(name = "idCurso")
                            int idCurso) {
        int resultado = 0;
        try {
            resultado = daoCurso.eliminarCurso(idCurso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "insertarCurso")
    public int insertarCurso(@WebParam(name = "curso")
                            Curso curso) {
        int resultado = 0;
        try {
            resultado = daoCurso.insertarCurso(curso);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    
    @WebMethod(operationName = "listarTodosSemestres")
    public ArrayList<Semestre> listarTodosSemestres() {
        ArrayList<Semestre> semestres = new ArrayList<>();
        try {
            semestres = daoSemestre.listarTodos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return semestres;
    }
    
    @WebMethod(operationName = "insertarSemestre")
    public int insertarSemestre(@WebParam(name = "semestre")
                            Semestre semestre) {
        int resultado = 0;
        try {
            resultado = daoSemestre.insertar(semestre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "eliminarSemestre")
    public int eliminarSemestre(@WebParam(name = "idSemestre")
                            int idSemestre) {
        int resultado = 0;
        try {
            resultado = daoSemestre.eliminar(idSemestre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "modificarSemestre")
    public int modificarSemestre(@WebParam(name = "semestre")
                            Semestre semestre) {
        int resultado = 0;
        try {
            resultado = daoSemestre.modificar(semestre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName="listarEvaluacionPorCursoSemestre")
    public ArrayList<Evaluacion> listarEvaluacionPorCursoSemestre(@WebParam(name = "curso")Curso curso){
        ArrayList<Evaluacion> evaluaciones = null;
        try{
            evaluaciones = daoEvaluacion.listarPorCursoYSemestre(curso);
        }catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return evaluaciones;
    }
    
    @WebMethod(operationName = "agregarAlumnoAHorario")
    public int agregarAlumnoAHorario(@WebParam(name = "alumno")Alumno alumno,
    @WebParam(name = "horario") Horario horario){
        int res = 0;
        try{
            Evaluacion evaluacion;
            res = daoHorario.agregarAlumnoHorario(alumno, horario); //retorna una llave para poder insertar evaluaciones para este alumno si no esta repetido
            if (horario.getCurso().getEvaluaciones() == null && res != 0){ //cambio importante 
                horario.getCurso().setEvaluaciones(new ArrayList<>());
                for(NombreEvaluacion n : NombreEvaluacion.values()){ //se agregan todas las instancias de evaluacion que tiene ese curso por alumno
                    evaluacion = new Evaluacion();
                    evaluacion.setNombreEvaluacion(n);
                    evaluacion.setNota(-1);
                    daoEvaluacion.insertar(evaluacion, res);
                }
            } 
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }
    
    @WebMethod(operationName = "agregarDocenteAHorario")
    public int agregarDocenteHorario(@WebParam(name = "idDocente")int idDocente,@WebParam(name = "idHorario") int idHorario){
        int res = 0;
        try{
            res = daoHorario.agregarDocenteHorario(idDocente, idHorario);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }
    
    @WebMethod(operationName = "modificarEvaluacion")
    public int modificarEvaluacion(@WebParam(name="evaluacion")Evaluacion evaluacion){
        int res = 0;
        try{
            res = daoEvaluacion.modificar(evaluacion);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }
    
    @WebMethod(operationName = "listarReclamoPorCursoSemestre")
    public ArrayList<Reclamo> listarReclamoPorCursoSemestre(@WebParam(name = "curso")Curso curso){
        ArrayList<Reclamo> reclamos = null;
        try{
            reclamos = daoReclamo.listarPorCursoYSemestre(curso);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reclamos;
    }
    
    @WebMethod(operationName = "listarReclamoPorAlumnoSemestre")
    public ArrayList<Reclamo> listarReclamoPorAlumnoSemestre(@WebParam(name = "alumno")Alumno alumno){
        ArrayList<Reclamo> reclamos = null;
        try{
            reclamos = daoReclamo.listarPorAlumnoYSemestre(alumno);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return reclamos;
    }
    
    @WebMethod(operationName = "modificarReclamo")
    public int modificarReclamo(@WebParam(name = "reclamo")Reclamo reclamo){
        int res = 0;
        try{
            res = daoReclamo.modificar(reclamo);
            res = daoEvaluacion.modificar(reclamo.getEvaluacion());//se actualiza la eval
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return res;
    }
    
    @WebMethod(operationName = "hallarTotalizadosHorario")
    public Horario hallarTotalizadosHorario(@WebParam(name = "horario")Horario horario, @WebParam(name = "curso")Curso curso){
        int resultado = 0;
        try{
            resultado = daoHorario.conseguirTotalizados(horario,curso);
            if(resultado == 0){ //si no hay registro
                horario.setMedia(-1);
                horario.setAprobados(-1);
            }
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return horario;
    }
       
    @WebMethod(operationName = "actualizarCurso")
    public int actualizarCurso(@WebParam(name = "curso")Curso curso){
        int resultado = 0;
        try{
            resultado = daoCurso.modificar(curso);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "agregarCursoASemestre")
    public int agregarCursoASemestre(@WebParam(name = "idCurso")int idCurso,@WebParam(name = "idSemestre") int idSemestre){
        int resultado = 0;
        try{
            resultado = daoCurso.agregarCursoASemestre(idCurso,idSemestre);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "listarEvaluacionxAlumno")
    public ArrayList<Evaluacion> listarEvaluacionxAlumno(@WebParam(name = "alumno")Alumno alumno){
        ArrayList<Evaluacion> evaluaciones = null;
        try{
            evaluaciones = daoEvaluacion.listarEvaluacionxAlumno(alumno);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return evaluaciones;
    }
    
     @WebMethod(operationName = "insertarReclamo")
    public int insertarReclamo(@WebParam(name = "reclamo")Reclamo reclamo){
        int resultado = 0;
        try{
           resultado =  daoReclamo.insertar(reclamo);
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
        return resultado;
    }
    
    
}
