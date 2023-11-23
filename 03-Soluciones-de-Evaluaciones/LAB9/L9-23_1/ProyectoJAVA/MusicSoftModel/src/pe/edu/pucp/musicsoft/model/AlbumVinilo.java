package pe.edu.pucp.musicsoft.model;
public class AlbumVinilo {
    private int idAlbumVinilo;
    private Genero genero;
    private Artista artista;
    private String nombre;
    private int anho;
    private double precio;
    private int cantCanciones;
    private boolean esEdicionGatefold;
    private boolean tieneCD;
    private boolean esEdicionColor;
    private String descripcion;
    private byte[] foto;

    public int getIdAlbumVinilo() {
        return idAlbumVinilo;
    }

    public void setIdAlbumVinilo(int idAlbumVinilo) {
        this.idAlbumVinilo = idAlbumVinilo;
    }

    public Genero getGenero() {
        return genero;
    }

    public void setGenero(Genero genero) {
        this.genero = genero;
    }

    public Artista getArtista() {
        return artista;
    }

    public void setArtista(Artista artista) {
        this.artista = artista;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public int getAnho() {
        return anho;
    }

    public void setAnho(int anho) {
        this.anho = anho;
    }

    public double getPrecio() {
        return precio;
    }

    public void setPrecio(double precio) {
        this.precio = precio;
    }

    public int getCantCanciones() {
        return cantCanciones;
    }

    public void setCantCanciones(int cantCanciones) {
        this.cantCanciones = cantCanciones;
    }

    public boolean isEsEdicionGatefold() {
        return esEdicionGatefold;
    }

    public void setEsEdicionGatefold(boolean esEdicionGatefold) {
        this.esEdicionGatefold = esEdicionGatefold;
    }

    public boolean isTieneCD() {
        return tieneCD;
    }

    public void setTieneCD(boolean tieneCD) {
        this.tieneCD = tieneCD;
    }

    public boolean isEsEdicionColor() {
        return esEdicionColor;
    }

    public void setEsEdicionColor(boolean esEdicionColor) {
        this.esEdicionColor = esEdicionColor;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public byte[] getFoto() {
        return foto;
    }

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }
    
}