
public class Libro extends RecursoBiblioteca{
    private int nroCopias;
    private int nroPaginas;
    private String ISBN;
	
	public Libro(String autor, String titulo, String ISBN, int nroCopias, int nroPaginas){
		super(autor,titulo);
		this.ISBN = ISBN;
		this.nroCopias = nroCopias;
		this.nroPaginas = nroPaginas;
	}
    public int getNroCopias() {
        return nroCopias;
    }

    public void setNroCopias(int nroCopias) {
        this.nroCopias = nroCopias;
    }

    public int getNroPaginas() {
        return nroPaginas;
    }

    public void setNroPaginas(int nroPaginas) {
        this.nroPaginas = nroPaginas;
    }

    public String getISBN() {
        return ISBN;
    }

    public void setISBN(String ISBN) {
        this.ISBN = ISBN;
    }
    
}
