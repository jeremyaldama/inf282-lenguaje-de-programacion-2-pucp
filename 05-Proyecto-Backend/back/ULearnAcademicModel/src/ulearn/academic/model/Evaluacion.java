package ulearn.academic.model;

public class Evaluacion{
    private int idEvaluacion;
    private Curso curso;
    private Alumno alumno;
    private Semestre semestre;
    private double nota;
    private NombreEvaluacion nombreEvaluacion;
    private boolean activo;
    private char asistio;
    private Reclamo reclamo;

    public Curso getCurso() {
        return curso;
    }

    public void setCurso(Curso curso) {
        this.curso = curso;
    }

    public Alumno getAlumno() {
        return alumno;
    }

    public void setAlumno(Alumno alumno) {
        this.alumno = alumno;
    }


    public double getNota() {
        return nota;
    }

    public void setNota(double nota) {
        this.nota = nota;
    }

    public NombreEvaluacion getNombreEvaluacion() {
        return nombreEvaluacion;
    }

    public void setNombreEvaluacion(NombreEvaluacion nombreEvaluacion) {
        this.nombreEvaluacion = nombreEvaluacion;
    }

    public Semestre getSemestre() {
        return semestre;
    }

    public void setSemestre(Semestre semestre) {
        this.semestre = semestre;
    }

    public boolean isActivo() {
        return activo;
    }

    public void setActivo(boolean activo) {
        this.activo = activo;
    }

    public char getAsistio() {
        return asistio;
    }

    public void setAsistio(char asistio) {
        this.asistio = asistio;
    }

    public int getIdEvaluacion() {
        return idEvaluacion;
    }

    public void setIdEvaluacion(int idEvaluacion) {
        this.idEvaluacion = idEvaluacion;
    }

    /**
     * @return the reclamo
     */
    public Reclamo getReclamo() {
        return reclamo;
    }

    /**
     * @param reclamo the reclamo to set
     */
    public void setReclamo(Reclamo reclamo) {
        this.reclamo = reclamo;
    }
}
