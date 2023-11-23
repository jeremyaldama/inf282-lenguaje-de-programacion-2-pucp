package ulearn.academic.model;
import java.util.ArrayList;
import java.util.Date;
import ulearn.staff.model.Usuario;

public class Alumno extends Usuario implements IConsultarCalendario{
    private int codAlumno;
    private String codigoAlumno;
    private ArrayList<Horario> horariosInscritos;
    private ArrayList<Evaluacion> evaluaciones;
    private HistorialAcademico historialAcademico;
    private Carrera carrera;
    private int esDeudor;
    private double creditosTotal;
    private int cursosTotal;

    public double getCreditosTotal() {
        return creditosTotal;
    }

    public void setCreditosTotal(double creditosTotal) {
        this.creditosTotal = creditosTotal;
    }

    public int getCursosTotal() {
        return cursosTotal;
    }

    public void setCursosTotal(int cursosTotal) {
        this.cursosTotal = cursosTotal;
    }

    public Alumno(String codigoAlumno, String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password, String correoElectronico, Date fechaNacimiento, char sexo, Carrera carrera) {
        super(nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico, fechaNacimiento, sexo);
        this.codigoAlumno = codigoAlumno;
        this.carrera = carrera;
    }

    

    public Alumno(){
        
    }
    public int getCodAlumno() {
        return codAlumno;
    }

    public void setCodAlumno(int codAlumno) {
        this.codAlumno = codAlumno;
    }

    public ArrayList<Evaluacion> getEvaluaciones() {
        return evaluaciones;
    }

    public void setEvaluaciones(ArrayList<Evaluacion> evaluaciones) {
        this.evaluaciones = evaluaciones;
    }

    public String getCodigoAlumno() {
        return codigoAlumno;
    }

    public void setCodigoAlumno(String codigoAlumno) {
        this.codigoAlumno = codigoAlumno;
    }

    @Override
    public String consultarDatos() {
       String reporte = "";
       return reporte;
    }

    @Override
    public String consultarCalendarioAcademico() {
        String reporte = "";
        return reporte;
    }

    public ArrayList<Horario> getHorariosInscritos() {
        return horariosInscritos;
    }

    public void setHorariosInscritos(ArrayList<Horario> horariosInscritos) {
        this.horariosInscritos = horariosInscritos;
    }
    
    
//    public void solicitarPrestamo(Libro libro){} //DEBE SER INTERFAZ
//    public void registrarReclamo(){}
//	public void inscribirseCurso(){}

    @Override
    public void consultarRecursosBiblioteca() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    public HistorialAcademico getHistorialAcademico() {
        return historialAcademico;
    }

    public void setHistorialAcademico(HistorialAcademico historialAcademico) {
        this.historialAcademico = historialAcademico;
    }

    public Carrera getCarrera() {
        return carrera;
    }

    public void setCarrera(Carrera carrera) {
        this.carrera = carrera;
    }

    public int getEsDeudor() {
        return esDeudor;
    }

    public void setEsDeudor(int esDeudor) {
        this.esDeudor = esDeudor;
    }
    
    
}
