package ulearn.academic.model;


import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Date;
import ulearn.staff.model.Empleado;


public class Docente extends Empleado implements IConsultarCalendario{
    
    private String tipoDocente;
    private ArrayList<Curso> cursosDictar;
    private String oficina;
    private String intereses;
    private String gradoAcademico;
    private Facultad facultad;
    private int esDeudor;
    
    public Docente(LocalTime horaEntrada, LocalTime horaSalida, Date fechaContratacion, String nombre, String apellidoPaterno, String apellidoMaterno, String usuario, String password,String tipoDocente, String correoElectronico, Date fechaNacimiento, char sexo
    ,String oficina, String intereses, String gradoAcademico) {
        super(horaEntrada, horaSalida, fechaContratacion, nombre, apellidoPaterno, apellidoMaterno, usuario, password, correoElectronico, fechaNacimiento, sexo);
        this.tipoDocente = tipoDocente;
        this.oficina = oficina;
        this.intereses = intereses;
        this.gradoAcademico = gradoAcademico;
    }
    
    public Docente(){
        
    }

    public String getGradoAcademico() {
        return gradoAcademico;
    }

    public void setGradoAcademico(String gradoAcademico) {
        this.gradoAcademico = gradoAcademico;
    }

    public String getOficina() {
        return oficina;
    }

    public void setOficina(String oficina) {
        this.oficina = oficina;
    }

    public String getIntereses() {
        return intereses;
    }

    public void setIntereses(String intereses) {
        this.intereses = intereses;
    }
    public String getTipoDocente() {
        return tipoDocente;
    }

    public void setTipoDocente(String tipoDocente) {
        this.tipoDocente = tipoDocente;
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

    public ArrayList<Curso> getCursosDictar() {
        return cursosDictar;
    }

    public void setCursosDictar(ArrayList<Curso> cursosDictar) {
        this.cursosDictar = cursosDictar;
    }
    

    public void consultarNotaAlumnos(){}
    public void registrarNota(){}
    public void consultarReclamos(){}

    @Override
    public void consultarRecursosBiblioteca() {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    public Facultad getFacultad() {
        return facultad;
    }

    public void setFacultad(Facultad facultad) {
        this.facultad = facultad;
    }

    public int getEsDeudor() {
        return esDeudor;
    }

    public void setEsDeudor(int esDeudor) {
        this.esDeudor = esDeudor;
    }  
}
