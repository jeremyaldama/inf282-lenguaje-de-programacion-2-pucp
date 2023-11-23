

import java.util.Date;

public class Reclamo {
    private String codigoAlumno;
    private String codigoCurso;
    private Date fechaReclamo;
    private boolean esValido;
    private TipoReclamo tipoReclamo;
	
	public Reclamo(String codigoAlumno, String codigoCurso, Date fechaReclamo, TipoReclamo tipoReclamo){
		this.codigoAlumno = codigoAlumno;
		this.codigoCurso = codigoCurso;
		this.fechaReclamo = fechaReclamo;
		this.tipoReclamo = tipoReclamo;
		esValido = false;
	}
    public String getCodigoAlumno() {
        return codigoAlumno;
    }

    public void setCodigoAlumno(String codigoAlumno) {
        this.codigoAlumno = codigoAlumno;
    }

    public String getCodigoCurso() {
        return codigoCurso;
    }

    public void setCodigoCurso(String codigoCurso) {
        this.codigoCurso = codigoCurso;
    }

    public Date getFechaReclamo() {
        return fechaReclamo;
    }

    public void setFechaReclamo(Date fechaReclamo) {
        this.fechaReclamo = fechaReclamo;
    }

    public boolean isEsValido() {
        return esValido;
    }

    public void setEsValido(boolean esValido) {
        this.esValido = esValido;
    }

    public TipoReclamo getTipoReclamo() {
        return tipoReclamo;
    }

    public void setTipoReclamo(TipoReclamo tipoReclamo) {
        this.tipoReclamo = tipoReclamo;
    }
}
